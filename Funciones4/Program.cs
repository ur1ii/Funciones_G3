
Console.Clear();

double salario(double horas, double pagoh)
{
    return horas * pagoh;
}
Console.WriteLine("Ingrese las horas que trabaja");
int horas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ingrese cuanto le pagan por hora");
int pagoh = int.Parse(Console.ReadLine()!);
Console.WriteLine($"El salario es de: {salario(horas, pagoh)}");

