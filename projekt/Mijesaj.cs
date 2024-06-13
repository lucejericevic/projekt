using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public static class Mijesaj
    {

        public static void Promjesaj<T>( this Random nasumican, List<T> niz )
        {


            for ( int i = 0; i < 10; i++ ) {
            int n = niz.Count;
            while ( n > 1 )
            { 
            
                int ineks = nasumican.Next( n -- );
                T pamtilica = niz[ n ];
                niz[n] = niz[ ineks ];
                niz[ineks] = pamtilica;

            
            }
            }

        }


    }
}
