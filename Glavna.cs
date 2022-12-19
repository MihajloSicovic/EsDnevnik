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
        public Glavna()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba();
            osoba.ShowDialog();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspodela raspodela = new Raspodela();
            raspodela.ShowDialog();
        }
    }
}
