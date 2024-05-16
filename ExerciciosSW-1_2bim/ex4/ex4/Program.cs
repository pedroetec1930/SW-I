using System;
using System.Collections.Generic;
using System.Linq;

namespace ex4
{


    public class AgendaTelefonica
    {
        // Classe interna para representar um contato
        private class Contato
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
        }

        // Lista para armazenar os contatos
        private List<Contato> contatos;

        // Construtor
        public AgendaTelefonica()
        {
            contatos = new List<Contato>();
        }

        // Método para adicionar um novo contato à lista
        public void AdicionarContato(string nome, string telefone, string email)
        {
            Contato novoContato = new Contato
            {
                Nome = nome,
                Telefone = telefone,
                Email = email
            };
            contatos.Add(novoContato);
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        // Método para remover um contato da lista
        public void RemoverContato(string nome)
        {
            Contato contato = contatos.FirstOrDefault(c => c.Nome == nome);
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine("Contato removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        // Método para buscar um contato pelo nome
        public void BuscarContato(string nome)
        {
            Contato contato = contatos.FirstOrDefault(c => c.Nome == nome);
            if (contato != null)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização da classe AgendaTelefonica
            AgendaTelefonica agenda = new AgendaTelefonica();

            agenda.AdicionarContato("João", "123456789", "joao@example.com");
            agenda.AdicionarContato("Maria", "987654321", "maria@example.com");
            agenda.AdicionarContato("Carlos", "456789123", "carlos@example.com");

            agenda.BuscarContato("João");
            agenda.BuscarContato("Pedro");

            agenda.RemoverContato("Maria");
            agenda.BuscarContato("Maria");

            Console.ReadLine();
        }
    }

}