using System;

class exercicio03
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double soma = numero1 + numero2;

        Console.WriteLine("A soma dos dois números é: " + soma);
    }
}