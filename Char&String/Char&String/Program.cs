Console.WriteLine("Ingrese una cadena de texto en minusculas"); //De minusculas a mayusculas
string cadena = Console.ReadLine();
string Mayus = cadena.ToUpper();
Console.WriteLine("Cadena de texto en mayusculas: " + Mayus);

Console.WriteLine("Ingrese una cadena de texto en mayusculas"); //De mayusculas a minusculas
string cadena2 = Console.ReadLine();
string Minus = cadena2.ToLower();
Console.WriteLine("Cadena de texto en minusculas: " + Minus);

Console.WriteLine("Ingrese una cadena de texto"); //imprimir al reves
string texto = Console.ReadLine();
for (int i = texto.Length - 1; i >= 0; i--)
{
    Console.Write(texto[i]);
}


Console.WriteLine("Ingrese una cadena de texto"); //buscar una palabra
string tx1 = Console.ReadLine();
Console.WriteLine("Indique la palabra que desa buscar");
string buscar = Console.ReadLine();
if (tx1.Contains(buscar))
{
    Console.WriteLine("La palabra que indico es: " + buscar);
}
else
{
    Console.WriteLine("Lo siento, la palabra que solicito no fue encontrada");
}

Console.WriteLine("Ingrese una cadena de texto"); //contar vocales 
string tx2 = Console.ReadLine();
int vocales = 0;
foreach (char letra in tx2)
{
    if ("aeiouAEIOU".Contains(letra))
    {
        vocales++;
    }
}
Console.WriteLine("El numero de vocales encontradas son: " + vocales);