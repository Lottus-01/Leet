using System.Security.AccessControl;

Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.WriteLine("-Sistema de Criptografia em Leet");
Console.ResetColor();

    Console.WriteLine("Insira a sua fraze e ela será convertida em Leet:");

    string text;
    string textM;
    string codigo;

text = Console.ReadLine();
textM = text.ToUpper();
codigo = textM.Replace("A", "4")
                 .Replace("E", "3")
                 .Replace("O", "0")
                 .Replace("I", "1");

Console.WriteLine($"Texto em Leet: {codigo}");


