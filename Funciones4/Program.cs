
Console.Clear();

double salario(double horas, double pagoh)
{
    return horas * pagoh;
}
try
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Ingrese las horas que trabaja");
    int horas = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingrese cuanto le pagan por hora");
    int pagoh = int.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"El salario es de: {salario(horas, pagoh)}");
    Console.ResetColor();
}
catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR, Reingrese los datos");
    Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Presione cualquier boton para salir...");
Console.ReadKey();
Console.ResetColor();


