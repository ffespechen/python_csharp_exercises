// Fórmulas propuestas para el ejercicio
// area = L × W
// perimeter = L + W + L + W
// volume = L × W × H
// surface area = (L × W × 2) + (L × H × 2) + (W × H × 2)

partial class Program
{
    public static uint Area(uint lenght, uint width)
    {
        return lenght * width;
    }

    public static uint Perimeter(uint lenght, uint width)
    {
        return (2 * lenght) + (2 * width);
    }

    public static uint Volume(uint lenght, uint width, uint height)
    {
        return lenght * width * height;
    }

    public static uint SurfaceArea(uint lenght, uint width, uint height)
    {
        return (lenght * width * 2) + (lenght * height * 2) + (width * height * 2);
    }
}