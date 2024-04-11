using CarFactory.Models.BodyShapes;
using CarFactory.Models.Brands;
using CarFactory.Models.CarModels;
using CarFactory.Models.Colors;
using CarFactory.Models.Engines;
using CarFactory.Models.SteeringPositions;
using CarFactory.Models.Transmissions;

namespace CarFactory.Models.Car
{
    public class Car
    {
        public IBrand Brand { get; private set; }
        public IModel Model { get; private set; }
        public IBody Body { get; private set; }
        public IColor Color { get; private set; }
        public IEngine Engine { get; private set; }
        public IPosition SteeringPosition { get; private set; }
        public ITransmission Transmission { get; private set; }
        public int Speed => Engine.MaxSpeed;
        public int Gear => Transmission.CountGear;

        public Car (IBrand brand, IModel model, IBody body, IColor color, IEngine engine, IPosition steeringPosition, ITransmission transmission)
        {
            Brand = brand;
            Model = model;
            Body = body;
            Color = color;
            Engine = engine;
            SteeringPosition = steeringPosition;
            Transmission = transmission;
        }

        public string Print()
        {
            return $"Название: {Brand.Name} {Model.Name}\n" +
                $"Тип кузова: {Body.Name}\n" +
                $"Цвет: {Color.Name}\n" +
                $"Двигатель: {Engine.Name}\n" +
                $"Коробка передач: {Transmission.Name}\n" +
                $"Тип руля: {SteeringPosition.Type}\n" +
                $"Максимальная скорость: {Speed}\n" +
                $"Количество передач: {Gear}";
        }
    }
}
