﻿using CarRent.Feature.Cars.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRent.Feature.Cars.Infrastructure
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(256);

            // add demo data
            builder.HasData(
                new Car() { Name = "Car 1"},
                new Car() { Name = "Car 2"},
                new Car() { Name = "Car 3"}
            );
        }
    }
}
