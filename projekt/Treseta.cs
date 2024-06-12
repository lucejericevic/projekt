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


        private void azuriraj_stanje( Stanje stanje, bool igracprvi )
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

            if (igracprvi)
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


        private void Treseta_Load(object sender, EventArgs e)
        {

        }

        private void btnIgraj_Click(object sender, EventArgs e)
        {
            
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
