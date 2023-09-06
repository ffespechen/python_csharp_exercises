// Fórmulas propuestas para el ejercicio
// area = L × W
// perimeter = L + W + L + W
// volume = L × W × H
// surface area = (L × W × 2) + (L × H × 2) + (W × H × 2)

partial class Program
{
    public static int Area(int lenght, int width)
    {
        return lenght * width;
    }

    public static int Perimeter(int lenght, int width)
    {
        return (2 * lenght) + (2 * width);
    }

    public static int Volume(int lenght, int width, int height)
    {
        return lenght * width * height;
    }

    public static int SurfaceArea(int lenght, int width, int height)
    {
        return (lenght * width * 2) + (lenght * height * 2) + (width * height * 2);
    }
}