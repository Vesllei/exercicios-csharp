using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int soma = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] % 2 == 0)
            {
                soma += numeros[i];
            }
        }

        Console.WriteLine($"Soma dos números pares: {soma}");
    }
}
