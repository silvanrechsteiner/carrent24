// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CarRent.Common.Domain;
using CarRent.Feature.Cars.Domain;
using FastEndpoints;

namespace CarRent.Feature.Cars.Api
{
    public class CreateCarEndpoint : Endpoint<CarRequest, CarResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICarRepository _carRepository;

        public CreateCarEndpoint(IUnitOfWork unitOfWork, ICarRepository carRepository)
        {
            _unitOfWork = unitOfWork;
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

            /*
             * macht man zur abstraktion, falls man noch weitere repositories hätte,
             * damit man auf einmal alle Änderungen speichern können
             */
            _unitOfWork.CommitChanges();

            await SendCreatedAtAsync<GetCarByIdEndpoint>(null, new CarResponse
            {
                Id = car.Id,
                Name = req.Name
            });
        }
    }
}
