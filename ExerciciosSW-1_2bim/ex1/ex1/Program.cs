using System;

namespace ex1
{


    public class Produto
    {
        // Atributos
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int QuantidadeEmEstoque { get; private set; }

        // Construtor
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        // Método para adicionar itens ao estoque
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

        // Método para remover itens do estoque
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

    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização da classe Produto
            Produto meuProduto = new Produto("Caneta", 1.5, 50);

            Console.WriteLine($"Produto: {meuProduto.Nome}, Preço: {meuProduto.Preco}, Quantidade em Estoque: {meuProduto.QuantidadeEmEstoque}");

            meuProduto.AdicionarAoEstoque(20);
            Console.WriteLine($"Novo estoque: {meuProduto.QuantidadeEmEstoque}");

            meuProduto.RemoverDoEstoque(15);
            Console.WriteLine($"Novo estoque: {meuProduto.QuantidadeEmEstoque}");

            meuProduto.RemoverDoEstoque(40);
            Console.WriteLine($"Novo estoque: {meuProduto.QuantidadeEmEstoque}");

            Console.ReadLine();
        }
    }

}