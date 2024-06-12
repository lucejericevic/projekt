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
