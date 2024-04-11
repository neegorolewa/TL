using CarFactory.Models.Brands;

namespace CarFactory.Models.CarModels
{
    internal class Cybertruck : IModel
    {
        public IBrand Brand { get; } = new Tesla();
        public string Name { get; } = "Cybertruck";
    }
}
