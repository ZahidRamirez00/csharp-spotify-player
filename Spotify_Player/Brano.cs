using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Player
{
    public class Brano : IContenutoRiproducibile
    {
        private string titolo;
        private string artista;
        private string album;
        private string genere;
        private string durata;
        private string anno;
        private string descrizione;
        public Brano(string Titolo, string NomeArtista, string Album, string Genere, string Durata, string Anno, string Descrizione)
        {
            this.titolo = Titolo;
            this.artista = NomeArtista;
            this.album = Album;
            this.genere = Genere;
            this.durata = Durata;
            this.anno = Anno;
            this.descrizione = Descrizione;
        }

        public string GetTitolo()
        {
            return this.titolo;
        }

        public string GetArtista()
        {
            return this.artista;
        }

        public string GetAlbum()
        {
            return this.album;
        }

        public string GetGenere()
        {
            return this.genere;
        }

        public string GetDurata()
        {
            return this.durata;
        }

        public string GetAnno()
        {
            return this.anno;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public void Pausa()
        {
            Console.WriteLine("Il podcast " + this.titolo + " è stato messo in pausa");
        }

        public void Play()
        {
            Console.WriteLine("Il podcast " + this.titolo + " è stato messo riproduzione");
        }

        public void Stop()
        {
            Console.WriteLine("Il podcast " + this.titolo + " è stato stoppato e riavvolto");
        }

        public override string ToString()
        {
            return this.GetTitolo() + "\t\t\t\t\t" + this.GetArtista();
        }
    }
}
