// https://inventwithpython.com/pythongently/exercise15/

int[] arreglo1 = {};
int[] arreglo2 = {1, 2, 3};
int[] arreglo3 = {3, 7, 10, 4, 1, 9, 6, 5, 2, 8};
int[] arreglo4 = {3, 7, 10, 4, 1, 9, 6, 2, 8};

Console.WriteLine("--- Cálculo de la Mediana en un array ---");
Console.WriteLine($"Mediana de {{}} -> {Median(arreglo1)}");
Console.WriteLine($"Mediana de {{1, 2, 3}} -> {Median(arreglo2)}");
Console.WriteLine($"Mediana de {{3, 7, 10, 4, 1, 9, 6, 5, 2, 8}} -> {Median(arreglo3)}");
Console.WriteLine($"Mediana de {{3, 7, 10, 4, 1, 9, 6, 5, 2, 8}} -> {Median(arreglo4)}");
