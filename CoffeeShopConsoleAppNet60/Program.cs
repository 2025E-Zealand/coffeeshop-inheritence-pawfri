using CoffeeShopConsoleAppNet60;

Coffee blackCoffee = new BlackCoffee(4, "BlackCoffee");
Coffee cortado = new Cortado(4, "Cortado");
Coffee latte = new Latte(4, "Latte");

List<Coffee> coffeeList = new List<Coffee>();

coffeeList.Add(blackCoffee);
coffeeList.Add(cortado);
coffeeList.Add(latte);

Console.WriteLine();
Console.WriteLine("Coffee in the list:");
foreach (var element in coffeeList)
{
    Console.WriteLine($"Coffee: {element.Name} | Price: {element.Price()} | Strength: {element.Strength()}");
}

List<IMilk> withMilkList = new List<IMilk>();

withMilkList.Add(blackCoffee);
withMilkList.Add(cortado);
withMilkList.Add(latte);

Console.WriteLine();
Console.WriteLine("Coffee only with Milk:");
foreach (var element in withMilkList)
{
    if (element.mlMilk() > 0)
    {
        Console.WriteLine($"Coffee: {element.GetType().Name} | Milk: {element.mlMilk()} Ml.");
    }
}