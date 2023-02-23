using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsDnevnik2022
{
    public partial class Glavna : Form
    {
        Login l;
        public Glavna(Login l)
        {
            this.l = l;
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba nova = new Osoba();
            nova.ShowDialog();
        }

        private void odeljenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odeljenje nova = new Odeljenje();
            nova.ShowDialog();
        }

        private void smerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik FormaSifarnik = new Sifarnik("smer");
            FormaSifarnik.Show();
        }

        private void skolskaGodinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik FormaSifarnik = new Sifarnik("skolska_godina");
            FormaSifarnik.Show();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            l.Close();
        }

        private void ocene2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocena FormaOcena = new Ocena();
            FormaOcena.Show();
        }
    }
}
