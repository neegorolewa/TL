using CarFactory.Models.Brands;

namespace CarFactory.CarMaker
{
    public class CreateBrand
    {
        public static IBrand ChooseBrand(int brand)
        {
            switch (brand)
            {
                case 1: return new BMW();
                case 2: return new Tesla();
                case 3: return new Volkswagen();
                default: return new Volkswagen();
            }
        }

        public static string InfoMessage()
        {
            return $"Автомобили в наличии:\n" +
                $"(1)-БМВ\n" +
                $"(2)-Тесла\n" +
                $"(3)-Фольксваген";
        }
    }
}
