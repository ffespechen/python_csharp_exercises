// http://inventwithpython.com/pythongently/exercise12/


// Poblar la serie con números pseudoaleatorios
Random rnd = new Random();
int[] serieNumeros = new int[20];

Console.WriteLine("---- Serie de números ----");
for(int i=0; i<20; i++)
{
    serieNumeros[i] = rnd.Next(-1000, 1000);
    Console.Write($"{serieNumeros[i]}  ");
}
Console.WriteLine();


Console.WriteLine("---- Prueba con serie de números ----");
Console.WriteLine($"Menor número de la serie >> {GetSmallest(serieNumeros)}");
Console.WriteLine($"Mayor número de la serie >> {GetBiggest(serieNumeros)}");

Console.WriteLine("---- Prueba con serie vacía de números ----");
int[] serieNumeros2 = {};
Console.WriteLine($"Menor número de la serie >> {GetSmallest(serieNumeros2)}");
Console.WriteLine($"Mayor número de la serie >> {GetBiggest(serieNumeros2)}");

