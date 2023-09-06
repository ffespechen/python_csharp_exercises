// http://inventwithpython.com/pythongently/exercise11/

uint[] segundos = { 30, 60, 90, 3600, 3601, 3661, 90042, 0};


foreach (uint secs in segundos)
{
    Console.WriteLine($"Segundos {secs, 6:D} equivale a >> {GetHoursMinutesSeconds(secs)}");
}
