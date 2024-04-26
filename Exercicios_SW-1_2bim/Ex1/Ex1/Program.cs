using System;
using System.Runtime.ConstrainedExecution;

public class Produto
{
    // Atributos
    private string nome;
    private double preco;
    private int quantidadeEmEstoque;
    // Construtor
    public Produto(string nome, double preco, int quantidadeInicial)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidadeEmEstoque = quantidadeInicial;
    }
    // Método para adicionar itens ao estoque
    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            quantidadeEmEstoque += quantidade;
            Console.WriteLine($"{quantidade} unidades do produto '{nome}' foram adicionadas ao estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade a ser adicionada deve ser maior que zero.");
        }
    }
    // Método para remover itens do estoque
    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <=
        quantidadeEmEstoque)
        {
            quantidadeEmEstoque -= quantidade;
            Console.WriteLine($"{quantidade} unidades do produto '{nome}' foram removidas do estoque.");
        }
        else if (quantidade > quantidadeEmEstoque)
        {
            Console.WriteLine($"Não há {quantidade} unidades do produto '{nome}' disponíveis no estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade a ser removida deve ser maior que zero.");
        }
    }

    // Método para exibir informações do produto
    public void MostrarInformacoes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Preço: R${preco:F2}");
        Console.WriteLine($"Quantidade em estoque: + { quantidadeEmEstoque}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso da classe Produto
        Produto produto1 = new
        Produto("Camiseta", 29.99, 50);
        produto1.MostrarInformacoes();
        produto1.AdicionarEstoque(10);
        produto1.RemoverEstoque(5);
        produto1.RemoverEstoque(60); 
        // Tentativa de remover mais itens do que disponível
        Console.WriteLine("\nAtualizando informações do produto após operações:");
        produto1.MostrarInformacoes();
    }
}