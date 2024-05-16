using System;

namespace ex9
{
    

    public class Livro
    {
        private string titulo;
        private string autor;

        public string Título
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O título do livro não pode estar vazio.");
                }
                titulo = value;
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O autor do livro não pode estar vazio.");
                }
                autor = value;
            }
        }

        public Livro(string título, string autor)
        {
            Título = título;
            Autor = autor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Livro livro = new Livro("Dom Quixote", "Miguel de Cervantes");

                Console.WriteLine($"Título do livro: {livro.Título}");
                Console.WriteLine($"Autor: {livro.Autor}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }

            Console.ReadLine();
        }
    }

}