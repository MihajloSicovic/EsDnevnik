namespace EsDnevnik2022
{
    partial class Ocena
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUcenik = new System.Windows.Forms.ComboBox();
            this.cbPredmet = new System.Windows.Forms.ComboBox();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btPromeni = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.dgOcena = new System.Windows.Forms.DataGridView();
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.cbOdeljenje = new System.Windows.Forms.ComboBox();
            this.ndOcena = new System.Windows.Forms.NumericUpDown();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOcena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndOcena)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ucenik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Predmet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ocena:";
            // 
            // cbUcenik
            // 
            this.cbUcenik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUcenik.Enabled = false;
            this.cbUcenik.FormattingEnabled = true;
            this.cbUcenik.Location = new System.Drawing.Point(103, 118);
            this.cbUcenik.Margin = new System.Windows.Forms.Padding(4);
            this.cbUcenik.Name = "cbUcenik";
            this.cbUcenik.Size = new System.Drawing.Size(160, 24);
            this.cbUcenik.TabIndex = 4;
            // 
            // cbPredmet
            // 
            this.cbPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPredmet.Enabled = false;
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.Location = new System.Drawing.Point(511, 53);
            this.cbPredmet.Margin = new System.Windows.Forms.Padding(4);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(157, 24);
            this.cbPredmet.TabIndex = 5;
            this.cbPredmet.SelectedValueChanged += new System.EventHandler(this.cbPredmet_SelectedValueChanged);
            this.cbPredmet.TextChanged += new System.EventHandler(this.cbPredmet_TextChanged);
            // 
            // btDodaj
            // 
            this.btDodaj.Enabled = false;
            this.btDodaj.Location = new System.Drawing.Point(201, 186);
            this.btDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(139, 38);
            this.btDodaj.TabIndex = 6;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btPromeni
            // 
            this.btPromeni.Enabled = false;
            this.btPromeni.Location = new System.Drawing.Point(405, 186);
            this.btPromeni.Margin = new System.Windows.Forms.Padding(4);
            this.btPromeni.Name = "btPromeni";
            this.btPromeni.Size = new System.Drawing.Size(139, 38);
            this.btPromeni.TabIndex = 7;
            this.btPromeni.Text = "Promeni";
            this.btPromeni.UseVisualStyleBackColor = true;
            this.btPromeni.Click += new System.EventHandler(this.btPromeni_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Enabled = false;
            this.btBrisi.Location = new System.Drawing.Point(611, 186);
            this.btBrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(139, 38);
            this.btBrisi.TabIndex = 8;
            this.btBrisi.Text = "Brisi";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // dgOcena
            // 
            this.dgOcena.AllowUserToAddRows = false;
            this.dgOcena.AllowUserToDeleteRows = false;
            this.dgOcena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOcena.Location = new System.Drawing.Point(201, 263);
            this.dgOcena.Margin = new System.Windows.Forms.Padding(4);
            this.dgOcena.MultiSelect = false;
            this.dgOcena.Name = "dgOcena";
            this.dgOcena.ReadOnly = true;
            this.dgOcena.RowHeadersVisible = false;
            this.dgOcena.RowHeadersWidth = 51;
            this.dgOcena.Size = new System.Drawing.Size(548, 254);
            this.dgOcena.TabIndex = 9;
            this.dgOcena.CurrentCellChanged += new System.EventHandler(this.dgOcena_CurrentCellChanged);
            // 
            // cbGodina
            // 
            this.cbGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGodina.FormattingEnabled = true;
            this.cbGodina.Location = new System.Drawing.Point(103, 53);
            this.cbGodina.Margin = new System.Windows.Forms.Padding(4);
            this.cbGodina.Name = "cbGodina";
            this.cbGodina.Size = new System.Drawing.Size(160, 24);
            this.cbGodina.TabIndex = 10;
            this.cbGodina.SelectedValueChanged += new System.EventHandler(this.cbGodina_SelectedValueChanged);
            // 
            // cbProfesor
            // 
            this.cbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(307, 53);
            this.cbProfesor.Margin = new System.Windows.Forms.Padding(4);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(160, 24);
            this.cbProfesor.TabIndex = 11;
            this.cbProfesor.SelectedValueChanged += new System.EventHandler(this.cbProfesor_SelectedValueChanged);
            this.cbProfesor.TextChanged += new System.EventHandler(this.cbProfesor_TextChanged);
            // 
            // cbOdeljenje
            // 
            this.cbOdeljenje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdeljenje.Enabled = false;
            this.cbOdeljenje.FormattingEnabled = true;
            this.cbOdeljenje.Location = new System.Drawing.Point(712, 53);
            this.cbOdeljenje.Margin = new System.Windows.Forms.Padding(4);
            this.cbOdeljenje.Name = "cbOdeljenje";
            this.cbOdeljenje.Size = new System.Drawing.Size(160, 24);
            this.cbOdeljenje.TabIndex = 13;
            this.cbOdeljenje.SelectedValueChanged += new System.EventHandler(this.cbOdeljenje_SelectedValueChanged);
            this.cbOdeljenje.TextChanged += new System.EventHandler(this.cbOdeljenje_TextChanged);
            // 
            // ndOcena
            // 
            this.ndOcena.Enabled = false;
            this.ndOcena.Location = new System.Drawing.Point(307, 119);
            this.ndOcena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ndOcena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndOcena.Name = "ndOcena";
            this.ndOcena.ReadOnly = true;
            this.ndOcena.Size = new System.Drawing.Size(160, 22);
            this.ndOcena.TabIndex = 14;
            this.ndOcena.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dtDatum
            // 
            this.dtDatum.Enabled = false;
            this.dtDatum.Location = new System.Drawing.Point(511, 119);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(157, 22);
            this.dtDatum.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Godina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Profesor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Datum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Odeljenje:";
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.ndOcena);
            this.Controls.Add(this.cbOdeljenje);
            this.Controls.Add(this.cbProfesor);
            this.Controls.Add(this.cbGodina);
            this.Controls.Add(this.dgOcena);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.btPromeni);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.cbPredmet);
            this.Controls.Add(this.cbUcenik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOcena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndOcena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUcenik;
        private System.Windows.Forms.ComboBox cbPredmet;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btPromeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.DataGridView dgOcena;
        private System.Windows.Forms.ComboBox cbGodina;
        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.ComboBox cbOdeljenje;
        private System.Windows.Forms.NumericUpDown ndOcena;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}