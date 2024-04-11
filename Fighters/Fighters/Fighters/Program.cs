using Fighters.Models.Fighters;

namespace Fighters
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine($"Игра Fighters");
            Console.WriteLine($"Введите команду\n" +
                $"addFighters - Добавить бойцов\n" +
                $"play - Начать битву");

            List<IFighter> fighters = new List<IFighter>();

            bool isAdd = false;

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "addfighters")
                {
                    Console.WriteLine($"Введите количество игроков (не меньше 2): ");
                    int countFighters;

                    while (!int.TryParse(Console.ReadLine(), out countFighters) || countFighters < 2)
                    {
                        Console.WriteLine($"Введите корректное число бойцов!");
                    }

                    for (int i = 0; i < countFighters; i++)
                    {
                        Console.WriteLine($"Введите данные {i + 1}-го бойца:");
                        fighters.Add(CreateFighter.MakeFighter());
                        Console.WriteLine($"Боец {fighters[i].Name} успешно добавлен!");
                    }

                    isAdd = true;
                    continue;
                }
                
                if (command == "play" && isAdd)
                {
                    var master = new GameMaster();
                    var winner = master.PlayAndGetWinner(fighters);

                    isAdd = false;

                    Console.WriteLine($"Выигрывает {winner.Name}");

                    fighters.Clear();
                }
                else
                {
                    Console.WriteLine($"Создайте бойцов или введите другую команду!");
                }



            }
            
        }
    }
}