using CarFactory.Models.SteeringPositions;

namespace CarFactory.CarMaker
{
    public class CreateSteeringPos
    {
        public static IPosition ChoosePosition(int pos)
        {
            switch (pos)
            {
                case 1: return new LeftPos();
                case 2: return new RightPos();
                default: return new LeftPos();
            }
        }

        public static string InfoMessage()
        {
            return $"Позиции руля:\n" +
                $"(1)-Левый\n" +
                $"(2)-Правый";
        }
    }
}
