using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biorhythmus
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
        }
        private void LoginRegister_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Load += LoginRegister_Load;
            if (Properties.Settings.Default.Login.Contains(tbBenutzername.Text + "," + tbPasswort.Text))
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Falscher Benutzername oder falsches Passwort!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Registrieren_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.Login.Add(tbBenutzername.Text + "," + tbPasswort.Text);

            Properties.Settings.Default.Save();
        }

        private void btLöschen_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Login.Clear();
        }
    }
}
