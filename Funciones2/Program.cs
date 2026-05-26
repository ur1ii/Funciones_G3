void MostrarMenu()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=== MENU ===");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("1. Suma");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("2. Resta");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("3. Multiplicación");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("4. División");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.ResetColor();
}
MostrarMenu();
