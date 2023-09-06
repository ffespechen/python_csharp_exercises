partial class Program
{
    public static string GetChessSquareColor(byte row, byte column)
    {
        if ((row > 7) || (column > 7))
        {
            throw new IndexOutOfRangeException(message: "Índices fuera de rango");
        }

        if (((row % 2 == 0) && (column % 2 != 0)) || ((row % 2 != 0) && (column % 2 == 0)))
        {
            return "NEGRO";
        }
        else
        {
            return "BLANCO";
        }

    }
}