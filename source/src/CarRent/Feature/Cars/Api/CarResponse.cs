namespace CarRent.Feature.Cars.Api
{
    public class CarResponse
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
    }

    // andere Variante wie oben - kürzere Schreibweise (syntactic sugar)
    //public record CarResponse2(Guid Id, string Name);
}
