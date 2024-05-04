using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biorhythmus
{
    public class Kondition
    {
        private int tageSeitGeburt;
        public int getTageSeitGeburt() 
        { 
            return tageSeitGeburt; 
        }
        public void setTageSeitGeburt(int tageSeitGeburt) { this.tageSeitGeburt = tageSeitGeburt; }
        //---------------------------------------------------------------------
        public double berechneKonditionKoerperlich(int tageSeitHeute)
        {
            int koerperlicherRhythmus = 23;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageSeitGeburt + tageSeitHeute) / koerperlicherRhythmus));
        }
        //--------------------------------------------------------------------- 
        public double berechneKonditionGeistig(int tageSeitHeute)
        {
            int geistigerRhythmus = 33;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageSeitGeburt + tageSeitHeute) /
            geistigerRhythmus));
        }
        //---------------------------------------------------------------------
        public double berechneKonditionPsychisch(int tageSeitHeute)
        {
            int psychischerRythmus = 28;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageSeitGeburt + tageSeitHeute) /
            psychischerRythmus));
        }
        //---------------------------------------------------------------------
        public String erzeugeKonditionPrognose_14Tage()
        {
            String prognose_14Tage = "";
            for (int t = 1; t <= 14; t++)
            {
                prognose_14Tage = prognose_14Tage +
                " " + t + " \t" +
                Math.Round(berechneKonditionKoerperlich(t), 0) + " \t\t" +
                Math.Round(berechneKonditionGeistig(t), 0) + " \t\t" +
                Math.Round(berechneKonditionPsychisch(t), 0) + "\n";
            }
            return prognose_14Tage;
        }
        //-----------------------------------------------------------------------------------------------
        public void zeichneKonditionPrognose_60Tage(Graphics g)
        {
            int koerperlich_1, geistig_1, psychisch_1;
            int koerperlich_2, geistig_2, psychisch_2;
            Pen penBlue = new Pen(Color.Blue);
            Pen penRed = new Pen(Color.Red);
            Pen penGreen = new Pen(Color.Green);
            Pen penBlack = new Pen(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            g.FillRectangle(whiteBrush, 0, 0, 240, 127);
            g.DrawLine(penBlack, 0, 110, 240, 110);
            g.DrawString("0", new Font("Arial", 12), new SolidBrush(Color.Black), 2, 124);
            g.DrawString("30", new Font("Arial", 12), new SolidBrush(Color.Black), 115, 124);
            g.DrawString("Tage", new Font("Arial", 12), new SolidBrush(Color.Black), 212, 124);
            for (int t = 0; t <= 59; t++)
            {
                koerperlich_1 = (int)(110 - berechneKonditionKoerperlich(t));
                geistig_1 = (int)(110 - berechneKonditionGeistig(t));
                psychisch_1 = (int)(110 - berechneKonditionPsychisch(t));
                koerperlich_2 = (int)(110 - berechneKonditionKoerperlich(t + 1));
                geistig_2 = (int)(110 - berechneKonditionGeistig(t + 1));
                psychisch_2 = (int)(110 - berechneKonditionPsychisch(t + 1));
                g.DrawLine(penBlue, 4 * t, koerperlich_1, 4 * (t + 1), koerperlich_2);
                g.DrawLine(penRed, 4 * t, geistig_1, 4 * (t + 1), geistig_2);
                g.DrawLine(penGreen, 4 * t, psychisch_1, 4 * (t + 1), psychisch_2);
            }
        }
    }
}
