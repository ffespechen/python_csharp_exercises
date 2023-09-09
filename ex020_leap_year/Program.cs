// https://inventwithpython.com/pythongently/exercise20/

int[] years = {1999, 2000, 2001, 2004, 2100, 1900, 2400, 1976};

for (int i = 0; i < years.Length; i++)
{
    Console.WriteLine($"Año {years[i]} es Bisiesto? {IsLeapYear(years[i])}");
}