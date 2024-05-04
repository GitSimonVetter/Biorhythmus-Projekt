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
using System.Globalization;

namespace Biorhythmus
{
    public partial class Form1 : Form
    {
        Musik musik = new Musik();
        Datum heuteDatum = new Datum();
        Datum gebDatum = new Datum();
        Kondition pKondition = new Kondition();
        public Form1()
        {
            InitializeComponent();
        }


        public void btVerarbeiten_Click(object sender, EventArgs e)
        {

            GregorianCalendar heute = new GregorianCalendar();
            try
            {
                if (tbTag.Text == "0" || tbMonat.Text == "0" || tbJahr.Text == "0" || tbTag.Text.Length == 0 || tbMonat.Text.Length == 0 || tbJahr.Text.Length == 0 || Convert.ToInt32(tbTag.Text) > heuteDatum.ermittleMonatstage(Convert.ToInt32(tbMonat.Text)) || Convert.ToInt32(tbMonat.Text) > 12 || Convert.ToInt32(tbJahr.Text) > heute.GetYear(DateTime.Today))
                {
                    string message = "Keine Eingabe ";
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                    return;
                }

            
                gebDatum.setTag(Convert.ToInt32(tbTag.Text));
                gebDatum.setMonat(Convert.ToInt32(tbMonat.Text));
                gebDatum.setJahr(Convert.ToInt32(tbJahr.Text));

                heuteDatum.setDatumAufHeute();

                pKondition.setTageSeitGeburt(heuteDatum.berechneTageDifferenz(gebDatum));

                lbTagesdatum.Text = (heuteDatum.getTag() + "." + heuteDatum.getMonat() + "." + heuteDatum.getJahr());
                lbTageSeitGeburt.Text = Convert.ToString(pKondition.getTageSeitGeburt());
                lbKoerperlich.Text = Math.Round(pKondition.berechneKonditionKoerperlich(0), 2) + "%";
                lbGeistig.Text = Math.Round(pKondition.berechneKonditionGeistig(0), 2) + "%";
                lbPsychisch.Text = Math.Round(pKondition.berechneKonditionPsychisch(0), 2) + "%";
                rtbPrognose14Tage.Text = pKondition.erzeugeKonditionPrognose_14Tage();

                pKondition.zeichneKonditionPrognose_60Tage(pnPrognose60Tage.CreateGraphics());
            
            } catch (Exception ) { };


        }
            //--------------------------------------------------------------
            private void btDarkMode_Click(object sender, EventArgs e)
            {
                Kondition pKondition = new Kondition();
                if (this.BackColor == Color.FromArgb(30, 30, 30))
                {
                    this.BackColor = Color.LightGray;


                    lbGeistig.ForeColor = Color.Black;
                    lbKoerperlich.ForeColor = Color.Black;
                    lbPsychisch.ForeColor = Color.Black;
                    lbTagesdatum.ForeColor = Color.Black;
                    lbTageSeitGeburt.ForeColor = Color.Black;
                    lbTageskondition.ForeColor = Color.Black;
                    label.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    label8.BackColor = Color.LightGray;
                    rtbPrognose14Tage.BackColor = Color.White;

                }
                else
                {
                    this.BackColor = Color.FromArgb(30, 30, 30);


                    lbGeistig.ForeColor = Color.LightGray;
                    lbKoerperlich.ForeColor = Color.LightGray;
                    lbPsychisch.ForeColor = Color.LightGray;
                    lbTagesdatum.ForeColor = Color.LightGray;
                    lbTageSeitGeburt.ForeColor = Color.LightGray;
                    lbTageskondition.ForeColor = Color.LightGray;
                    label.ForeColor = Color.LightGray;
                    label1.ForeColor = Color.LightGray;
                    label10.ForeColor = Color.LightGray;
                    label2.ForeColor = Color.LightGray;
                    label3.ForeColor = Color.LightGray;
                    label4.ForeColor = Color.LightGray;
                    label5.ForeColor = Color.LightGray;
                    label7.ForeColor = Color.LightGray;
                    label8.ForeColor = Color.LightGray;
                    label8.BackColor = Color.FromArgb(30, 30, 30);
                    rtbPrognose14Tage.BackColor = Color.White;

                }
                pKondition.zeichneKonditionPrognose_60Tage(pnPrognose60Tage.CreateGraphics());
            }

            //--------------------------------------------------------------
            private void btSpeichern_Click(object sender, EventArgs e)
            {
                if (tbTag.Text == "0" || tbMonat.Text == "0" || tbJahr.Text == "0" || tbTag.Text.Length == 0 || tbMonat.Text.Length == 0 || tbJahr.Text.Length == 0)
                {
                    MessageBox.Show("ERROR \nkeine gültige Eingabe");


                }
                else
                {
                    string[] index = new string[3];
                    index[0] = tbTag.Text;
                    index[1] = tbMonat.Text;
                    index[2] = tbJahr.Text;
                    SpeichernLaden.speichern(index);
                }
            }
            //--------------------------------------------------------------

            private void btLaden_Click(object sender, EventArgs e)
            {
                string[] liste = SpeichernLaden.laden();
                tbTag.Text = liste[0];
                tbMonat.Text = liste[1];
                tbJahr.Text = liste[2];
                MessageBox.Show("Importiert\n" + liste[0] + "." + liste[1] + "." + liste[2]);

            }
            //--------------------------------------------------------------

            public void cbMusikauswahl_Geändert(object sender, EventArgs e)
            {
                int selectedIndex = cbMusikauswahl.SelectedIndex;
                Object selectedItem = cbMusikauswahl.SelectedItem;
                MessageBox.Show("Spielt jetzt: " + selectedItem.ToString());
                musik.setMusikauswahl(selectedIndex);
                musik.stoppeMusik();
                btMusikUmschalten.Text = "Music An";





            }
            //--------------------------------------------------------------

            public void btMusikUmschalten_Click(object sender, EventArgs e)
            {
                musik.checkMusikauswahl();
                if (musik.checkMusikStatus())
                {
                    musik.stoppeMusik();
                    btMusikUmschalten.Text = "Musik An";

                }
                else
                {
                    musik.spieleMusik();
                    btMusikUmschalten.Text = "Musik Aus";
                }
            }

        }
    }
   


