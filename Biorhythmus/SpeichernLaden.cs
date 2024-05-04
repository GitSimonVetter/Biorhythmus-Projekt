using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biorhythmus
{
    public class SpeichernLaden
    {
        private static string speicherort = Application.StartupPath + @"\BiorythmusSafe.txt";
        public static void speichern(string[] BiorythmusText)
        {
            if (File.Exists(speicherort) == false)
            {
                File.Create(speicherort);
            }
            File.WriteAllLines(speicherort, BiorythmusText);
        }
        //--------------------------------------------------------------

        public static string[] laden()
        {
            if (File.Exists(speicherort) == false)
            {
                File.Create(speicherort);
            }  
            return File.ReadAllLines(speicherort);
        }
    }
}
