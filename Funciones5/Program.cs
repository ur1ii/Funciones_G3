int suma(int num1, int num2)
{
    int resultado = num1 + num2;
    return resultado;
}
Console.WriteLine("Ingresa un numero");
if(int.TryParse(Console.ReadLine(), out int num1))
{
    
}
else
{
    Console.WriteLine("ERROR, reingrese los datos");
    return;
}

Console.WriteLine("Ingresa otro numero");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"La suma es: {suma(num1, num2)}");
///
int resta(int num1, int num2)
{
    int resultado = num1 - num2;
    return resultado;
}
Console.WriteLine("Ingresa un numero");
int num1r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ingresa otro numero");
int num2r = int.Parse(Console.ReadLine()!);
Console.WriteLine($"La resta es: {resta(num1r, num2r)}");
///
int multiplicacion(int num1, int num2)
{
    int resultado = num1 * num2;
    return resultado;
}
Console.WriteLine("Ingresa un numero");
int num1m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ingresa otro numero");
int num2m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"La multiplicacion es: {multiplicacion(num1m, num2m)}");
///
double division(double num1, double num2)
{
    double resultado = num1 / num2;
    return resultado;
}
Console.WriteLine("Ingresa un numero");
double num1d = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ingresa otro numero");
double num2d = double.Parse(Console.ReadLine()!);
Console.WriteLine($"La division es: {division(num1d, num2d)}");