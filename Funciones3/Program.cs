using System;

Console.Clear();

Console.WriteLine("=== IDENTIFICADOR DE NUMEROS PARES ===");
bool EsPar(int numero)
{
    return numero % 2 == 0;
}
Console.WriteLine("Ingresa un numero");
int numero = int.Parse(Console.ReadLine()!);
Console.Write("Es par: ");
Console.WriteLine(EsPar(numero));