using CarFactory.Models.Colors;
using CarFactory.Models.Engines;

namespace CarFactory.CarMaker
{
    public class CreateEngine
    {
        public static IEngine ChooseEngine(int engine)
        {
            switch (engine)
            {
                case 1: return new Electric();
                case 2: return new V16();
                case 3: return new V8();
                default: return new V8();
            }
        }

        public static string InfoMessage()
        {
            return $"Двигатели в наличии:\n" +
                $"(1)-Электрический\n" +
                $"(2)-V-16\n" +
                $"(3)-V-8";
        }
    }
}
