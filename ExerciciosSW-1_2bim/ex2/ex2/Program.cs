using System;
using System.Collections.Generic;

namespace ex2
{


    public class RegistroDeCompras
    {
        // Atributos para armazenar informações de compras
        private List<(DateTime data, string produto, double valor)> compras;

        // Construtor
        public RegistroDeCompras()
        {
            compras = new List<(DateTime, string, double)>();
        }

        // Método para adicionar uma compra
        public void AdicionarCompra(DateTime data, string produto, double valor)
        {
            compras.Add((data, produto, valor));
        }

        // Método para listar todas as compras
        public void ListarCompras()
        {
            Console.WriteLine("Lista de Compras:");
            foreach (var compra in compras)
            {
                Console.WriteLine($"Data: {compra.data.ToShortDateString()}, Produto: {compra.produto}, Valor: {compra.valor}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RegistroDeCompras registro = new RegistroDeCompras();

            // Adicionando algumas compras
            registro.AdicionarCompra(new DateTime(2024, 5, 15), "Produto A", 50.0);
            registro.AdicionarCompra(new DateTime(2024, 5, 16), "Produto B", 30.0);

            // Listando todas as compras
            registro.ListarCompras();
        }
    }

}