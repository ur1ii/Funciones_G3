using System;

Console.Clear();

double calcular(double num1, double num2)
{
    return (num1 * num2) / 2;
}
try
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("=== AREA DEL TRIANGULO ===");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Ingresa la base del triangulo");
    double baseT = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingrese la altura del triangulo");
    double AlturaT = int.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"El area del triangulo es: {calcular(baseT, AlturaT)}");
    Console.ResetColor();
}
catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR, Reingrese los datos");
    Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Presine cualquier tecla para salir...");
Console.ResetColor();
Console.ReadKey();
