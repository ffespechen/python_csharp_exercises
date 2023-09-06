// http://inventwithpython.com/pythongently/exercise9/

Console.WriteLine(GetChessSquareColor(1, 1));
Console.WriteLine(GetChessSquareColor(2, 1));
Console.WriteLine(GetChessSquareColor(1, 2));
Console.WriteLine(GetChessSquareColor(7, 7));
// Genera un Error de Compilación (byte no acepta números negativos)
// Console.WriteLine(GetChessSquareColor(-1, 9));

// Genera una Excepción
Console.WriteLine(GetChessSquareColor(1, 9));
