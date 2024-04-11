using CarFactory.Models.Colors;

namespace CarFactory.CarMaker
{
    public class CreateColor
    {
        public static IColor ChooseColor(int color)
        {
            switch (color)
            {
                case 1: return new Red();
                case 2: return new Green();
                case 3: return new Blue();
                default: return new Red();
            }
        }

        public static string InfoMessage()
        {
            return $"Цвета в наличии:\n" +
                $"(1)-Красный\n" +
                $"(2)-Зеленый\n" +
                $"(3)-Синий";
        }
    }
}
