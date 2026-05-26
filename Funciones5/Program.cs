
Console.Clear();

int suma(int num1, int num2)
{
    return num1 + num2;
}
int resta(int num1, int num2)
{
    return num1 - num2;
}
int multi(int num1, int num2)
{
    return num1 * num2;
}
double divi(double num1, double num2)
{
    return num1 / num2;
}
try
{
    //suma
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=== SUMA ===");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Ingresa el primer numero");
    int num1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingresa el segundo numero");
    int num2 = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"La respuesta es: {suma(num1, num2)}");
    Console.ResetColor();
    //resta
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=== RESTA ===");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Ingresa el primer numero");
    int num1r = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingresa el segundo numero");
    int num2r = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"La respuesta es: {resta(num1r, num2r)}");
    Console.ResetColor();
    //multiplicacion
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=== MULTIPLICACION ===");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Ingresa el primer numero");
    int num1m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingresa el segundo numero");
    int num2m = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"La respuesta es: {multi(num1m, num2m)}");
    Console.ResetColor();
    //division
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=== DIVISION ===");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Ingresa el primer numero");
    double num1d = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingresa el segundo numero");
    double num2d = double.Parse(Console.ReadLine()!);
    Console.ResetColor();
    if(num1d == 0 || num2d == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR, No se puede dividir por 0");
        Console.ResetColor();
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"La respuesta es: {divi(num1d, num2d)}");
    Console.ResetColor();
}
catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR. Reingrese los datos");
    Console.ResetColor();
    return;
}
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();
Console.ResetColor();
