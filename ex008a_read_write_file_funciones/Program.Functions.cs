partial class Program
{
    public static void WriteToFile(string ruta, string texto)
    {
        using (StreamWriter sw = File.CreateText(ruta))
        {
            sw.WriteLine(texto);
        }
    }

    public static void AppendToFile(string ruta, string texto)
    {
        using (StreamWriter sw = File.AppendText(ruta))
        {
            sw.WriteLine(texto);
        }
    }

    public static void ReadFromFile(string ruta)
    {
        foreach( string linea in File.ReadLines(ruta))
        {
            Console.WriteLine(linea);
        }
    }
}