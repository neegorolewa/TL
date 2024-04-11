using CarFactory.Models.Brands;

namespace CarFactory.Models.CarModels
{
    internal class Polo : IModel
    {
        public IBrand Brand { get; } = new Volkswagen();
        public string Name { get; } = "Polo";
    }
}
