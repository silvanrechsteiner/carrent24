// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.Api
{
    public class CreateCarEndpoint : Endpoint<CarRequest, CarResponse>
    {
        private readonly ICarRepository _carRepository;

        public CreateCarEndpoint(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public override void Configure()
        {
            Post("/cars");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CarRequest req, CancellationToken ct)
        {
            var car = new Car { Name = req.Name };

            _carRepository.Add(car);

            await SendCreatedAtAsync<GetCarByIdEndpoint>("/cars/{id}", new CarResponse
            {
                Id = car.Id,
                Name = req.Name
            });
        }
    }
}
