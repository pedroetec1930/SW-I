using System;

namespace ex10
{
    

    public class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, string especie, int idade)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        public void EmitirSom()
        {
            Console.WriteLine($"O {Especie} {Nome} está emitindo um som.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cachorro = new Animal("Rex", "Cachorro", 3);
            Animal gato = new Animal("Miau", "Gato", 5);

            cachorro.EmitirSom();
            gato.EmitirSom();

            Console.ReadLine();
        }
    }

}