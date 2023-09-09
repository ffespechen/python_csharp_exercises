partial class Program
{
    public static string GeneratePassword(int longitud)
    {
        if (longitud < 12)
        {
            longitud = 12;
        } 

        List<char> password = new();
        Random rnd = new();

        for (int i = 0; i < longitud; i++)
        {
            password.Add((char) rnd.Next(32, 127));
        }

        return string.Join("", password);
    }
}