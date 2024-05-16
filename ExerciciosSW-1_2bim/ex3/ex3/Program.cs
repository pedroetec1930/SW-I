using System;
using System.Collections.Generic;
using System.Linq;

namespace ex3
{


    public class CorretoraDeImóveis
    {
        // Classe interna para representar um imóvel
        private class Imovel
        {
            public string Endereco { get; set; }
            public double Preco { get; set; }
            public string Tipo { get; set; }
        }

        // Lista para armazenar os imóveis
        private List<Imovel> imoveis;

        // Construtor
        public CorretoraDeImóveis()
        {
            imoveis = new List<Imovel>();
        }

        // Método para inserir um novo imóvel na lista
        public void InserirImovel(string endereco, double preco, string tipo)
        {
            Imovel novoImovel = new Imovel
            {
                Endereco = endereco,
                Preco = preco,
                Tipo = tipo
            };
            imoveis.Add(novoImovel);
            Console.WriteLine("Imóvel adicionado com sucesso!");
        }

        // Método para alterar o preço de um imóvel existente
        public void AlterarPreco(string endereco, double novoPreco)
        {
            Imovel imovel = imoveis.FirstOrDefault(i => i.Endereco == endereco);
            if (imovel != null)
            {
                imovel.Preco = novoPreco;
                Console.WriteLine("Preço do imóvel alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
        }

        // Método para listar todos os imóveis disponíveis
        public void ListarImoveis()
        {
            Console.WriteLine("Lista de Imóveis Disponíveis:");
            foreach (var imovel in imoveis)
            {
                Console.WriteLine($"Endereço: {imovel.Endereco}, Preço: {imovel.Preco}, Tipo: {imovel.Tipo}");
            }
        }

        // Método para calcular o valor médio dos imóveis
        public double CalcularValorMedio()
        {
            if (imoveis.Count == 0)
            {
                return 0;
            }
            else
            {
                double somaPrecos = imoveis.Sum(i => i.Preco);
                return somaPrecos / imoveis.Count;
            }
        }

        // Método para exibir o menu e interagir com o usuário
        public void ExibirMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir novo imóvel");
                Console.WriteLine("2. Alterar preço de um imóvel");
                Console.WriteLine("3. Listar todos os imóveis");
                Console.WriteLine("4. Calcular valor médio dos imóveis");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Endereço do imóvel: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Preço do imóvel: ");
                        double preco = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tipo do imóvel: ");
                        string tipo = Console.ReadLine();
                        InserirImovel(endereco, preco, tipo);
                        break;
                    case "2":
                        Console.Write("Endereço do imóvel: ");
                        string enderecoAlteracao = Console.ReadLine();
                        Console.Write("Novo preço do imóvel: ");
                        double novoPreco = Convert.ToDouble(Console.ReadLine());
                        AlterarPreco(enderecoAlteracao, novoPreco);
                        break;
                    case "3":
                        ListarImoveis();
                        break;
                    case "4":
                        Console.WriteLine($"Valor médio dos imóveis: {CalcularValorMedio()}");
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização da classe CorretoraDeImóveis
            CorretoraDeImóveis corretora = new CorretoraDeImóveis();

            corretora.ExibirMenu();

            Console.ReadLine();
        }
    }

}