// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Commands:");
Console.WriteLine("  quit ---> exits the application");

while (true)
{
	string? command = Console.ReadLine();
	if (command.Equals("quit"))
		{ break; }

}
