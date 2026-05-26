double numero;
bool valido = false;

do
{
    Console.Write("Ingrese un número: ");
    string entrada = Console.ReadLine() ?? "";

    if (double.TryParse(entrada, out numero))
    {
        valido = true;
    }
    else
    {
        Console.WriteLine("Entrada inválida, intente de nuevo.");
    }

} while (!valido);

Console.WriteLine("Número válido: " + numero);