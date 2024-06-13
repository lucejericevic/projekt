using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projekt
{
    public class Spil
    {
        public List<Karta> spil { get; set; }


        public Spil()         
        {

            this.spil = PocetniSpil();
            Random pjenusavi_mjesanac = new Random();
            pjenusavi_mjesanac.Promjesaj<Karta>(this.spil);
        
        }

        public List<Karta> PocetniSpil()
        {             
            int Broj;
            string Zog;
            double Vrijednost;
            string pathSlika;
            List<Karta> povratnispil = new List<Karta>();

            for (int i = 0; i < 40; i++)
            {

                Broj = i % 10 + 1;
                if (Broj == 1)
                {
                    Vrijednost = 1;
                }
                else if (Broj == 2 || Broj == 3 || Broj == 8 || Broj == 9 || Broj == 10)
                {
                    Vrijednost = 0.33;
                }
                else
                {
                    Vrijednost = 0;
                }
                if (i < 10)
                {
                    Zog = "K";
                }
                else if (i < 20)
                {
                    Zog = "D";
                }
                else if (i < 30)
                {
                    Zog = "S";
                }
                else
                {
                    Zog = "B";
                }

                pathSlika = Zog + "_" + Broj + ".jpg";

                Karta k = new Karta(Zog, Broj, Vrijednost, pathSlika);
                povratnispil.Add(k);



            }

            return povratnispil;

        }

        
    }
}
