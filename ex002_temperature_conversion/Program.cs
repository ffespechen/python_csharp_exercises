int[] gradosCelsius = {-100, 0, 25, 30, 32, 50, 100, 180};
int[] gradosFahrenheit = {0, 1, 15, 32, 100};


Console.WriteLine("Conversor Fahrenheit -> Celsius");

foreach (int gradosC in gradosCelsius)
{
    Console.WriteLine("{0,5} °C -> {1,6} °F", gradosC, ConvertToFahrenheit(gradosC));
}

Console.WriteLine("Conversor Celsius -> Fahrenheit");

foreach (int gradosF in gradosFahrenheit)
{
    Console.WriteLine("{0,5} °C -> {1,6} °F", gradosF, ConvertToCelsius(gradosF));
}