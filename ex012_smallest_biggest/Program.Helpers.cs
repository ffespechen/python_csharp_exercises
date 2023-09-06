partial class Program
{
    public static int? GetSmallest(int[] enteros)
    {
        if (enteros.Length == 0) return null;

        int minimo = Int32.MaxValue;

        for(int i = 0; i < enteros.Length; i++)
        {
            if (enteros[i] < minimo)
            {
                minimo = enteros[i];
            }
        }

        return minimo;
    }


    public static int? GetBiggest(int[] enteros)
    {
        if (enteros.Length == 0) return null;

        int minimo = Int32.MinValue;

        for(int i = 0; i < enteros.Length; i++)
        {
            if (enteros[i] > minimo)
            {
                minimo = enteros[i];
            }
        }

        return minimo;
    }



}