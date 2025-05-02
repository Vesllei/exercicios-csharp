using System;

class Exercicio03
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        long fatorial = 1; 
        while (numero > 0)
        {
            fatorial *= numero;
            numero--;
        }

        Console.WriteLine($"Fatorial: {fatorial}");
    }
}