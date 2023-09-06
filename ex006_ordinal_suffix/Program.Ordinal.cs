partial class Program
{
    public static void OrdinalSuffixEs(int numero)
    {
        string strNumero = numero.ToString();
        char numeroFinal = strNumero[strNumero.Length-1] ;

        switch (numeroFinal)
        {
            case '1':
                Console.WriteLine($"{numero}ero");
                break;
            case '2':
                Console.WriteLine($"{numero}do");
                break;
            case '3':
                Console.WriteLine($"{numero}ro");
                break;
            case '7':
            case '0':
                Console.WriteLine($"{numero}mo");
                break; 
            case '8':
                Console.WriteLine($"{numero}vo");
                break;
            case '9':
                Console.WriteLine($"{numero}no");
                break;           
            default:
                Console.WriteLine($"{numero}to");
                break;

        };
    }
}