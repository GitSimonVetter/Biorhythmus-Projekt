namespace Biorhythmus
{
    partial class LoginRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegister));
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegistrieren = new System.Windows.Forms.Button();
            this.tbBenutzername = new System.Windows.Forms.TextBox();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.btLöschen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(129, 209);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // btRegistrieren
            // 
            this.btRegistrieren.BackColor = System.Drawing.SystemColors.Control;
            this.btRegistrieren.Location = new System.Drawing.Point(260, 209);
            this.btRegistrieren.Name = "btRegistrieren";
            this.btRegistrieren.Size = new System.Drawing.Size(75, 23);
            this.btRegistrieren.TabIndex = 1;
            this.btRegistrieren.Text = "Registrieren";
            this.btRegistrieren.UseVisualStyleBackColor = false;
            this.btRegistrieren.Click += new System.EventHandler(this.Registrieren_Click);
            // 
            // tbBenutzername
            // 
            this.tbBenutzername.Location = new System.Drawing.Point(185, 102);
            this.tbBenutzername.Name = "tbBenutzername";
            this.tbBenutzername.Size = new System.Drawing.Size(100, 20);
            this.tbBenutzername.TabIndex = 2;
            // 
            // tbPasswort
            // 
            this.tbPasswort.Location = new System.Drawing.Point(185, 151);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.PasswordChar = '*';
            this.tbPasswort.Size = new System.Drawing.Size(100, 20);
            this.tbPasswort.TabIndex = 3;
            // 
            // btLöschen
            // 
            this.btLöschen.Location = new System.Drawing.Point(196, 252);
            this.btLöschen.Name = "btLöschen";
            this.btLöschen.Size = new System.Drawing.Size(75, 23);
            this.btLöschen.TabIndex = 4;
            this.btLöschen.Text = "Löschen";
            this.btLöschen.UseVisualStyleBackColor = true;
            this.btLöschen.Click += new System.EventHandler(this.btLöschen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passwort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login/Registrieren";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-328, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 436);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLöschen);
            this.Controls.Add(this.tbPasswort);
            this.Controls.Add(this.tbBenutzername);
            this.Controls.Add(this.btRegistrieren);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginRegister";
            this.Text = "LoginRegister";
            this.Load += new System.EventHandler(this.LoginRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegistrieren;
        private System.Windows.Forms.TextBox tbBenutzername;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.Button btLöschen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}