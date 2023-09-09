partial class Program
{
    public static int RollDice(int cantidad)
    {
        Random rnd = new Random();
        int suma = 0;

        for (int i = 0; i < cantidad; i++)
        {
            int tirada = rnd.Next(1, 7);
            Console.WriteLine($"Dado Nro {i+1} -> {tirada}");
            suma += tirada;
        }

        return suma;
    }
}