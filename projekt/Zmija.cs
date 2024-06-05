using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Zmija : Form
    {

        int tijelo = 0; 
        int Score = 0;
        int jabuka = 0;
        int brzinaTijela = 5; //brzina kojon se zmija mice

        //za pomicanje zmije u svin smjerovima
        bool zmijaLijevo;
        bool zmijaDesno;
        bool zmijaGore;
        bool zmijaDole;



        Random random = new Random(); //generira random broj
        public Zmija()
        {
            InitializeComponent();
        }

       
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;

            //Score se mijenja kad pojede jabuku

            //jabuka se stvara na random lokaciji
            


        }
    }
}
