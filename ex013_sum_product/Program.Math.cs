partial class Program
{
    public static int CalculateSum(int[] numeros)
    {
        if (numeros.Length == 0) throw new Exception(message: "Array vacío");
        
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        return suma;
    }

    public static int CalculateProduct(int[] numeros)
    {
        if (numeros.Length == 0) throw new Exception(message: "Array vacío");

        int producto = 1;
        for (int i = 0; i < numeros.Length; i++)
        {
            producto *= numeros[i];
        }

        return producto;
    }

    public static double CalculateMean(int[] numeros)
    {
        if (numeros.Length == 0) throw new Exception(message: "Array vacío");

        return (double) CalculateSum(numeros) / numeros.Length;
    }    

}