using KursusApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KursusApi.Controllers
{
    [ApiController]
    [Route("pizzaria")]
    public class OnlinePizzariaController : ControllerBase
    {
        private static object _pizzaLock = new object();

        // Hack to fake a database of PizzaOrders.
        private static List<PizzaOrder> _pizzaOrders = new List<PizzaOrder>();

        [HttpGet("orders")]
        public IActionResult GetAllOrders()
        {
            try
            {
                CleanUpOrders();
                return new OkObjectResult(_pizzaOrders);
            }
            catch (Exception ex)
            {
                throw new Exception($"Der skete en fejl ved afhentning af alle pizza ordre, ex: {ex}");
            }
        }

        [HttpGet("order")]
        public IActionResult GetOrderedPizza(Guid pizzaOrderId)
        {
            try
            {
                CleanUpOrders();
                var pizzaOrder = _pizzaOrders.FirstOrDefault(x => x.Id == pizzaOrderId);
                return new OkObjectResult(pizzaOrder);
            }
            catch (Exception ex)
            {
                throw new Exception($"Der skete en fejl ved afhentning af pizza ordre, ex: {ex}");
            }
        }

        [HttpPost("order")]
        public IActionResult OrderPizza(PizzaOrder pizzaOrder)
        {
            try
            {
                CleanUpOrders();
                lock (_pizzaLock)
                {
                    if (_pizzaOrders == null)
                    {
                        throw new Exception("Your pizza order is null");
                    }

                    if (_pizzaOrders.Exists(x => x.Id == pizzaOrder.Id))
                    {
                        throw new Exception("Pizza order already in place");
                    }

                    pizzaOrder.OrderTimeStamp = DateTime.UtcNow;
                    _pizzaOrders.Add(pizzaOrder);
                }

                return new OkObjectResult(pizzaOrder);
            }
            catch (Exception ex)
            {
                throw new Exception($"Der skete en fejl ved oprettelse af pizza ordre, ex: {ex}");
            }
        }

        [HttpPut("order")]
        public IActionResult UpdatePizzaOrder(PizzaOrder updatedPizzaOrder)
        {
            try
            {
                CleanUpOrders();
                lock (_pizzaLock)
                {
                    var pizzaIndex = _pizzaOrders.FindIndex(x => x.Id == updatedPizzaOrder.Id);
                    if (pizzaIndex >= 0)
                    {
                        var oldPizza = _pizzaOrders[pizzaIndex];
                        updatedPizzaOrder.OrderTimeStamp = DateTime.UtcNow;
                        updatedPizzaOrder.Id = oldPizza.Id;
                        _pizzaOrders[pizzaIndex] = updatedPizzaOrder;
                    }
                }

                return new OkObjectResult(updatedPizzaOrder);
            }
            catch (Exception ex)
            {
                throw new Exception($"Der skete en fejl ved opdatering af pizza ordre, ex: {ex}");
            }
        }

        [HttpDelete("order")]
        public IActionResult DeletePizzaOrder([FromQuery]string id)
        {
            try
            {
                CleanUpOrders();
                lock (_pizzaLock)
                {
                    var pizzaToRemove = _pizzaOrders.FirstOrDefault(x => x.Id.ToString() == id);
                    if (pizzaToRemove != null)
                    {
                        _pizzaOrders.Remove(pizzaToRemove);
                    }
                }

                return new NoContentResult();
            }
            catch (Exception ex)
            {
                throw new Exception($"Der skete en fejl ved sletning af pizza ordre, ex: {ex}");
            }
        }

        private void CleanUpOrders()
        {
            lock(_pizzaLock)
            {
                _pizzaOrders.RemoveAll(ordre => DateTime.UtcNow > ordre.OrderTimeStamp.AddMinutes(10));
            }
        }
    }
}