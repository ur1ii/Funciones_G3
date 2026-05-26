bool EsMayorDeEdad(int edad)
{
    return edad >= 18;
}

Console.Write("Ingrese su edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

if (EsMayorDeEdad(edad))
{
    Console.WriteLine("Usted es mayor de edad.");
}
else
{
    Console.WriteLine("Usted es menor de edad.");
}