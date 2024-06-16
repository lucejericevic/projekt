using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
        public Spil spil { get; set; }


        public Stanje()
        {

            Spil spilica = new Spil();
            this.spil = spilica;

            this.igrac = new List<Karta> { };
            this.racunalo = new List<Karta> { };

            for (int i = 0; i < 10; i++)
            {

                this.igrac.Add(this.spil.spil[0]);
                this.racunalo.Add(this.spil.spil[1]);
                Console.WriteLine(this.igrac[i].pathSlika + " " + this.racunalo[i].pathSlika);
                this.spil.spil.RemoveAll(x => x.pathSlika == this.spil.spil[0].pathSlika);
                this.spil.spil.RemoveAll(x => x.pathSlika == this.spil.spil[0].pathSlika);
                Console.WriteLine(this.spil.spil[0].pathSlika + " " + this.spil.spil[1].pathSlika);

            }
            Random koprvi = new Random();
            int kodrugi = koprvi.Next(1235455);
            this.igracprvi = kodrugi % 2 == 0;
            this.prazan_spil = false;


            this.dobiveneAI = new List<Karta> { };
            this.dobiveneIgrac = new List<Karta> { };
            this.gornja_na_stolu = null;
            this.donja_na_stolu = null;
            
            

            

        }

    }
}

