using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePizzaria
{
    public class PizzaOrdre
    {
        public Guid Id { get; set; }

        public string? PizzaName { get; set; }

        public string? BuyerName { get; set; }

        public DateTime OrderTimeStamp { get; set; }

        public string TimeLeftForOrderSek => Math.Round((OrderTimeStamp.AddMinutes(10) - DateTime.UtcNow).TotalSeconds, 0).ToString();
    }
}
