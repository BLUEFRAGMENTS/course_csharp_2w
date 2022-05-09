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

            // STEP 1
            var response = await _httpClient.PostAsync(
                $"{baseUrl}/pizzaria/order",
                stringContent);

            // STEP 2
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Bestilling lavet!");

                // STEP 3
                var body = await response.Content.ReadAsStringAsync();

                // STEP 4
                var orderedPizza = JsonConvert.DeserializeObject<PizzaOrdre>(body);

                // STEP 5
                return orderedPizza;
            }
            else
            {
                Console.WriteLine("Bestilling fejlet!");
            }

            return null;
        }

        public async Task<List<PizzaOrdre>?> HentAlleOrdreAsync()
        {
            // STEP 6
            Console.WriteLine("Henter alle bestillinger...");

            // STEP 7
            var response = await _httpClient.GetAsync($"{baseUrl}/pizzaria/orders");

            // STEP 8
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Alle bestillinger hentet!");
                Console.WriteLine();

                // STEP 9
                var body = await response.Content.ReadAsStringAsync();

                // STEP 10
                var pizzas = JsonConvert.DeserializeObject<List<PizzaOrdre>>(body) ?? new List<PizzaOrdre>();

                // STEP 11
                return pizzas;
            }
            else
            {
                Console.WriteLine("Kunne ikke hente pizza ordre!");
                Console.WriteLine();
            }

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

        // EKSTRA

        public async Task<bool> SletEnOrdreAsync(string? guidIdSomString)
        {
            var response = await _httpClient.DeleteAsync($"{baseUrl}/pizzaria/order?id={guidIdSomString}");
            return response.IsSuccessStatusCode;
        }
    }
}
