using Newtonsoft.Json;
using System.Text;

namespace OnlinePizzaria
{
    internal class PizzaApp
    {
        private const string baseUrl = "https://programmeringkursus101.azurewebsites.net";

        private readonly HttpClient _httpClient;

        public PizzaApp()
        {
            _httpClient = new HttpClient();
        }

        public async Task<PizzaOrdre?> LavEnOrdreAsync(string købersNavn, string pizza)
        {
            Console.WriteLine("Der laves en bestilling...");
            var pizzaOrder = new PizzaOrdre()
            {
                Id = Guid.NewGuid(),
                BuyerName = købersNavn,
                PizzaName = pizza,
            };

            var contentAsJson = JsonConvert.SerializeObject(pizzaOrder);
            var stringContent = new StringContent(contentAsJson, Encoding.UTF8, "application/json");

            // SKRIV KODE HER:
            // Fjern delay og skrive koden
            await Task.Delay(100);

            return null;
        }

        public async Task<List<PizzaOrdre>?> HentAlleOrdreAsync()
        {
            Console.WriteLine("Henter alle bestillinger...");

            // SKRIV KODE HER:
            // Fjern delay og skrive koden
            await Task.Delay(100);

            return null;
        }

        public void SkrivPizzaOrdreUdIKonsollen(PizzaOrdre pizzaOrdre)
        {
            Console.WriteLine(PizzaTekst(pizzaOrdre));
        }

        public void SkrivListeAfPizzaerIKonsollen(List<PizzaOrdre>? listeAfPizzaOrdre)
        {
            if (listeAfPizzaOrdre != null)
            {
                for (int index = 0; index < listeAfPizzaOrdre.Count; index++)
                {
                    var pizzaOrdre = listeAfPizzaOrdre[index];
                    var pizzaTekst = PizzaTekst(pizzaOrdre);
                    Console.WriteLine($"{index + 1}. {pizzaTekst}");
                }
            }

            if (listeAfPizzaOrdre?.Any() != true)
            {
                Console.WriteLine("Ingen pizzaer!");
            }
        }

        private string PizzaTekst(PizzaOrdre pizzaOrdre)
        {
            return $"'{pizzaOrdre.PizzaName}' pizza" +
                $" bestilt af {pizzaOrdre.BuyerName}" +
                $" kl {pizzaOrdre.OrderTimeStamp.ToString("HH:mm:ss")}" +
                $" (tid tilbage: {pizzaOrdre.TimeLeftForOrderSek} sek)" +
                $" id=[{pizzaOrdre.Id}]";
        }
    }
}
