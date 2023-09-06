Random rnd = new Random();
const int ITERACIONES = 12;

for (int i = 0; i < ITERACIONES; i++ )
{
    int numero = rnd.Next();
    Console.WriteLine($"IsEven() aplicada a {numero,20:N0} resulta {IsEven(numero)}");
}

Console.WriteLine();

for (int i = 0; i < ITERACIONES; i++ )
{
    int numero = rnd.Next();
    Console.WriteLine($"IsOdd() aplicada a {numero,20:N0} resulta {IsOdd(numero)}");
}