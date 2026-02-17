namespace Advanced.Tasks.LanguagePatterns
{
    public record Address (string Street, string City, string Region, string PostIndex, string Country)
    {
        public void Deconstruct(out string street, out string city, out string region, out string postindex, out string country)
        {
            street = Street;
            city = City;
            region = Region;
            postindex = PostIndex;
            country = Country;
        }
    }
}
