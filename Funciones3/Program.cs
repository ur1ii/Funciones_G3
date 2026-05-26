using System;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== IDENTIFICADOR DE NUMEROS PARES ===");
Console.ResetColor();
bool EsPar(int numero)
{
    return numero % 2 == 0;
}
try
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Ingresa un numero");
    int numero = int.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Es par: ");
    Console.WriteLine(EsPar(numero));
    Console.ResetColor();
}
catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR, Reingrese los datos");
    Console.ResetColor();
}
Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();