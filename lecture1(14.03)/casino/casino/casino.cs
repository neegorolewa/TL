const double MULTIPLICATOR = 0.1;

int balance = 10000;

while (true)
{
    Console.Clear();
    Console.WriteLine($"Ваш баланс: {balance}");

    Console.Write("Введите ставку: ");
    var betStr = Console.ReadLine();
    int bet = int.Parse(betStr);

    Random random = new Random();
    int randomNumber = random.Next(1, 21);

    if (bet < 0 || bet > 10000)
    {
        Console.WriteLine("Ввели неверное значение ставки!");
        return 0;
    }

    if (randomNumber >= 18 & randomNumber <= 20)
    {
        int profit = (int)(bet * (1 + (MULTIPLICATOR * (randomNumber % 17))));
        balance += profit;

        Console.WriteLine($"Вы выиграли! Ваш выигрыш: {profit}");
        Console.Write("Продолжить играть? (y/n): ");
        var play = Console.ReadLine();

        if (play == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine($"Ваш баланс: {balance}, до скорых встреч!");
            return 0;
        }
    }
    else
    {
        balance -= bet;

        Console.Write($"Вы проиграли...\nХотите продолжить?(y/n)");
        var play = Console.ReadLine();

        if (play == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine($"Ваш баланс: {balance}, до скорых встреч!");
            return 0;
        }
    }
}