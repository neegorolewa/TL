using CarFactory.Models.Brands;

namespace CarFactory.Models.CarModels
{
    internal class X5M : IModel
    {
        public IBrand Brand { get; } = new BMW();
        public string Name { get; } = "X5M";
    }
}
