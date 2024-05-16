using System;
using System.Collections.Generic;

namespace ex12
{
    

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }

        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
    }

    public class Agenda
    {
        private List<Pessoa> pessoas;

        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa novaPessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(novaPessoa);
            Console.WriteLine($"Pessoa '{nome}' armazenada na agenda.");
        }

        public void RemovePessoa(string nome)
        {
            Pessoa pessoaRemovida = BuscaPessoa(nome);
            if (pessoaRemovida != null)
            {
                pessoas.Remove(pessoaRemovida);
                Console.WriteLine($"Pessoa '{nome}' removida da agenda.");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada na agenda.");
            }
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public void ImprimeAgenda()
        {
            Console.WriteLine("Agenda:");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Armazenar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Altura: ");
                        float altura = Convert.ToSingle(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;
                    case 2:
                        Console.Write("Nome da pessoa a ser removida: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemovePessoa(nomeRemover);
                        break;
                    case 3:
                        Console.Write("Nome da pessoa a ser buscada: ");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);
                        if (pessoaEncontrada != null)
                        {
                            Console.WriteLine($"Pessoa encontrada - Nome: {pessoaEncontrada.Nome}, Idade: {pessoaEncontrada.Idade}, Altura: {pessoaEncontrada.Altura}");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        }
                        break;
                    case 4:
                        agenda.ImprimeAgenda();
                        break;
                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Escolha uma opção válida.");
                        break;
                }
            }
        }
    }

}