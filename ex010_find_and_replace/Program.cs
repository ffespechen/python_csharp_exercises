Console.Write("Texto de trabajo >> ");
string? texto = Console.ReadLine();
Console.Write("Texto a buscar >> ");
string? textoViejo = Console.ReadLine();
Console.Write("Texto de reemplazo >> ");
string? textoNuevo = Console.ReadLine();

if(String.IsNullOrWhiteSpace(texto))
{
    texto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
}
if (String.IsNullOrWhiteSpace(textoViejo))
{
    textoViejo = "EF";
} 
if(String.IsNullOrWhiteSpace(textoNuevo))
{
    textoNuevo = "xxx";
}

// Encontrar y reemplazar
Console.WriteLine(FindAndReplace(texto, textoViejo, textoNuevo));
