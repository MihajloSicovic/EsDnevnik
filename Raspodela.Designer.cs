namespace EsDnevnik2022
{
    partial class Raspodela
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
            this.cbID = new System.Windows.Forms.ComboBox();
            this.btBrisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btFirst = new System.Windows.Forms.Button();
            this.lbJBG = new System.Windows.Forms.Label();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.cbNastavnik = new System.Windows.Forms.ComboBox();
            this.cbPredmet = new System.Windows.Forms.ComboBox();
            this.cbOdeljenje = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbID
            // 
            this.cbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(450, 55);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(241, 24);
            this.cbID.TabIndex = 49;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(591, 466);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(100, 34);
            this.btBrisi.TabIndex = 48;
            this.btBrisi.Text = "Brisi";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "ID:";
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(484, 466);
            this.btDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(100, 34);
            this.btDodaj.TabIndex = 42;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(376, 466);
            this.btIzmeni.Margin = new System.Windows.Forms.Padding(4);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(100, 34);
            this.btIzmeni.TabIndex = 41;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btLast
            // 
            this.btLast.Location = new System.Drawing.Point(864, 466);
            this.btLast.Margin = new System.Windows.Forms.Padding(4);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(100, 34);
            this.btLast.TabIndex = 40;
            this.btLast.Text = ">>";
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(756, 466);
            this.btNext.Margin = new System.Windows.Forms.Padding(4);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(100, 34);
            this.btNext.TabIndex = 39;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(210, 466);
            this.btPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(100, 34);
            this.btPrev.TabIndex = 38;
            this.btPrev.Text = "<";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btFirst
            // 
            this.btFirst.Location = new System.Drawing.Point(102, 466);
            this.btFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(100, 34);
            this.btFirst.TabIndex = 37;
            this.btFirst.Text = "<<";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // lbJBG
            // 
            this.lbJBG.AutoSize = true;
            this.lbJBG.Location = new System.Drawing.Point(375, 242);
            this.lbJBG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJBG.Name = "lbJBG";
            this.lbJBG.Size = new System.Drawing.Size(68, 16);
            this.lbJBG.TabIndex = 35;
            this.lbJBG.Text = "Odeljenje:";
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(373, 196);
            this.lbAdresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(61, 16);
            this.lbAdresa.TabIndex = 34;
            this.lbAdresa.Text = "Predmet:";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(373, 104);
            this.lbPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(70, 16);
            this.lbPrezime.TabIndex = 33;
            this.lbPrezime.Text = "Nastavnik:";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(373, 150);
            this.lbIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(54, 16);
            this.lbIme.TabIndex = 32;
            this.lbIme.Text = "Godina:";
            // 
            // cbGodina
            // 
            this.cbGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGodina.FormattingEnabled = true;
            this.cbGodina.Location = new System.Drawing.Point(450, 147);
            this.cbGodina.Name = "cbGodina";
            this.cbGodina.Size = new System.Drawing.Size(241, 24);
            this.cbGodina.TabIndex = 50;
            // 
            // cbNastavnik
            // 
            this.cbNastavnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNastavnik.FormattingEnabled = true;
            this.cbNastavnik.Location = new System.Drawing.Point(450, 101);
            this.cbNastavnik.Name = "cbNastavnik";
            this.cbNastavnik.Size = new System.Drawing.Size(241, 24);
            this.cbNastavnik.TabIndex = 51;
            // 
            // cbPredmet
            // 
            this.cbPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.Location = new System.Drawing.Point(450, 193);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(241, 24);
            this.cbPredmet.TabIndex = 52;
            // 
            // cbOdeljenje
            // 
            this.cbOdeljenje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdeljenje.FormattingEnabled = true;
            this.cbOdeljenje.Location = new System.Drawing.Point(450, 239);
            this.cbOdeljenje.Name = "cbOdeljenje";
            this.cbOdeljenje.Size = new System.Drawing.Size(241, 24);
            this.cbOdeljenje.TabIndex = 53;
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbOdeljenje);
            this.Controls.Add(this.cbPredmet);
            this.Controls.Add(this.cbNastavnik);
            this.Controls.Add(this.cbGodina);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.lbJBG);
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.lbPrezime);
            this.Controls.Add(this.lbIme);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Label lbJBG;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.ComboBox cbGodina;
        private System.Windows.Forms.ComboBox cbNastavnik;
        private System.Windows.Forms.ComboBox cbPredmet;
        private System.Windows.Forms.ComboBox cbOdeljenje;
    }
}