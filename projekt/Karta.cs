using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Karta
    {
        public string Zog { get; set; }
        public int Broj { get; set; }
        public double Vrijednost { get; set; }
        public string pathSlika { get; set; }


        public Karta( string zog, int broj, double vrijednost, string pathslika )
        {

            this.Zog = zog;
            this.Broj = broj;
            this.Vrijednost = vrijednost;
            this.pathSlika = pathslika;


        }

    }
}
