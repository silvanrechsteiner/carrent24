using CarRent.Common.Domain;

namespace CarRent.Feature.Cars.Domain
{
    public class Car : Entity, IAggregateRoot
    {
        public string Name { get; internal set; }
    }
}
