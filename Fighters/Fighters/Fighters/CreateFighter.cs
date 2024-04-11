using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters
{
    public static class CreateFighter
    {
        public static Fighter MakeFighter()
        {
            Console.WriteLine("Введите имя бойца:");
            string? name = Console.ReadLine();

            IRace selectedRace = SelectRace();
            IClass selectedClass = SelectClass();
            IArmor selectedArmor = SelectArmor();
            IWeapon selectedWeapon = SelectWeapon();

            return new Fighter(name, selectedRace, selectedWeapon, selectedArmor, selectedClass);
        }

        private static IArmor SelectArmor()
        {
            Console.WriteLine($"Выберите броню из списка ниже:\n" +
                $"1 - Без брони\n" +
                $"2 - Нагрудник\n" +
                $"3 - Шлем\n" +
                $"4 - Молитвенник");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value) && value >= 1 && value <= 4)
            {
                switch (value)
                {
                    case 1: return new NoArmor();
                    case 2: return new Bib();
                    case 3: return new Helmet();
                    case 4: return new Prayer();
                }
            }

            return new NoArmor();
        }

        private static IClass SelectClass()
        {
            Console.WriteLine($"Выберите класс бойца из списка ниже:\n" +
                $"1 - Лучник\n" +
                $"2 - Рыцарь\n" +
                $"3 - Воин");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value) && value >= 1 && value <= 3)
            {
                switch (value)
                {
                    case 1: return new Archer();
                    case 2: return new Knight();
                    case 3: return new Warrior();
                }
            }

            return new Warrior();
        }

        private static IRace SelectRace()
        {
            Console.WriteLine($"Выберите расу из списка ниже:\n" +
                $"1 - Человек\n" +
                $"2 - Грек\n" +
                $"3 - Монгол\n" +
                $"4 - Татарин");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value) && value >= 1 && value <= 4)
            {
                switch (value)
                {
                    case 1: return new Human();
                    case 2: return new Greek();
                    case 3: return new Mongol();
                    case 4: return new Tatar();
                }
            }

            return new Human();
        }

        private static IWeapon SelectWeapon()
        {
            Console.WriteLine($"Выберите оружие из списка ниже:\n" +
                $"1 - Без оружия\n" +
                $"2 - Пистолет\n" +
                $"3 - Меч\n" +
                $"4 - Камень\n" +
                $"5 - Черная магия");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value) && value >= 1 && value <= 5)
            {
                switch (value)
                {
                    case 1: return new NoWeapon();
                    case 2: return new Gun();
                    case 3: return new Sword();
                    case 4: return new Stone();
                    case 5: return new Magic();
                }
            }

            return new NoWeapon();
        }
    }
}
