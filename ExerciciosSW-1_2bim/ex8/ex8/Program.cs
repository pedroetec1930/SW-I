using System;

namespace ex8
{
    

    public class Fabricante
    {
        private string nome;
        private string endereço;
        private string cidade;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do fabricante não pode estar vazio.");
                }
                nome = value;
            }
        }

        public string Endereço
        {
            get { return endereço; }
            set { endereço = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public Fabricante(string nome, string endereço, string cidade)
        {
            Nome = nome;
            Endereço = endereço;
            Cidade = cidade;
        }
    }

    public class Produto
    {
        private string nome;
        private Fabricante fabricante;
        private double preço;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do produto não pode estar vazio.");
                }
                nome = value;
            }
        }

        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public double Preço
        {
            get { return preço; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O preço do produto deve ser positivo.");
                }
                preço = value;
            }
        }

        public Produto(string nome, Fabricante fabricante, double preço)
        {
            Nome = nome;
            Fabricante = fabricante;
            Preço = preço;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fabricante fabricante = new Fabricante("Fabricante A", "Rua 1", "Cidade A");
            Produto produto = new Produto("Produto X", fabricante, 100.0);

            Console.WriteLine($"Nome do produto: {produto.Nome}");
            Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}, Endereço: {produto.Fabricante.Endereço}, Cidade: {produto.Fabricante.Cidade}");
            Console.WriteLine($"Preço: {produto.Preço}");

            Console.ReadLine();
        }
    }

}