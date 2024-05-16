using System;
using System.Collections.Generic;

namespace ex7
{
    

    public class Música
    {
        public string Nome { get; private set; }
        public string Autor { get; private set; }
        public string Gravadora { get; private set; }

        public Música(string nome, string autor, string gravadora)
        {
            Nome = nome;
            Autor = autor;
            Gravadora = gravadora;
        }
    }

    public class Playlist
    {
        private List<Música> músicas;
        public string Dono { get; private set; }

        public Playlist(string dono)
        {
            Dono = dono;
            músicas = new List<Música>();
        }

        public void AdicionarMúsica(Música música)
        {
            músicas.Add(música);
            Console.WriteLine($"Música '{música.Nome}' adicionada à playlist de {Dono}.");
        }

        public void TocarMúsicaAleatória()
        {
            if (músicas.Count == 0)
            {
                Console.WriteLine("A playlist está vazia. Adicione músicas para reproduzir.");
                return;
            }

            Random random = new Random();
            int índiceAleatório = random.Next(músicas.Count);
            Música músicaAleatória = músicas[índiceAleatório];
            Console.WriteLine($"Reproduzindo '{músicaAleatória.Nome}' de {músicaAleatória.Autor}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Playlist minhaPlaylist = new Playlist("João");

            minhaPlaylist.AdicionarMúsica(new Música("Shape of You", "Ed Sheeran", "Atlantic Records"));
            minhaPlaylist.AdicionarMúsica(new Música("Bohemian Rhapsody", "Queen", "EMI Records"));
            minhaPlaylist.AdicionarMúsica(new Música("Stairway to Heaven", "Led Zeppelin", "Atlantic Records"));

            minhaPlaylist.TocarMúsicaAleatória();
            minhaPlaylist.TocarMúsicaAleatória();
            minhaPlaylist.TocarMúsicaAleatória();
            minhaPlaylist.TocarMúsicaAleatória();

            Console.ReadLine();
        }
    }

}