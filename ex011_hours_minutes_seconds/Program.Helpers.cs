partial class Program
{
    public static string GetHoursMinutesSeconds(uint totalSeconds)
    {
        if (totalSeconds == 0) return $"0s";

        uint[] resultado = {0, 0, 0};

        resultado[0] = totalSeconds / (60 * 60);
        uint resto = totalSeconds % (60 * 60);
        resultado[1] = resto / 60;
        resultado[2] = resto % 60;

        string strResultado = string.Join("", 
            resultado[0] == 0 ? "" : $"{resultado[0]}h ",
            resultado[1] == 0 ? "" : $"{resultado[1]}m ",
            resultado[2] == 0 ? "" : $"{resultado[2]}s ");

        return strResultado;
    }
}