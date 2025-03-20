using System;

public class exercicio02
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        string input = Console.ReadLine();
        int numero;
        
        if (int.TryParse(input, out numero))
        {
            Console.WriteLine($"O número informado foi {numero}");
        }
        else
        {
            Console.WriteLine("Por favor, digite um número válido.");
        }
    }
}