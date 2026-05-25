using System;


double CalcularPotencia(double baseNum, double exponente)
{
    return Math.Pow(baseNum, exponente);
}

Console.Write("Ingrese la base: ");
double baseNum = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el exponente: ");
double exponente = Convert.ToDouble(Console.ReadLine());

double resultado = CalcularPotencia(baseNum, exponente);

Console.WriteLine("El resultado es: " + resultado);
