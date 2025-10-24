// See https://aka.ms/new-console-template for more information
using GitHubKurs.Data;

Console.WriteLine("Hello, World!");
Console.WriteLine("Commands:");
Console.WriteLine("  quit ---> exits the application");
Console.WriteLine("   shops --->show coffee shops   ");

while (true)
{
	string? command = Console.ReadLine();
	if (command.Equals("quit", StringComparison.OrdinalIgnoreCase))
	{
		break;
	}
	else if (command.Equals("shops", StringComparison.OrdinalIgnoreCase))
	{
		var dataProvider = new CoffeeShopDataProvider();
		var coffeeShops = dataProvider.LoadShops();
		foreach (GitHubKurs.Model.CoffeeShop shop in coffeeShops)
		{
			Console.WriteLine(shop);
		}
	}
	else
	{
		Console.WriteLine($"invalid command: {command}");
	}
}