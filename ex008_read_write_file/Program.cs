Console.Write("Nombre del archivo de destino >> ");
string? archivo = Console.ReadLine();
Console.Write("Texto a guardar en el archivo >> ");
string? texto = Console.ReadLine();

if (string.IsNullOrWhiteSpace(archivo))
{
    archivo = "archivo.txt";
}

if (string.IsNullOrWhiteSpace(texto))
{
    texto = "Lorem ipsum...";
}

string ruta = Path.Combine(Environment.CurrentDirectory, archivo);

// Versión sin funciones
Console.WriteLine("Guardando texto...");
using (StreamWriter sw = File.CreateText(ruta))
{
    sw.WriteLine(texto);
}

Console.Write("Ingrese texto a agregar >> ");
texto = Console.ReadLine() ?? "Texto a agregar";
Console.WriteLine("--- Agregando texto ---");
using (StreamWriter sw = File.AppendText(ruta))
{
    sw.WriteLine(texto);
}

Console.WriteLine("--- Mostrando texto guardado ---");
foreach (string linea in File.ReadLines(ruta))
{
    Console.WriteLine(linea);
}
