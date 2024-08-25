// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.Api
{
    public class GetCarByIdEndpoint : EndpointWithoutRequest<CarResponse>
    {
        private readonly ICarRepository _carRepository;

        public GetCarByIdEndpoint(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public override void Configure()
        {
            Get("/cars/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var carId = Route<Guid>("id");
            var car = _carRepository.FindById(carId);

            await SendAsync(new CarResponse
            {
                Id = carId,
                Name = car.Name
            }, StatusCodes.Status200OK, ct);
        }
    }
}
