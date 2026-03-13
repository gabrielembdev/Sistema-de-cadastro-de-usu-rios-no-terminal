using System;
using System.Collections.Generic;

class Usuario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Program
{
    static List<Usuario> usuarios = new List<Usuario>();

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Atualizar usuário");
            Console.WriteLine("4 - Remover usuário");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Cadastrar(); break;
                case 2: Listar(); break;
                case 3: Atualizar(); break;
                case 4: Remover(); break;
            }

        } while (opcao != 0);
    }

    static void Cadastrar()
    {
        Usuario u = new Usuario();

        Console.Write("Nome: ");
        u.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        u.Idade = int.Parse(Console.ReadLine());

        usuarios.Add(u);

        Console.WriteLine("Usuário cadastrado!");
    }

    static void Listar()
    {
        if (usuarios.Count == 0)
        {
            Console.WriteLine("Nenhum usuário cadastrado.");
            return;
        }

        for (int i = 0; i < usuarios.Count; i++)
        {
            Console.WriteLine($"{i} - {usuarios[i].Nome}, {usuarios[i].Idade} anos");
        }
    }

    static void Atualizar()
    {
        Listar();

        Console.Write("Digite o índice do usuário: ");
        int i = int.Parse(Console.ReadLine());

        if (i >= 0 && i < usuarios.Count)
        {
            Console.Write("Novo nome: ");
            usuarios[i].Nome = Console.ReadLine();

            Console.Write("Nova idade: ");
            usuarios[i].Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Atualizado!");
        }
    }

    static void Remover()
    {
        Listar();

        Console.Write("Digite o índice do usuário: ");
        int i = int.Parse(Console.ReadLine());

        if (i >= 0 && i < usuarios.Count)
        {
            usuarios.RemoveAt(i);
            Console.WriteLine("Removido!");
        }
    }
}
