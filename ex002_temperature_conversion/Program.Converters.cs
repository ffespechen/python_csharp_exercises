partial class Program
{

    public static double ConvertToFahrenheit(int degreeCelsius)
    {
        return 1.8 * degreeCelsius + 32;
    }

    public static double ConvertToCelsius(int degreesFahrenheit)
    {
        return (degreesFahrenheit - 32) / 1.8;
    }
}