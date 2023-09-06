// http://inventwithpython.com/pythongently/exercise4/

// https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-7.0#system-random-next
// Next() Returns a non-negative random integer.
Random rnd = new Random();
uint largo = (uint)rnd.Next(1, 20);
uint ancho = (uint) rnd.Next(1, 20);
uint altura = (uint) rnd.Next(1,30);

Console.WriteLine("---- Parámetros ----");
Console.WriteLine($"Largo:  {largo, 5:N0}");
Console.WriteLine($"Ancho:  {ancho, 5:N0}");
Console.WriteLine($"Altura: {altura, 5:N0}");

Console.WriteLine("---- Resultados ----");
Console.WriteLine($"Área:       {Area(largo, ancho), 5:N0}");
Console.WriteLine($"Perímetro:  {Perimeter(largo, ancho), 5:N0}");
Console.WriteLine($"Volumen:    {Volume(largo, ancho, altura), 5:N0}");
Console.WriteLine($"Superfice:  {SurfaceArea(largo, ancho, altura), 5:N0}");