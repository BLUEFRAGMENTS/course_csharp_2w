using System;
namespace KursusApi.Entities
{
	public class PizzaOrder
	{
		public Guid Id { get; set; }

		public string PizzaName { get; set; }

		public string BuyerName { get; set; }

		public DateTime OrderTimeStamp { get; set; }
	}
}

