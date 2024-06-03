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
    public partial class KrizicKruzic : Form
    {

        /**
            Pozicija 
             0|1|2
             3|4|5
             6|7|8
        */
        int[] iData = new int[9];

        //-1 = X, 1 = O, 0 = Zaustavi
        int iTurn = -1;

        //1=igraj s prijateljem, 2=igraj s botom (lagano), 3= igraj s botom (teško)
        //namješteno da automatski igraš s prijateljem
        int iType = 1;

        bool bEnableBot = false;

        //Sprema poziciju zadnjeg poteza
        int iLastMove = -1;

        //Sprema rezultate od X i 
        int rezultatX = 0;
        int rezultatO = 0;


        public KrizicKruzic()
        {
            InitializeComponent();
        }



        //ovo je za resetirat igricu
        void Resetiraj()
        {
            for (int i = 0; i < 9; i++)
            {
                iData[i] = 0;
            }

            iLastMove = -1;
            bEnableBot = false;
            //X prvi igra
            //želim namistit da se minja da svaki put drugi igra prvi
            iTurn = 1;
            SljedeciPotez();

            polje1.Text = null;
            polje2.Text = null;
            polje3.Text = null;
            polje4.Text = null;
            polje5.Text = null;
            polje6.Text = null;
            polje7.Text = null;
            polje8.Text = null;
            polje9.Text = null;

            //da se ne vide povučenje crte pobjednika kad se resetira igra
            panelUspravni.Visible = false;
            panelVodoravni.Visible = false;

        }

        private void KrizicKruzic_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }
        private void igrajSPrijateljemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Igraj s prijateljem";
            iType = 1;
            Resetiraj();
        }

        private void igrajSBotomToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void laganoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Lagano";
            iType = 2;
            Resetiraj();
        }

        private void teškoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Teško";
            iType = 3;
            Resetiraj();
        }


        private void ResetirajIgru(object sender, EventArgs e)
        {
            Resetiraj();
        }



        private void polje1_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;
            if (iData[0] == 0)
            {
                iLastMove = 0;
                iData[0] = iTurn;
                ProminiSliku(iLastMove);
                SljedeciPotez();
                RunBot();
            }
        }

        private void polje2_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;
            if (iData[1] == 0)
            {
                iLastMove = 1;
                iData[1] = iTurn;
                ProminiSliku(iLastMove);
                SljedeciPotez();
                RunBot();
            }
        }

        private void polje3_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;
            if (iData[2] == 0)
            {
                iLastMove = 2;
                iData[2] = iTurn;
                ProminiSliku(iLastMove);
                SljedeciPotez();
                RunBot();
            }
        }

        private void polje4_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;
            if (iData[3] == 0)
            {
                iLastMove = 3;
                iData[3] = iTurn;
                ProminiSliku(iLastMove);
                SljedeciPotez();
                RunBot();
            }
        }

        private void polje5_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;
            if (iData[4] == 0)
            {
                iLastMove = 4;
                iData[4] = iTurn;
                ProminiSliku(iLastMove);
                SljedeciPotez();
                RunBot();
            }
        }

        private void polje6_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;
            if (iData[5] == 0)
            {
                iLastMove = 5;
                iData[5] = iTurn;
                ProminiSliku(iLastMove);
                SljedeciPotez();
                RunBot();
            }
        }

        private void polje7_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;
            if (iData[6] == 0)
            {
                iLastMove = 6;
                iData[6] = iTurn;
                ProminiSliku(iLastMove);
                SljedeciPotez();
                RunBot();
            }
        }

        private void polje8_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;
            if (iData[7] == 0)
            {
                iLastMove = 7;
                iData[7] = iTurn;
                ProminiSliku(iLastMove);
                SljedeciPotez();
                RunBot();
            }
        }

        private void polje9_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;
            if (iData[8] == 0)
            {
                iLastMove = 8;
                iData[8] = iTurn;
                ProminiSliku(iLastMove);
                SljedeciPotez();
                RunBot();
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Text = "🗙                    -";
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Text = "𐩒                    -";
            if (iType == 1 || iLastMove != -1)
                return;

            RunBot();
        }

        
        //Return -1 = X pobjedia, 0 = Draw, 1 = O pobjedia, 2 = Nastavlja se igra
        int Status()
        {
            //-
            if (iData[0] != 0 && iData[0] == iData[1] && iData[1] == iData[2])
            {
                panelVodoravni.Location = new System.Drawing.Point(65, 200);
                panelVodoravni.Visible = true;
                return iData[0];
            }
            else if (iData[3] != 0 && iData[3] == iData[4] && iData[4] == iData[5])
            {
                panelVodoravni.Location = new System.Drawing.Point(65, 310);
                panelVodoravni.Visible = true;
                return iData[3];

            }
            else if (iData[6] != 0 && iData[6] == iData[7] && iData[7] == iData[8])
            {
                panelVodoravni.Location = new System.Drawing.Point(65, 415);
                panelVodoravni.Visible = true;
                return iData[6];
            }

            // |
            else if (iData[0] != 0 && iData[0] == iData[3] && iData[3] == iData[6])
            {
                panelUspravni.Location = new System.Drawing.Point(115, 145);
                panelUspravni.Visible = true;
                return iData[0];
            }
            else if (iData[1] != 0 && iData[1] == iData[4] && iData[4] == iData[7])
            {
                panelUspravni.Location = new System.Drawing.Point(220, 145);
                panelUspravni.Visible = true;
                return iData[1];
            }
            else if (iData[2] != 0 && iData[2] == iData[5] && iData[5] == iData[8])
            {
                panelUspravni.Location = new System.Drawing.Point(325, 145);
                panelUspravni.Visible = true;
                return iData[2];
            }
            // \
            else if (iData[0] != 0 && iData[0] == iData[4] && iData[4] == iData[8])
            {
                
                return iData[0];
            }
            // /
            else if (iData[2] != 0 && iData[2] == iData[4] && iData[4] == iData[6])
            {
                
                return iData[2];
            }

            else if (iData[0] != 0 && iData[1] != 0 && iData[2] != 0 && iData[3] != 0 && iData[4] != 0 && iData[5] != 0 && iData[6] != 0 && iData[7] != 0 && iData[8] != 0)
            {
                
                return 0;
            }

            return 2;
        }


        void RunBot()
        {
            //1= igraj protiv prijatelja 0=Game over
            if (iType == 1 || iTurn == 0)
                return;

            bEnableBot = true;
            CekajNSekunda(1);

            if (iType == 2)
            {
                RunLagani();
            }
            else if (iType == 3)
            {
                RunTeski();
            }
        }

        void RunLagani()
        {
            iLastMove = RandomPozicija();
            iData[iLastMove] = iTurn;
            ProminiSliku(iLastMove);
            bEnableBot = false;
            SljedeciPotez();
        }

        void RunTeski()
        {
            int iOpponent;
            if (iTurn == -1) iOpponent = 1;
            else iOpponent = -1;
            if (iLastMove == -1)
            {
                iLastMove = RandomPozicija();
            }
            else
            {
                Nepobjediv(iOpponent);
                Nepobjediv(iTurn);
                if (iData[iLastMove] != 0) iLastMove = RandomPozicija();
            }
            iData[iLastMove] = iTurn;
            ProminiSliku(iLastMove);
            bEnableBot = false;
            SljedeciPotez();
        }



        private void CekajNSekunda(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
        void SljedeciPotez()
        {
            int iGameStatus = Status();
            if (iGameStatus == 2)
            {
                if (iTurn == -1)
                {
                    iTurn = 1;
                    labelIgrac.Text = "𐩒 je na redu.";
                    panel1.Visible=false;
                    panel2.Visible=true;

                }
                else
                {
                    if (iType != 1 && iLastMove == -1)
                    {
                        iTurn = -1;
                        labelIgrac.Text = "Igrajte!";
                        panel1.Visible = true;
                        panel2.Visible = false;
                    }
                    else
                    {
                        iTurn = -1;
                        labelIgrac.Text = "🗙 je na redu.";
                        panel1.Visible = true;
                        panel2.Visible = false;
                    }
                }
            }
            else
            {
                if (iGameStatus == -1)
                {
                    rezultatX++;
                    buttonX.Text = "🗙                   " + rezultatX.ToString();
                }
                else if (iGameStatus == 1)
                {
                    rezultatO++;
                    buttonO.Text = "〇                   " + rezultatO.ToString();
                }
                else
                {

                }
                iTurn = 0;
                labelIgrac.Text = "Game Over";
            }
        }

        int RandomPozicija()
        {
            int brojac = 0;
            for (int i = 0; i < 9; i++)
            {
                if (iData[i] == 0) brojac++;
            }
            Random rnd = new Random();
            int iRandom = rnd.Next(1, brojac);

            brojac = 0;
            for (int i = 0; i < 9; i++)
            {
                if (iData[i] == 0)
                {
                    brojac++;
                    if (brojac == iRandom)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        
        void Nepobjediv(int potez)
        {
            if (iData[0] == 0 && ((iData[1] == potez && iData[2] == potez) || (iData[3] == potez && iData[6] == potez) || (iData[4] == potez && iData[8] == potez)))
                iLastMove = 0;
            else if (iData[1] == 0 && ((iData[0] == potez && iData[2] == potez) || (iData[4] == potez && iData[7] == potez)))
                iLastMove = 1;
            else if (iData[2] == 0 && ((iData[0] == potez && iData[1] == potez) || (iData[5] == potez && iData[8] == potez) || (iData[4] == potez && iData[6] == potez)))
                iLastMove = 2;
            else if (iData[3] == 0 && ((iData[0] == potez && iData[6] == potez) || (iData[4] == potez && iData[5] == potez)))
                iLastMove = 3;
            else if (iData[4] == 0 && ((iData[0] == potez && iData[8] == potez) || (iData[2] == potez && iData[6] == potez) || (iData[1] == potez && iData[7] == potez) || (iData[3] == potez && iData[5] == potez)))
                iLastMove = 4;
            else if (iData[5] == 0 && ((iData[2] == potez && iData[8] == potez) || (iData[3] == potez && iData[4] == potez)))
                iLastMove = 5;
            else if (iData[6] == 0 && ((iData[0] == potez && iData[3] == potez) || (iData[7] == potez && iData[8] == potez) || (iData[2] == potez && iData[4] == potez)))
                iLastMove = 6;
            else if (iData[7] == 0 && ((iData[1] == potez && iData[4] == potez) || (iData[6] == potez && iData[8] == potez)))
                iLastMove = 7;
            else if (iData[8] == 0 && ((iData[2] == potez && iData[5] == potez) || (iData[6] == potez && iData[7] == potez) || (iData[0] == potez && iData[4] == potez)))
                iLastMove = 8;
        }
        void ProminiSliku(int iPosition)
        {
            if (iData[iPosition] == -1)
            {
                switch (iPosition)
                {
                    case (0): polje1.Text = "🗙"; break;
                    case (1): polje2.Text = "🗙"; break;
                    case (2): polje3.Text = "🗙"; break;
                    case (3): polje4.Text = "🗙"; break;
                    case (4): polje5.Text = "🗙"; break;
                    case (5): polje6.Text = "🗙"; break;
                    case (6): polje7.Text = "🗙"; break;
                    case (7): polje8.Text = "🗙"; break;
                    case (8): polje9.Text = "🗙"; break;
                }
            }
            else if (iData[iPosition] == 1)
            {
                switch (iPosition)
                {
                    case (0): polje1.Text = "〇"; break;
                    case (1): polje2.Text = "〇"; break;
                    case (2): polje3.Text = "〇"; break;
                    case (3): polje4.Text = "〇"; break;
                    case (4): polje5.Text = "〇"; break;
                    case (5): polje6.Text = "〇"; break;
                    case (6): polje7.Text = "〇"; break;
                    case (7): polje8.Text = "〇"; break;
                    case (8): polje9.Text = "〇"; break;
                }
            }
            else
            {
                switch (iPosition)
                {
                    case (0): polje1.Text = null; break;
                    case (1): polje2.Text = null; break;
                    case (2): polje3.Text = null; break;
                    case (3): polje4.Text = null; break;
                    case (4): polje5.Text = null; break;
                    case (5): polje6.Text = null; break;
                    case (6): polje7.Text = null; break;
                    case (7): polje8.Text = null; break;
                    case (8): polje9.Text = null; break;
                }
            }
        }

    }
    }

