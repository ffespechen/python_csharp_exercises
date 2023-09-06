Random rnd = new Random();
int largo = rnd.Next(1, 20);
int ancho = rnd.Next(1, 20);
int altura = rnd.Next(1,30);

Console.WriteLine("---- Parámetros ----");
Console.WriteLine($"Largo:  {largo, 5:N0}");
Console.WriteLine($"Ancho:  {ancho, 5:N0}");
Console.WriteLine($"Altura: {altura, 5:N0}");

Console.WriteLine("---- Resultados ----");
Console.WriteLine($"Área:       {Area(largo, ancho), 5:N0}");
Console.WriteLine($"Perímetro:  {Perimeter(largo, ancho), 5:N0}");
Console.WriteLine($"Volumen:    {Volume(largo, ancho, altura), 5:N0}");
Console.WriteLine($"Superfice:  {SurfaceArea(largo, ancho, altura), 5:N0}");