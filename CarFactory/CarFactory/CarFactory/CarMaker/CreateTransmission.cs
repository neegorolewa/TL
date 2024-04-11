using CarFactory.Models.Transmissions;

namespace CarFactory.CarMaker
{
    public class CreateTransmission
    {
        public static ITransmission ChooseTransmission(int trans)
        {
            switch (trans)
            {
                case 1: return new Automat();
                case 2: return new Mechanical();;
                default: return new Mechanical();
            }
        }

        public static string InfoMessage()
        {
            return $"Коробки передач в наличии:\n" +
                $"(1)-Автомат\n" +
                $"(2)-Механика";
        }
    }
}
