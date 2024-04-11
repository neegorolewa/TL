using CarFactory.Models.Brands;

namespace CarFactory.Models.CarModels
{
    internal class ModelS : IModel
    {
        public IBrand Brand { get; } = new Tesla();
        public string Name { get; } = "Model S";
    }
}
