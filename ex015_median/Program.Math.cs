partial class Program
{
    public static double? Median(int[] arreglo)
    {
        if (arreglo.Length == 0)
        {
            return null;
        }

        Array.Sort(arreglo);

        if (arreglo.Length % 2 == 1)
        {
            return (double) arreglo[arreglo.Length / 2];
        }
        else
        {
            return (double) (arreglo[arreglo.Length / 2] + arreglo[arreglo.Length / 2 - 1]) / 2;
        }
    }
}