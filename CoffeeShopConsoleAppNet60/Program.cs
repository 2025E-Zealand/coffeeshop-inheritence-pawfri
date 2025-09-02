
using CoffeeShopConsoleAppNet60;

Coffee coffee = new BlackCoffee(0);
Coffee coffee2 = new Cortado(0);
Coffee coffee3 = new Latte(5);

List<Coffee> coffeeList = new List<Coffee>();

coffeeList.Add(coffee);
coffeeList.Add(coffee2);
coffeeList.Add(coffee3);

foreach (var element in coffeeList)
{
    Console.WriteLine($"Price: {element.Price()} | Strength: {element.Strength()}");
}