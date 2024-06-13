using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Treseta : Form
    {
        public Treseta()
        {
            InitializeComponent();
        }

        // file.txt !! C:/Users/Documents/file.txt !! /files/file.txt !! ../../slike/file.txt
        public Stanje StanjeIgre { get; set; }

        private void azuriraj_stanje( Stanje stanje )
        {            

            igrac1.ImageLocation = stanje.igrac[0].pathSlika;
            igrac2.ImageLocation = stanje.igrac[1].pathSlika;
            igrac3.ImageLocation = stanje.igrac[2].pathSlika;
            igrac4.ImageLocation = stanje.igrac[3].pathSlika;
            igrac5.ImageLocation = stanje.igrac[4].pathSlika;
            igrac6.ImageLocation = stanje.igrac[5].pathSlika;
            igrac7.ImageLocation = stanje.igrac[6].pathSlika;
            igrac8.ImageLocation = stanje.igrac[7].pathSlika;
            igrac9.ImageLocation = stanje.igrac[8].pathSlika;
            igrac10.ImageLocation = stanje.igrac[9].pathSlika;

            //aiBacena - ai bacena; igracBacena - igrac bacena

            if (stanje.igracprvi)
            {
                igracBacena.ImageLocation = stanje.donja_na_stolu.pathSlika;
                aiBacena.ImageLocation = stanje.gornja_na_stolu.pathSlika;


            }
            else
            {
                igracBacena.ImageLocation = stanje.gornja_na_stolu.pathSlika;
                aiBacena.ImageLocation = stanje.donja_na_stolu.pathSlika;
            }

            if ( stanje.prazan_spil )
            {
                pbSpil.Image = null;
            }


        }


        private bool provjeri_zog(Stanje stanje, string zog, Karta bacenakarta)
        {


            if ( bacenakarta.Zog == zog )
            {
    
                return true;


            }
            else
            {

                foreach ( var x in stanje.igrac )
                {

                    if ( x.Zog == zog )
                    {

                        MessageBox.Show("Ilegalan potez, neispravan zog!");
                        return false;

                    }

                }

                return true;

            }


        }


        private void Treseta_Load(object sender, EventArgs e)
        {

            Spil novi_spil = new Spil();
            this.StanjeIgre.spil = novi_spil.spil;
            Console.WriteLine( "Pena krena" );
            for ( int i = 0; i < 10; i++ )
            {

                this.StanjeIgre.igrac.Add(this.StanjeIgre.spil[0]);
                this.StanjeIgre.racunalo.Add(this.StanjeIgre.spil[1]);
                Console.WriteLine(this.StanjeIgre.igrac[i].pathSlika + " " + this.StanjeIgre.racunalo[i].pathSlika );
                this.StanjeIgre.spil.RemoveAll(x => x.pathSlika == this.StanjeIgre.spil[0].pathSlika);
                this.StanjeIgre.spil.RemoveAll(x => x.pathSlika == this.StanjeIgre.spil[0].pathSlika);
                Console.WriteLine(this.StanjeIgre.spil[0].pathSlika + " " + this.StanjeIgre.spil[1].pathSlika );

            }
            Random koprvi = new Random();
            int kodrugi = koprvi.Next( 1235455 );
            this.StanjeIgre.igracprvi = kodrugi%2==0;
            this.StanjeIgre.prazan_spil = false;
            azuriraj_stanje( this.StanjeIgre );

        }

        private void btnIgraj_Click(object sender, EventArgs e)
        {

            Spil novi_spil = new Spil();
            this.StanjeIgre.spil = novi_spil.spil;
            Console.WriteLine("Pena krena");
            for (int i = 0; i < 10; i++)
            {

                this.StanjeIgre.igrac.Add(this.StanjeIgre.spil[0]);
                this.StanjeIgre.racunalo.Add(this.StanjeIgre.spil[1]);
                Console.WriteLine(this.StanjeIgre.igrac[i].pathSlika + " " + this.StanjeIgre.racunalo[i].pathSlika);
                this.StanjeIgre.spil.RemoveAll(x => x.pathSlika == this.StanjeIgre.spil[0].pathSlika);
                this.StanjeIgre.spil.RemoveAll(x => x.pathSlika == this.StanjeIgre.spil[0].pathSlika);
                Console.WriteLine(this.StanjeIgre.spil[0].pathSlika + " " + this.StanjeIgre.spil[1].pathSlika);

            }
            Random koprvi = new Random();
            int kodrugi = koprvi.Next(1235455);
            this.StanjeIgre.igracprvi = kodrugi % 2 == 0;
            this.StanjeIgre.prazan_spil = false;
            azuriraj_stanje(this.StanjeIgre);

        }

        private void igrac1_Click(object sender, EventArgs e)
        {
            igracBacena.Image = igrac1.Image;
            igrac2.Image = null ;
        }

        private void igrac2_Click(object sender, EventArgs e)
        {
            igracBacena.Image = igrac2.Image;
            igrac1.Image = null ;
        }

        private void igrac3_Click(object sender, EventArgs e)
        {
            igracBacena.Image = igrac3.Image;
            igrac1.Image = null;
        }

        private void igrac4_Click(object sender, EventArgs e)
        {
            igracBacena.Image = igrac4.Image;
            igrac1.Image = null;
        }

        private void igrac5_Click(object sender, EventArgs e)
        {
            igracBacena.Image = igrac5.Image;
            igrac1.Image = null;
        }

        private void igrac6_Click(object sender, EventArgs e)
        {
            igracBacena.Image = igrac6.Image;
            igrac1.Image = null;
        }

        private void igrac7_Click(object sender, EventArgs e)
        {
            igracBacena.Image = igrac7.Image;
            igrac1.Image = null;
        }

        private void igrac8_Click(object sender, EventArgs e)
        {
            igracBacena.Image = igrac8.Image;
            igrac1.Image = null;
        }

        private void igrac9_Click(object sender, EventArgs e)
        {
            igracBacena.Image = igrac9.Image;
            igrac1.Image = null;
        }

        private void igrac10_Click(object sender, EventArgs e)
        {
            igracBacena.Image = igrac10.Image;
            igrac1.Image = null;
             
        }

        
    }

     
}
