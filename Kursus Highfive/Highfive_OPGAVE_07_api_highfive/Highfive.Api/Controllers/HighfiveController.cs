using Highfive.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Highfive.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighfiveController : ControllerBase
    {
        private static List<HighfiveResult> _highfiveResults = new List<HighfiveResult>();

        [HttpPost]
        public async Task<IActionResult> TryToHighfiveAsync(
            [FromBody] HighfivePerson highfivePerson)
        {
            // 1. Find afventende highfive
            var pendingHighfive = _highfiveResults.FirstOrDefault(x => x.HighfivePerson2 == null);

            if (pendingHighfive == null)
            {
                // 2. Hvis der ikke er nogle, så lave en
                pendingHighfive = new HighfiveResult()
                {
                    HighfivePerson1 = highfivePerson
                };

                _highfiveResults.Add(pendingHighfive);
            }
            else
            {
                // 3. Hvis der findes en afventende, så tilføj dig selv som highfive person2.
                pendingHighfive.HighfivePerson2 = highfivePerson;
            }

            // 4. Tjek om vi har fået en highfive (hvis ikke venter vi 3 sekunder)
            var erHighfiveSucces = pendingHighfive.HighfivePerson2 != null;
            if (erHighfiveSucces == false)
            {
                await Task.Delay(3_000);
            }

            _highfiveResults.Remove(pendingHighfive);
            return new OkObjectResult(pendingHighfive);
        }

        [HttpGet("Ping")]
        public IActionResult Ping()
        {
            return new OkObjectResult("Pong");
        }
    }
}
