// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mi primer programa en C# y .NET 8");

Console.WriteLine("Escribe tu nombre: ");
string? nombre = Console.ReadLine();

Console.WriteLine("Escribe tu apellido: "); 
string? apellido = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Beep();

Console.WriteLine(nombre + " " + apellido);
Console.ReadLine();