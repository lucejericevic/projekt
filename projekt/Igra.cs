using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Igra
    {
        List<Karta> Igraceve = new List<Karta>();
        List<Karta> Botove = new List<Karta>();
        public void IgraceveKarte(List<Karta> RndSpil)
        {
            for (int i = 0; i < 10; i++)
            {
                Igraceve.Add(RndSpil[i]);
            }

        }

        public void BotoveKarte(List<Karta> RndSpil)
        {
            for (int i = 10; i < 20; i++)
            {
                Botove.Add(RndSpil[i]);
            }
        }
    }    
}
