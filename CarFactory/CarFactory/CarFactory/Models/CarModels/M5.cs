using CarFactory.Models.Brands;

namespace CarFactory.Models.CarModels
{
    public class M5 : IModel
    {
        public IBrand Brand { get; } = new BMW();
        public string Name { get; } = "M5";
    }
}
