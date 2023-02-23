namespace EsDnevnik2022
{
    partial class Osoba
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbJBG = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btFirst = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btUnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(159, 115);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(100, 20);
            this.tbIme.TabIndex = 1;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(159, 164);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbPrezime.TabIndex = 2;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(159, 213);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(100, 20);
            this.tbAdresa.TabIndex = 3;
            // 
            // tbJMBG
            // 
            this.tbJMBG.Location = new System.Drawing.Point(159, 262);
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.Size = new System.Drawing.Size(100, 20);
            this.tbJMBG.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(159, 311);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(51, 115);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(27, 13);
            this.lbIme.TabIndex = 7;
            this.lbIme.Text = "Ime:";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(51, 164);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(47, 13);
            this.lbPrezime.TabIndex = 8;
            this.lbPrezime.Text = "Prezime:";
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(51, 213);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(43, 13);
            this.lbAdresa.TabIndex = 9;
            this.lbAdresa.Text = "Adresa:";
            // 
            // lbJBG
            // 
            this.lbJBG.AutoSize = true;
            this.lbJBG.Location = new System.Drawing.Point(54, 262);
            this.lbJBG.Name = "lbJBG";
            this.lbJBG.Size = new System.Drawing.Size(39, 13);
            this.lbJBG.TabIndex = 10;
            this.lbJBG.Text = "JMBG:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(54, 311);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "E-mail";
            // 
            // btFirst
            // 
            this.btFirst.Location = new System.Drawing.Point(159, 366);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(75, 23);
            this.btFirst.TabIndex = 12;
            this.btFirst.Text = "<<";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(247, 367);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(75, 23);
            this.btPrev.TabIndex = 13;
            this.btPrev.Text = "<";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(440, 366);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 14;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btLast
            // 
            this.btLast.Location = new System.Drawing.Point(521, 366);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(75, 23);
            this.btLast.TabIndex = 15;
            this.btLast.Text = ">>";
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // cbID
            // 
            this.cbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(369, 367);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(42, 21);
            this.cbID.TabIndex = 16;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(440, 311);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btIzmeni.TabIndex = 17;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btUnesi
            // 
            this.btUnesi.Location = new System.Drawing.Point(521, 311);
            this.btUnesi.Name = "btUnesi";
            this.btUnesi.Size = new System.Drawing.Size(75, 23);
            this.btUnesi.TabIndex = 18;
            this.btUnesi.Text = "Unesi";
            this.btUnesi.UseVisualStyleBackColor = true;
            this.btUnesi.Click += new System.EventHandler(this.btUnesi_Click);
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btUnesi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbJBG);
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.lbPrezime);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbJMBG);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Name = "Osoba";
            this.Text = "EsDnevnik";
            this.Load += new System.EventHandler(this.Osoba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label lbJBG;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btUnesi;
    }
}

