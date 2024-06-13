using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Stanje
    {
        public List<Karta> igrac { get; set; }
        public List<Karta> racunalo { get; set; }
        public bool prazan_spil { get; set; }
        public Karta donja_na_stolu { get; set; }
        public Karta gornja_na_stolu { get; set; }
        public bool igracprvi { get; set; }
        public List <Karta> dobiveneIgrac { get; set; }
        public List <Karta> dobiveneAI { get; set; }
        public List <Karta> spil { get; set; }

        public Stanje(List<Karta> dobiveneAI, List<Karta> dobiveneIgrac, List<Karta> igrac, List<Karta> racunalo, bool prazan_spil, Karta gornja_na_stolu, Karta donja_na_stolu, bool igracprvi)
        {
            
            this.igrac = igrac;
            this.racunalo = racunalo;
            this.prazan_spil = prazan_spil;
            this.gornja_na_stolu = gornja_na_stolu;
            this.donja_na_stolu = donja_na_stolu;
            this.igracprvi = igracprvi;
            this.dobiveneIgrac = dobiveneIgrac;
            this.dobiveneAI = dobiveneAI;
            this.spil = spil;
            

            

        }

    }
}

