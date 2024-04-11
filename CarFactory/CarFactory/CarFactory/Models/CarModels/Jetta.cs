using CarFactory.Models.Brands;

namespace CarFactory.Models.CarModels
{
    internal class Jetta : IModel
    {
        public IBrand Brand { get; } = new Volkswagen();
        public string Name { get; } = "Jetta";
    }
}
