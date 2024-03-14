Console.Write("Введите название товара: ");
var productName = Console.ReadLine();

Console.Write("Введите количество товара: ");
var productQuantityInput = Console.ReadLine();
int productQuantity = int.Parse(productQuantityInput);

Console.Write("Введите свое имя: ");
var personName = Console.ReadLine();

Console.Write("Введите адрес доставки: ");
var address = Console.ReadLine();

DateTime date = DateTime.Now;
date.AddDays(3);
string futureDate = date.ToString("d");

Console.Clear();

Console.WriteLine($"Здравствуйте, {personName}, вы заказали {productQuantity} {productName} на адрес {address}, все верно? (y/n)");
var answer = Console.ReadLine();

Console.Clear();

if (answer == "y")
{
    Console.WriteLine($"{personName}!\nВаш заказ {productName} в количестве {productQuantity} оформлен!\n" +
        $"Ожидайте доставку по адресу {address} к {futureDate}");
}
else
{
    Console.WriteLine("Перезаполните форму. Всего хорошего!");
}