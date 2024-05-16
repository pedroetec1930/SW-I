using System;
using System.Collections.Generic;
using System.Linq;

namespace ex6
{


    public class Produto
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int QuantidadeEmEstoque { get; private set; }

        private static int proximoCodigo = 1;

        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Codigo = proximoCodigo++;
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public void AdicionarAoEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                QuantidadeEmEstoque += quantidade;
                Console.WriteLine($"{quantidade} {Nome}(s) adicionado(s) ao estoque.");
            }
            else
            {
                Console.WriteLine("A quantidade a ser adicionada deve ser maior que zero.");
            }
        }

        public void RemoverDoEstoque(int quantidade)
        {
            if (quantidade > 0 && quantidade <= QuantidadeEmEstoque)
            {
                QuantidadeEmEstoque -= quantidade;
                Console.WriteLine($"{quantidade} {Nome}(s) removido(s) do estoque.");
            }
            else if (quantidade > QuantidadeEmEstoque)
            {
                Console.WriteLine("Quantidade solicitada excede a quantidade disponível em estoque.");
            }
            else
            {
                Console.WriteLine("A quantidade a ser removida deve ser maior que zero.");
            }
        }
    }

    public class GerenciadorDeProdutos
    {
        private List<Produto> produtos;

        public GerenciadorDeProdutos()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(string nome, double preco, int quantidadeEmEstoque)
        {
            Produto novoProduto = new Produto(nome, preco, quantidadeEmEstoque);
            produtos.Add(novoProduto);
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        public void ApresentarProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade em Estoque: {produto.QuantidadeEmEstoque}");
            }
        }

        public Produto ConsultarProdutoPorCodigo(int codigo)
        {
            return produtos.FirstOrDefault(p => p.Codigo == codigo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização da classe GerenciadorDeProdutos
            GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();

            gerenciador.AdicionarProduto("Caneta", 1.5, 50);
            gerenciador.AdicionarProduto("Caderno", 5.0, 20);

            gerenciador.ApresentarProdutos();

            Console.WriteLine("\nConsultar produto pelo código:");
            Console.Write("Digite o código do produto: ");
            int codigoConsultado = Convert.ToInt32(Console.ReadLine());

            Produto produtoConsultado = gerenciador.ConsultarProdutoPorCodigo(codigoConsultado);
            if (produtoConsultado != null)
            {
                Console.WriteLine($"Produto encontrado - Nome: {produtoConsultado.Nome}, Preço: {produtoConsultado.Preco}, Quantidade em Estoque: {produtoConsultado.QuantidadeEmEstoque}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }

            Console.ReadLine();
        }
    }

}