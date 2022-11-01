int numero;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("Digite um número: ");

numero = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();


if (numero < 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você digitou um número negativo.");
    Console.ResetColor();
}