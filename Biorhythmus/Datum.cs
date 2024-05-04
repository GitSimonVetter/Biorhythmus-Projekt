using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biorhythmus
{
    public class Datum
    {
        private int tag;
        public int getTag() 
        { 
            return tag; 
        }
        public void setTag(int tag) 
        { 
            this.tag = tag; 
        }
        //--------------------------------------------------------------
        private int monat;
        public int getMonat() 
        { 
            return monat; 
        }
        public void setMonat(int monat) 
        { 
            this.monat = monat; 
        }
        //--------------------------------------------------------------
        private int jahr;
        public int getJahr() 
        { 
            return jahr; 
        }
        public void setJahr(int jahr) 
        { 
            this.jahr = jahr; 
        }
        //--------------------------------------------------------------
        public void setDatumAufHeute()
        {
            GregorianCalendar heute = new GregorianCalendar();
            tag = heute.GetDayOfMonth(DateTime.Today);
            monat = heute.GetMonth(DateTime.Today);
            jahr = heute.GetYear(DateTime.Today);
        }
        //--------------------------------------------------------------
        public bool pruefeObSchaltjahr(int jahr)
        {
            return ((jahr % 4 == 0) && (jahr % 100 != 0)) || (jahr % 400 == 0);
        }
        //-------------------------------------------------------------------
        public int ermittleMonatstage(int monat)
        {
            int tage;
            switch (monat)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: tage = 31; break;
                case 4:
                case 6:
                case 9:
                case 11: tage = 30; break;
                case 2:
                    if (pruefeObSchaltjahr(jahr)) tage = 29;
                    else tage = 28; break;
                default: tage = 0; break;
            }
            return tage;
        }
        //----------------------------------------------------------------------
        public int berechneAnzahlSchaltjahre(Datum datumAlt)
        {
            int anzahl = 0;
            for (int j = datumAlt.getJahr(); j < jahr; j++)
                if (pruefeObSchaltjahr(j)) anzahl++;
            return anzahl;
        }
        //-------------------------------------------------------------------------------------
        public int berechneTageSeitJahresbeginn()
        {
            int tage = tag;
            for (int m = 1; m < monat; m++)
                tage = tage + ermittleMonatstage(m);
            return tage;
        }
        //-------------------------------------------------------------------------------------
        public int berechneTageDifferenz(Datum datumAlt)
        {
            return (jahr - datumAlt.getJahr()) * 365
            + berechneAnzahlSchaltjahre(datumAlt)
           - datumAlt.berechneTageSeitJahresbeginn()
           + berechneTageSeitJahresbeginn();
        }

    }
}
