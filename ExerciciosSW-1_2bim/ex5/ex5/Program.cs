using System;
using System.Collections.Generic;
using System.Linq;

namespace ex5
{


    public class GerenciadorDeTarefas
    {
        // Classe interna para representar uma tarefa
        private class Tarefa
        {
            public string Descricao { get; set; }
            public DateTime DataVencimento { get; set; }
        }

        // Lista para armazenar as tarefas
        private List<Tarefa> tarefas;

        // Construtor
        public GerenciadorDeTarefas()
        {
            tarefas = new List<Tarefa>();
        }

        // Método para adicionar uma nova tarefa à lista
        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            Tarefa novaTarefa = new Tarefa
            {
                Descricao = descricao,
                DataVencimento = dataVencimento
            };
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        // Método para remover uma tarefa da lista
        public void RemoverTarefa(string descricao)
        {
            Tarefa tarefa = tarefas.FirstOrDefault(t => t.Descricao == descricao);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        // Método para listar todas as tarefas
        public void ListarTarefas()
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
            }
        }

        // Método para verificar se uma tarefa deve ser executada hoje
        public void VerificarTarefaHoje()
        {
            DateTime hoje = DateTime.Today;
            Console.WriteLine("Tarefas para hoje:");
            foreach (var tarefa in tarefas)
            {
                if (tarefa.DataVencimento.Date == hoje)
                {
                    Console.WriteLine($"Descrição: {tarefa.Descricao}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização da classe GerenciadorDeTarefas
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

            gerenciador.AdicionarTarefa("Estudar para o exame", DateTime.Today.AddDays(2));
            gerenciador.AdicionarTarefa("Fazer compras", DateTime.Today);
            gerenciador.AdicionarTarefa("Pagar contas", DateTime.Today.AddDays(1));

            gerenciador.ListarTarefas();

            gerenciador.VerificarTarefaHoje();

            gerenciador.RemoverTarefa("Fazer compras");

            gerenciador.ListarTarefas();

            Console.ReadLine();
        }
    }

}