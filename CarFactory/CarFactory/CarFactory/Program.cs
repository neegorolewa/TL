using CarFactory.CarMaker;
using CarFactory.Models.Car;

namespace CarFactory
{ 
    public class Program
    {
        const string SEPARATOR = "------------------------------------------------------------------";
        static void Main()
        {
            Console.WriteLine("CarFactory");

            while (true)
            {
                CarDetails details = CreateCar.ChooseCarDeatils();

                if (details != null)
                {
                    Car car = CreateCar.BuildCar(
                        details.Brand,
                        details.Model,
                        details.Body,
                        details.Color,
                        details.Engine,
                        details.SteeringPosition,
                        details.Transmission
                        );

                    Console.WriteLine();
                    Console.WriteLine("Машина создана!");
                    Console.WriteLine(SEPARATOR);
                    Console.WriteLine(car.Print());
                    Console.WriteLine(SEPARATOR);
                }
                else
                {
                    Console.WriteLine("Возникла ошибка при создании машины");
                }
            }
        }
    }
}
