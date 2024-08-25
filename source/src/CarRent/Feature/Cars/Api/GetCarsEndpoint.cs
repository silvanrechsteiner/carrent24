using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.Api
{
    public class GetCarsEndpoint : EndpointWithoutRequest<IEnumerable<CarResponse>>
    {
        private readonly ICarRepository _carRepository;

        public GetCarsEndpoint(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public override void Configure()
        {
            Get("/cars");
            AllowAnonymous(); // NEVER in PROD!!
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var cars = _carRepository.GetCars();

            var response = cars.Select(car => new CarResponse{
                Id = car.Id,
                Name = car.Name
            });

            await SendOkAsync(response, ct);
        }
    }
}
