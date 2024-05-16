using System;

namespace ex11
{
    

    public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        private int velocidade;

        public int Velocidade
        {
            get { return velocidade; }
            private set
            {
                // Garante que a velocidade nunca seja negativa
                velocidade = Math.Max(value, 0);
            }
        }

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0; // Velocidade inicialmente é zero
        }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Frear()
        {
            Velocidade -= 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("Fusca", 1975);

            Console.WriteLine($"Modelo: {meuCarro.Modelo}, Ano: {meuCarro.Ano}, Velocidade: {meuCarro.Velocidade}");

            meuCarro.Acelerar();
            Console.WriteLine($"Após acelerar, Velocidade: {meuCarro.Velocidade}");

            meuCarro.Frear();
            Console.WriteLine($"Após frear, Velocidade: {meuCarro.Velocidade}");

            // Tentar frear novamente quando a velocidade já é zero
            meuCarro.Frear();
            Console.WriteLine($"Após frear novamente, Velocidade: {meuCarro.Velocidade}");

            Console.ReadLine();
        }
    }

}