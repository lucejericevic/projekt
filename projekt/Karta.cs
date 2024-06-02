using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Karta
    {
        string Zog;
        int Broj;
        double Vrijednost;
        string path = " ";
        List<Karta> spil = new List <Karta> ();

        private void PocetniSpil()
        {
            for(int i = 0; i < 40; i++)
            {
                Karta k = new Karta();
                k.Broj = i % 10 + 1;
                if (k.Broj == 1) 
                {
                    k.Vrijednost = 1;
                }
                else if (k.Broj == 2 || k.Broj == 3 || k.Broj == 8 || k.Broj == 9 || k.Broj == 10)
                { 
                    k.Vrijednost = 0.33;
                }
                else
                {
                    k.Vrijednost = 0;
                }
                if (i < 10)
                {
                    k.Zog = "K";
                }
                else if (i < 20)
                {
                    k.Zog = "D";
                }
                else if(i<30)
                {
                    k.Zog = "S";
                }
                else
                {
                    k.Zog = "B";
                }

                spil.Add(k);
                
            }
        }
        

        



        
    }
}
