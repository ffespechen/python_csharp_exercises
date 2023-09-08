partial class Program
{
    public static int? Mode(int[] arreglo)
    {
        if (arreglo.Length == 0)
        {
            return null;
        }
        
        Dictionary<int, int> moda = new Dictionary<int, int>();

        for (int i = 0; i < arreglo.Length; i++ )
        {
            try
            {
                moda.Add(arreglo[i], 1);
            }
            catch (ArgumentException)
            {
                moda[arreglo[i]] += 1;
            }
        }

        int maximo_value = Int32.MinValue;
        int maximo_key = 0;

        foreach (KeyValuePair<int, int> kvp in moda)
        {
            if (kvp.Value > maximo_value)
            {
                maximo_value = kvp.Value;
                maximo_key = kvp.Key;
            }
        }

        return maximo_key;
    }
}