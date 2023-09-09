partial class Program
{
    public static int RollDice(int cantidad)
    {
        Random rnd = new Random();
        int suma = 0;

        using (StreamWriter sw = File.AppendText( Path.Combine(Environment.CurrentDirectory, "resultados.csv")))
        {
            for (int i = 0; i < cantidad; i++)
                {
                    // Versión original
                    int tirada = rnd.Next(1, 7);

                    sw.Write(tirada);
                    sw.Write(";");
                    // Console.WriteLine($"Dado Nro {i+1} -> {tirada}");
                    suma += tirada;
                }
                sw.WriteLine(suma);
        }
    
        return suma;
    }
}