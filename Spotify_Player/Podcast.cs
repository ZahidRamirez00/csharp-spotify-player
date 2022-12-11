using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Player
{
    public class Podcast : IContenutoRiproducibile
    {
        private string titolo;
        private string titoloCollana;
        private string autore;
        private string durata;
        private string descrizione;
        public Podcast(string Titolo, string TitoloCollana, string NomeAutore, string Durata, string Descrizione) 
        {
            this.titolo = Titolo;
            this.titoloCollana = TitoloCollana;
            this.autore = NomeAutore;
            this.durata = Durata;
            this.descrizione = Descrizione;
        }
        
        public string GetTitolo()
        {
            return this.titolo;
        }

        public string GetTitoloCollana()
        {
            return this.titoloCollana;
        }

        public string GetAutore()
        {
            return this.autore;
        }

        public string GetDurata()
        {
            return this.durata;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public void Pausa()
        {
            Console.WriteLine("Il podcast " + this.titolo + " della collana " + this.titoloCollana + " è stato messo in pausa");
        }

        public void Play()
        {
            Console.WriteLine("Il podcast " + this.titolo + " della collana " + this.titoloCollana + " è stato messo riproduzione");
        }

        public void Stop()
        {
            Console.WriteLine("Il podcast " + this.titolo + " della collana " + this.titoloCollana + " è stato stoppato e riavvolto");
        }

        public override string ToString()
        {
            return this.GetTitolo() + "\t\t\t\t\t" + this.GetAutore();
        }
    }
}
