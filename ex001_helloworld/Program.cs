Console.WriteLine("Hello, world!");
Console.WriteLine("What is your name?");

string? nombre = Console.ReadLine();

if (string.IsNullOrWhiteSpace(nombre))
{
    nombre = "DESCONOCIDO MISTERIOSO";
}

Console.WriteLine($"Hello, {nombre}");