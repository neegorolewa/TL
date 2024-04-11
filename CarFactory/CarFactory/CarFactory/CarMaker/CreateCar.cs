using CarFactory.Models.BodyShapes;
using CarFactory.Models.Brands;
using CarFactory.Models.Car;
using CarFactory.Models.CarModels;
using CarFactory.Models.Colors;
using CarFactory.Models.Engines;
using CarFactory.Models.SteeringPositions;
using CarFactory.Models.Transmissions;

namespace CarFactory.CarMaker
{
    public class CreateCar
    { 
        public static CarDetails ChooseCarDeatils()
        {
            var carDetails = new CarDetails();

            Console.WriteLine("Выберите марку автомобиля");
            Console.WriteLine(CreateBrand.InfoMessage());
            Console.Write(" > ");
            int brand = int.Parse(Console.ReadLine());
            carDetails.Brand = CreateBrand.ChooseBrand(brand);

            Console.WriteLine("Выберите модель автомобиля");
            Console.WriteLine(CreateModel.InfoMessage(brand));
            Console.Write(" > ");
            int model = int.Parse(Console.ReadLine());
            carDetails.Model = CreateModel.ChooseModel(brand, model);

            Console.WriteLine("Выберите тип кузова");
            Console.WriteLine(CreateBodyShapes.InfoMessage());
            Console.Write(" > ");
            int body = int.Parse(Console.ReadLine());
            carDetails.Body = CreateBodyShapes.ChooseBody(body);

            Console.WriteLine("Выберите цвет машины");
            Console.WriteLine(CreateColor.InfoMessage());
            Console.Write(" > ");
            int color = int.Parse(Console.ReadLine());
            carDetails.Color = CreateColor.ChooseColor(color);

            Console.WriteLine("Выберите тип двигателя");
            Console.WriteLine(CreateEngine.InfoMessage());
            Console.Write(" > ");
            int engine = int.Parse(Console.ReadLine());
            carDetails.Engine = CreateEngine.ChooseEngine(engine);

            Console.WriteLine("Выберите коробку передач");
            Console.WriteLine(CreateTransmission.InfoMessage());
            Console.Write(" > ");
            int trans = int.Parse(Console.ReadLine());
            carDetails.Transmission = CreateTransmission.ChooseTransmission(trans);

            Console.WriteLine("Выберите тип руля");
            Console.WriteLine(CreateSteeringPos.InfoMessage());
            Console.Write(" > ");
            int pos = int.Parse(Console.ReadLine());
            carDetails.SteeringPosition = CreateSteeringPos.ChoosePosition(pos);
            return carDetails;
        }

        public static Car BuildCar(IBrand brand, IModel model, IBody body, IColor color, IEngine engine, IPosition steeringPosition, ITransmission transmission )
        {
            return new Car(brand, model, body, color, engine, steeringPosition, transmission);
        }
    }
}
