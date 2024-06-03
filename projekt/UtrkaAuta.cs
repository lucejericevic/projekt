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
    public partial class UtrkaAuta : Form
    {
        
        int brzinaAuta = 5; //brzina auta od igrača
        
        int brzinaCeste = 5; //brzina kojom se cesta pomiče
        
        //za pomicanje auta lijevo i desno
        bool autoLijevo;
        bool autoDesno;
        
        int brzinaPrometa = 5; //brzina kojom ce se ostali auti pomicati
        
        int Score = 0;  //prati koliko smo presli
      
        Random rnd = new Random(); //generira random broj


        public UtrkaAuta()
        {
            InitializeComponent();
            Pocetno();
            
        }


        //namista sliku za pocetak kad se ude u formu, tako da ne krene odmah igrica
        public void Pocetno()
        {
            nagrada.Visible = true;
            buttonStart.Enabled = true;
            bomba.Visible = true;
            brzinaCeste = 0;
            brzinaPrometa = 0;
            Score = 0;
            igrac.Left = 126;
            igrac.Top = 245;
            autoLijevo = false;
            autoDesno = false;

            auto1.Left = 66;
            auto1.Top = 19;

            auto2.Left = 200;
            auto2.Top =85;

            cesta2.Left = -3;
            cesta2.Top = -222;
            cesta1.Left = -2;
            cesta1.Top = -638;

            timer.Stop();
        }
        
        //ovo su postavke za pocetak igrice, igrica se pokrece s ButtonStart_Click
        private void Reset()
        {
            nagrada.Visible = false;
            buttonStart.Enabled = false;
            bomba.Visible = false;
            brzinaCeste = 5;
            brzinaPrometa = 5;
            Score = 0;
            igrac.Left = 126;
            igrac.Top = 245;
            autoLijevo= false;
            autoDesno = false;

            auto1.Left = 66;
            auto1.Top = -120;

            auto2.Left = 294;
            auto2.Top = -185;

            //resetira cestu
            cesta2.Left = -3;
            cesta2.Top = -222;
            cesta1.Left = -2;
            cesta1.Top = -638;

            timer.Start();

        }

       
        private void timer_Tick(object sender, EventArgs e)
        {
            //mijenja Score:
            Score++;
            labelScore.Text = "Score: " + Score;

            //pomice cestu 
            cesta1.Top += brzinaCeste;
            cesta2.Top += brzinaCeste;

            if(cesta1.Top>630)
            {
                cesta1.Top = -630;
            }
            if(cesta2.Top>630)
            {
                cesta2.Top = -630;
            }

            //pomicanje auta lijevo i desno
            if (autoLijevo) { igrac.Left -= brzinaAuta; }
            if (autoDesno) { igrac.Left += brzinaAuta; }

            //onemogucava auto da izlazi izvan granica panela
            if(igrac.Left<30)
            {
                autoLijevo= false;
            }
            else if(igrac.Left+igrac.Width>panel1.Width)
            {
                autoDesno = false;
            }

            //pomice dva sporedna auta put doli
            auto1.Top += brzinaPrometa;
            auto2.Top += brzinaPrometa;

            //vraca sporedne aute u sliku i minja ih
            if(auto1.Top>panel1.Height)
            {
                prominiAuto1(); //funkcija koja minja aute
                auto1.Left = rnd.Next(2, 160); //random bira di ce se pojavit
                auto1.Top = rnd.Next(-100, -65);
            }
            if(auto2.Top>panel1.Height)
            {
                prominiAuto2();
                auto2.Left = rnd.Next(185, 327);
                auto2.Top = rnd.Next(-100, -65);
            }

            //ako se igrac sudari sa sporednim autima
            if(igrac.Bounds.IntersectsWith(auto1.Bounds) || igrac.Bounds.IntersectsWith(auto2.Bounds))
            {
                resetirajIgru();
            }


            //ubrzava promet -> mogla bi prominit tako da se svakih 700 bodova minja brzina
            if(Score>100 && Score <500)
            {
                brzinaPrometa = 5;
                brzinaCeste = 6;
            }
            else if(Score>500 && Score < 1000)
            {
                brzinaPrometa = 6;
                brzinaCeste = 7;
            }
            else if (Score > 1200)
            {
                brzinaPrometa = 8;
                brzinaCeste = 9;
            }
        }

        private void makniAuto(object sender, KeyEventArgs e)
        {
            //ako korisnik stišće livu strelicu (pod uvjeton da auto mora bit unutar panela)
            if(e.KeyCode==Keys.Left && igrac.Left > 0)
            {
                autoLijevo = true;
            }
            //korisnik stišće desnu strelicu...
            if(e.KeyCode==Keys.Right && igrac.Left+igrac.Width<panel1.Width)
            {
                autoDesno = true;
            }
        }

        private void zaustaviAuto(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                autoLijevo = false;
            }
            if(e.KeyCode==Keys.Right)
            {
                autoDesno = false;
            }
        }

        private void prominiAuto1()
        {
            int broj = rnd.Next(1, 8); //generira random broj izmedu 1 i 8
            
            //svaki broj ce prikazivat drugaciji auto (sliku)
            switch(broj)
            {
                case 1:
                    auto1.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    auto1.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    auto1.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    auto1.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    auto1.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    auto1.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    auto1.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    auto1.Image = Properties.Resources.ambulance;
                    break;
            }
        }

        private void prominiAuto2()
        {
            int broj = rnd.Next(1, 8); //generira random broj izmedu 1 i 8

            //svaki broj ce prikazivat drugaciji auto (sliku)
            switch (broj)
            {
                case 1:
                    auto2.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    auto2.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    auto2.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    auto2.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    auto2.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    auto2.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    auto2.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    auto2.Image = Properties.Resources.ambulance;
                    break;
            }
        }


        //kad zavrsi igrica ovo se prikaze:
        private void resetirajIgru()
        {
            nagrada.Visible = true;
            timer.Stop();
            buttonStart.Enabled = true;

            bomba.Visible=true;
            igrac.Controls.Add(bomba); //stavlja sliku bombe priko slike auta
            bomba.Location = new Point(-8, 5);
            bomba.BackColor = Color.Transparent;
            bomba.BringToFront();

            //medalja koju dobijes ovisno o scoreu
            if(Score<1000)
            {
                nagrada.Image = Properties.Resources.bronze;
            }
            if(Score>1000 && Score<3000)
            {
                nagrada.Image = Properties.Resources.silver;
            }
            if(Score>3500)
            {
                nagrada.Image = Properties.Resources.gold;
            }

            Zvuk();
        }



        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            Reset();
            int broj = rnd.Next(1, 8); //generira random broj izmedu 1 i 8

            //svaki broj ce prikazivat drugaciji auto (sliku)
            switch (broj)
            {
                case 1:
                    BackColor = Color.PaleVioletRed;
                    break;
                case 2:
                    BackColor = Color.LightBlue;
                    break;
                case 3:
                    BackColor = Color.Yellow;
                    break;
                case 4:
                    BackColor = Color.LightPink;
                    break;
                case 5:
                    BackColor = Color.Orange;
                    break;
                case 6:
                    BackColor = Color.LightGreen;
                    break;
                case 7:
                    BackColor = Color.LightSteelBlue;
                    break;
                case 8:
                    BackColor = Color.Magenta;
                    break;
            }
        }

        private void Zvuk()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"hit.wav");
            player.Play();

        }

   
    }
}
