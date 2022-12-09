using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Player
{
    public abstract class IContenutoRiproducibile
    {
        public abstract string Titolo();
        public abstract string Artista();
        public abstract string Descrizione();
        public abstract string Durata();
        public abstract int Anno();


        // METODI PUBBLICI
        public void Play()
        {
            Console.WriteLine("Hai messo play al contenuto.");
        }
        public void Pausa()
        {
            Console.WriteLine("Hai messo in pausa il contenuto.");
        }
        public void Stop()
        {
            Console.WriteLine("Hai stoppato il contenuto.");
        }
    }
}
