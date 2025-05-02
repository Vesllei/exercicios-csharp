using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine().ToLower();

        entrada = Regex.Replace(entrada, "[^a-z]", "");

        char[] arr = entrada.ToCharArray();
        Array.Reverse(arr);
        string reverso = new string(arr);

        if (entrada == reverso)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }
}
