using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EsDnevnik2022
{
    public partial class Odeljenje : Form
    {
        public Odeljenje()
        {
            InitializeComponent();
        }

        DataTable odeljenje = new DataTable();
        public int broj_sloga = 0;

        private void Odeljenje_Load(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM smer", veza);
            DataTable smer = new DataTable();
            da.Fill(smer);
            cbSmer_ID.DataSource = smer;
            cbSmer_ID.ValueMember = "id";
            cbSmer_ID.DisplayMember = "naziv";

            da = new SqlDataAdapter("SELECT id, ime + ' ' + prezime as imeprez FROM osoba", veza);
            DataTable osoba = new DataTable();
            da.Fill(osoba);
            cbRazredni_ID.DataSource = osoba;
            cbRazredni_ID.ValueMember = "id";
            cbRazredni_ID.DisplayMember = "imeprez";

            da = new SqlDataAdapter("SELECT * FROM Skolska_godina", veza);
            DataTable godina = new DataTable();
            da.Fill(godina);
            cbGodina_ID.DataSource = godina;
            cbGodina_ID.ValueMember = "id";
            cbGodina_ID.DisplayMember = "naziv";

            da = new SqlDataAdapter("SELECT * FROM odeljenje", veza);
            da.Fill(odeljenje);
            tbID.Text = odeljenje.Rows[broj_sloga][0].ToString();
            tbRazred.Text = odeljenje.Rows[broj_sloga][1].ToString();
            tbIndeks.Text = odeljenje.Rows[broj_sloga][2].ToString();
            cbSmer_ID.SelectedValue = Convert.ToInt32(odeljenje.Rows[broj_sloga][3]);
            cbRazredni_ID.SelectedValue = Convert.ToInt32(odeljenje.Rows[broj_sloga][4]);
            cbGodina_ID.SelectedValue = Convert.ToInt32(odeljenje.Rows[broj_sloga][5]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            prikazi(broj_sloga);
        }

        private void prikazi(int broj_sloga)
        {
            tbID.Text = odeljenje.Rows[broj_sloga][0].ToString();
            tbRazred.Text = odeljenje.Rows[broj_sloga][1].ToString();
            tbIndeks.Text = odeljenje.Rows[broj_sloga][2].ToString();
            cbSmer_ID.SelectedValue = Convert.ToInt32(odeljenje.Rows[broj_sloga][3]);
            cbRazredni_ID.SelectedValue = Convert.ToInt32(odeljenje.Rows[broj_sloga][4]);
            cbGodina_ID.SelectedValue = Convert.ToInt32(odeljenje.Rows[broj_sloga][5]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            broj_sloga = odeljenje.Rows.Count - 1;
            broj_sloga++;
            prikazi(broj_sloga);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            prikazi(broj_sloga);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            prikazi(broj_sloga);
        }
    }
}
