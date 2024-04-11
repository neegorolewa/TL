using CarFactory.Models.Brands;
using CarFactory.Models.Car;
using CarFactory.Models.CarModels;
using CarFactory.Models.Colors;

namespace CarFactory.CarMaker
{


    public class CreateModel
    {


        public static IModel ChooseModel(int brand, int model)
        {
            switch (brand)
            {
                case 1:
                    switch (model)
                    {
                        case 1: return new M5();
                        case 2: return new X5M();
                        default: return new M5();
                    }
                case 2:
                    switch (model)
                    {
                        case 1: return new ModelS();
                        case 2: return new Cybertruck();
                        default: return new ModelS();
                    }
                case 3:
                    switch (model)
                    {
                        case 1: return new Polo();
                        case 2: return new Jetta();
                        default: return new Polo();
                    }
                default: return new Polo();
            }
        }

        public static List<string> GetModelsOfBrand(int brand)
        {
            switch (brand)
            {
                case 1: return new List<string> { "M5", "X5M" };
                case 2: return new List<string> { "ModelS", "Cybertruck" };
                case 3: return new List<string> { "Polo", "Jetta" };
                default: return new List<string> { "Polo", "Jetta" };
            }
        }

        public static string InfoMessage(int brand)
        {
            List<string> listModel = GetModelsOfBrand(brand);
            string message = "Модели в наличии\n";
            for (int i = 0; i < listModel.Count; i++)
            {
                if (i < 1)
                {
                    message += $"({i + 1})-{listModel[i]}\n";
                }
                else
                {
                    message += $"({i + 1})-{listModel[i]}";
                }
            }
            return message;
        }
    }
}
