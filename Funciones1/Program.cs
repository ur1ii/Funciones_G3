using System;

Console.Clear();

double calcular(double num1, double num2)
{
    return (num1 * num2) / 2;
}
Console.WriteLine("Ingresa la base del triangulo");
double baseT = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ingrese la altura del triangulo");
double AlturaT = int.Parse(Console.ReadLine()!);
Console.WriteLine($"El area del triangulo es: {calcular(baseT, AlturaT)}");