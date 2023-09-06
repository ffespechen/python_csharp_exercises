// http://inventwithpython.com/pythongently/exercise7/

const byte MIN_ASCII = 32;
const byte MAX_ASCII = 126;

for(byte i=MIN_ASCII; i<=MAX_ASCII; i++) 
{
    Console.WriteLine($"Código Numérico  {i,3:D0} -> ASCII {(char)i}");
}