// https://inventwithpython.com/pythongently/exercise17/

Console.WriteLine("-- Tirada de Dados -- ");

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine($"Tirando {i} dado(s)");
    Console.WriteLine($"{RollDice(i)}");
    Console.WriteLine("---------------------");
}
