double LeerNota(string mensaje)
{
    Console.Write(mensaje);
    return Convert.ToDouble(Console.ReadLine());
}

double CalcularPromedio(double n1, double n2, double n3)
{
    return (n1 + n2 + n3) / 3;
}

string DeterminarEstado(double promedio)
{
    if (promedio >= 70)
        return "Aprobado";
    else
        return "Reprobado";
}



Console.WriteLine("=== Promedio Estudiantil ===");

double nota1 = LeerNota("Ingrese nota 1: ");
double nota2 = LeerNota("Ingrese nota 2: ");
double nota3 = LeerNota("Ingrese nota 3: ");

double promedio = CalcularPromedio(nota1, nota2, nota3);
string estado = DeterminarEstado(promedio);

Console.WriteLine("\n--- RESULTADO ---");
Console.WriteLine("Promedio: " + promedio);
Console.WriteLine("Estado: " + estado);