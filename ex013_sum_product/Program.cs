// http://inventwithpython.com/pythongently/exercise13/

Random rnd = new Random();
int[] serieNumeros = new int[20];

Console.WriteLine("---- Serie de números ----");
for(int i=0; i<20; i++)
{
    serieNumeros[i] = rnd.Next(-1000, 1000);
    Console.Write($"{serieNumeros[i]}  ");
}
Console.WriteLine();

Console.WriteLine($"Suma     : {CalculateSum(serieNumeros)}");
Console.WriteLine($"Producto : {CalculateProduct(serieNumeros)}");
Console.WriteLine($"Promedio : {CalculateMean(serieNumeros):N2}");