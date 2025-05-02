using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine();

        bool temMaiuscula = false, temNumero = false, temEspecial = false;

        foreach (char c in senha)
        {
            if (char.IsUpper(c)) temMaiuscula = true;
            else if (char.IsDigit(c)) temNumero = true;
            else if (!char.IsLetterOrDigit(c)) temEspecial = true;
        }

        if (senha.Length >= 8 && temMaiuscula && temNumero && temEspecial)
        {
            Console.WriteLine("Senha válida!");
        }
        else
        {
            Console.WriteLine("Senha inválida!");
        }
    }
}
