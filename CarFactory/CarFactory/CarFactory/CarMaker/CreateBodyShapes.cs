using CarFactory.Models.BodyShapes;

namespace CarFactory.CarMaker
{
    public class CreateBodyShapes
    {
        public static IBody ChooseBody(int body)
        {
            switch (body)
            {
                case 1: return new Coupe();
                case 2: return new Hatchback();
                case 3: return new Sedan();
                default: return new Sedan();
            }
        }

        public static string InfoMessage()
        {
            return $"Кузов в наличии:\n" +
                $"(1)-Купе\n" +
                $"(2)-Хэчбек\n" +
                $"(3)-Седан";
        }
    }
}
