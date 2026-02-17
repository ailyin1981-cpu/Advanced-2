using System.Diagnostics.Metrics;

namespace Advanced.Tasks.LanguagePatterns
{
    public class DemonstrateDeconstruction
    {
        public async Task DeconstructAsync() 
        {
            await Task.Yield();

            var address = new Address("ул.Гагарина, д.1", "Чебоксары", "Чувашия", "428000", "Россия");

            var (street, city, region, postindex, country) = address;
            Console.WriteLine($"Индекс: {postindex}");
            Console.WriteLine($"Страна: {country}");
            Console.WriteLine($"Регион: {region}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Улица: {street}");
        }    
    }
}
