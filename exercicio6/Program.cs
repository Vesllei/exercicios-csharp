using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotal()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < produtos.Length; i++)
        {
            produtos[i] = new Produto();

            Console.Write($"Digite o nome do produto {i + 1}: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write($"Digite o preço do produto {i + 1}: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write($"Digite a quantidade do produto {i + 1}: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nProdutos cadastrados:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco:C}, Quantidade: {produto.Quantidade}, Valor total: {produto.ValorTotal():C}");
        }
    }
}
