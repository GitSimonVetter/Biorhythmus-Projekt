using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;
using System.Security.Cryptography.X509Certificates;

namespace Biorhythmus
{
    public class Musik
    {
        SoundPlayer spieler0;
        SoundPlayer spieler1;
        SoundPlayer spieler2;
        SoundPlayer spieler3;
        SoundPlayer spieler4;

        bool MusikStatus = false;
        int Musikauswahl;
 
        public int checkMusikauswahl()
        {
            return Musikauswahl;
        }
        //--------------------------------------------------------------
        public void setMusikauswahl(int Musikauswahl)
        {
            this.Musikauswahl = Musikauswahl;
        }
        //--------------------------------------------------------------

        public void spieleMusik()
        {
            if (Musikauswahl == 0)
            {
                spieler0.PlayLooping();
            }
            else if (Musikauswahl == 1)
            {
                spieler1.PlayLooping();
            }
            else if ( Musikauswahl == 2)
            {
                spieler2.PlayLooping();
            }
            else if (Musikauswahl == 3)
            {
                spieler3.PlayLooping();
            }
            else if (Musikauswahl == 4)
            {
                spieler4.PlayLooping();
            }

            MusikStatus = true;
        }
        //--------------------------------------------------------------
        public void stoppeMusik()
        {
            spieler0.Stop();
            spieler1.Stop();
            spieler2.Stop();
            spieler3.Stop();
            spieler4.Stop();
            MusikStatus = false;
        }
        //--------------------------------------------------------------
        public bool checkMusikStatus()
        {
            return MusikStatus;
        }
        //--------------------------------------------------------------

        public Musik()
        {
            spieler0 = new SoundPlayer(Application.StartupPath + @"\0.wav");
            spieler1 = new SoundPlayer(Application.StartupPath + @"\1.wav");
            spieler2 = new SoundPlayer(Application.StartupPath + @"\2.wav");
            spieler3 = new SoundPlayer(Application.StartupPath + @"\3.wav");
            spieler4 = new SoundPlayer(Application.StartupPath + @"\4.wav");


        }
    }
}
