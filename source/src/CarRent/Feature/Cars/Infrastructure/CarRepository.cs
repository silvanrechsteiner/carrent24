﻿using CarRent.Feature.Cars.Domain;
using CarRent.Persistance;

namespace CarRent.Feature.Cars.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        private readonly CarRentDbContext _context;

        public CarRepository(CarRentDbContext context)
        {
            _context = context;
        }

        public void Add(Car entity)
        {
            _context.Set<Car>().Add(entity);
        }

        public Car FindById(Guid id)
        {
            return _context.Set<Car>().Find(id)!;
        }

        public IReadOnlyList<Car> GetCars()
        {
            return _context.Set<Car>().ToList();
        }

        public void Remove(Car entity)
        {
            _context.Set<Car>().Remove(entity);
        }
    }
}
