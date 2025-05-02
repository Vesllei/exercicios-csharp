using System;
using System.Collections.Generic;

class Tarefa
{
    public string Descricao { get; set; }
    public bool Concluida { get; set; }

    public Tarefa(string descricao)
    {
        Descricao = descricao;
        Concluida = false;
    }
}

class Program
{
    static void Main()
    {
        List<Tarefa> listaDeTarefas = new List<Tarefa>();
        int opcao;

        do
        {
            Console.WriteLine("\n=== MENU TO-DO LIST ===");
            Console.WriteLine("1 - Adicionar nova tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Marcar tarefa como concluída");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    listaDeTarefas.Add(new Tarefa(descricao));
                    Console.WriteLine("Tarefa adicionada!");
                    break;

                case 2:
                    Console.WriteLine("\n--- Lista de Tarefas ---");
                    if (listaDeTarefas.Count == 0)
                    {
                        Console.WriteLine("Nenhuma tarefa adicionada.");
                    }
                    else
                    {
                        for (int i = 0; i < listaDeTarefas.Count; i++)
                        {
                            string status = listaDeTarefas[i].Concluida ? "[X]" : "[ ]";
                            Console.WriteLine($"{i + 1}. {status} {listaDeTarefas[i].Descricao}");
                        }
                    }
                    break;

                case 3:
                    Console.Write("Digite o número da tarefa que deseja marcar como concluída: ");
                    if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= listaDeTarefas.Count)
                    {
                        listaDeTarefas[numero - 1].Concluida = true;
                        Console.WriteLine("Tarefa marcada como concluída!");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 4);
    }
}
