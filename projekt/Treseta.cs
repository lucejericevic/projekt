using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace projekt
{
    public partial class Treseta : Form
    {
        public Treseta()
        {
            InitializeComponent();
        }

        // file.txt !! C:/Users/Documents/file.txt !! /files/file.txt !! ../../slike/file.txt

        public Stanje StanjeIgre;
        public string odgovor = "";

        private void na_promjenu(object sender, FileSystemEventArgs e) 
        {

            
            odgovor = e.FullPath;
            StreamReader rd = new StreamReader(odgovor);
            string line;
            line = rd.ReadLine();
            int broj = int.Parse(line);

            igranje_karte( broj, false );

        }

        private void cekanje_racunala()
        {
            string a = "";


           var watcher = new FileSystemWatcher("../../ResourcesTreseta/");

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += na_promjenu;


            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;


            odgovor = "";

        }

        private void igranje_karte( int broj, bool igrac  )
        {


                
            if (StanjeIgre.igracprvi == igrac  && !StanjeIgre.odigrano)
            {
                MessageBox.Show(broj.ToString());
                if( igrac)
                {

                    StanjeIgre.donja_na_stolu = StanjeIgre.igrac[broj - 1];
                    Karta kopija = StanjeIgre.igrac[ StanjeIgre.igrac.Count - 1];
                    StanjeIgre.igrac.RemoveAt( StanjeIgre.igrac.Count - 1);
                    if (broj - 1 != StanjeIgre.igrac.Count)
                    {
                        StanjeIgre.igrac[broj - 1] = kopija;

                    }
                    ((PictureBox)this.Controls.Find("igrac" + (StanjeIgre.igrac.Count + 1).ToString(), true)[0]).Image = null;

                }
                else
                {

                    StanjeIgre.donja_na_stolu = StanjeIgre.racunalo[broj - 1];
                    Karta kopija = StanjeIgre.racunalo[StanjeIgre.racunalo.Count - 1];
                    StanjeIgre.racunalo.RemoveAt( StanjeIgre.racunalo.Count - 1 );
                    if (broj - 1 != StanjeIgre.racunalo.Count)
                    {
                        StanjeIgre.racunalo[broj - 1] = kopija;

                    }
                    ((PictureBox)this.Controls.Find("ai" + ( StanjeIgre.racunalo.Count + 1 ).ToString(), true)[0]).Image = null;

                }
                StanjeIgre.odigrano = true;
                azuriraj_stanje( StanjeIgre );



            }


        }
        //"C:\Users\Frane\source\repos\lucejericevic\projekt\projekt\ResourcesTreseta\gornjabacena.png"
        private void azuriraj_stanje(Stanje stanje)
        {
            Console.WriteLine(stanje.racunalo[0].pathSlika);

            int k = stanje.racunalo.Count > stanje.igrac.Count ? stanje.igrac.Count : stanje.racunalo.Count;

            for (int i = 0; i < k ; i++)
            {

                ((PictureBox)this.Controls.Find("igrac" + (i + 1).ToString(), true)[0]).ImageLocation = stanje.igrac[i].pathSlika;
                ((PictureBox)this.Controls.Find("ai" + (i + 1).ToString(), true)[0]).ImageLocation = stanje.racunalo[i].pathSlika;

            }



            //aiBacena - ai bacena; igracBacena - igrac bacena


            donjaBacena.ImageLocation = stanje.donja_na_stolu.pathSlika != null ? stanje.donja_na_stolu.pathSlika : "../../ResourcesTreseta/donjabacena.png";
            gornjaBacena.ImageLocation = stanje.gornja_na_stolu.pathSlika != null ? stanje.gornja_na_stolu.pathSlika : "../../ResourcesTreseta/gornjabacena.png";


            if ( stanje.spil.spil.Count() == 0 )
            {
                pbSpil.Image = null;
            }


        }


        public bool provjeri_zog( string zog, Karta bacenakarta)
        {


            if ( bacenakarta.Zog == zog )
            {
                    return true;

            }
            else
            {

                foreach ( var x in StanjeIgre.igrac )
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



        private void btnIgraj_Click(object sender, EventArgs e)
        {

            StanjeIgre = new Stanje();
            azuriraj_stanje(StanjeIgre);
            cekanje_racunala();

        }

        private void igrac1_Click(object sender, EventArgs e)
        {

            igranje_karte( 1, true );
             
        }

        private void igrac2_Click(object sender, EventArgs e)
        {
            igranje_karte(2, true);
        }

        private void igrac3_Click(object sender, EventArgs e)
        {
            igranje_karte(3, true);
        }

        private void igrac4_Click(object sender, EventArgs e)
        {
            igranje_karte(4, true);
        }

        private void igrac5_Click(object sender, EventArgs e)
        {
            igranje_karte(5, true);
        }

        private void igrac6_Click(object sender, EventArgs e)
        {
            igranje_karte(6, true);
        }

        private void igrac7_Click(object sender, EventArgs e)
        {
            igranje_karte(7, true);
        }

        private void igrac8_Click(object sender, EventArgs e)
        {
            igranje_karte(8, true);
        }

        private void igrac9_Click(object sender, EventArgs e)
        {
            igranje_karte(9, true);
        }

        private void igrac10_Click(object sender, EventArgs e)
        {

            igranje_karte(10, true);
        }

        private void Treseta_Load(object sender, EventArgs e)
        {

            StanjeIgre = new Stanje();
            azuriraj_stanje( StanjeIgre );

        }
    }

     
}
