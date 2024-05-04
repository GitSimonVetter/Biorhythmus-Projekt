using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biorhythmus
{
    public class Drucken
    {

        PrintDocument printDocument = new PrintDocument();
        string text;
        public Drucken()
        {
            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        //--------------------------------------------------------------

        // Sagt wie der Text aussehen soll
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(text, new Font("Microsoft Sans Serif", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }
        //--------------------------------------------------------------

        public void drucken(string inhalt)
        {
            text = inhalt;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = printDocument;
            if (ppd.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
