using CarFactory.Models.Brands;

namespace CarFactory.Models.CarModels
{
    public interface IModel
    {
        IBrand Brand { get; }
        public string Name { get; }
    }
}
