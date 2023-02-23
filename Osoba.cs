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
    public partial class Osoba : Form
    {
        DataTable tabela;
        public Osoba()
        {
            InitializeComponent();
        }

        private void TxtPopulate()
        {
            if (tabela.Rows.Count == 0) return;
            int broj_sloga = (int)cbID.SelectedItem - 1;
            tbIme.Text = tabela.Rows[broj_sloga][1].ToString();
            tbPrezime.Text = tabela.Rows[broj_sloga][2].ToString();
            tbAdresa.Text = tabela.Rows[broj_sloga][3].ToString();
            tbJMBG.Text = tabela.Rows[broj_sloga][4].ToString();
            tbEmail.Text = tabela.Rows[broj_sloga][5].ToString();
            btPrev.Enabled = true;
            btFirst.Enabled = true;
            btLast.Enabled = true;
            btNext.Enabled = true;
            if (broj_sloga == 0)
            {
                btPrev.Enabled = false;
                btFirst.Enabled = false;
            }
            if (broj_sloga == tabela.Rows.Count - 1)
            {
                btLast.Enabled = false;
                btNext.Enabled = false;
            }
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            tabela = new DataTable();
            SqlConnection veza = new SqlConnection("Data Source = INF_4_09\\SQLPBG; Initial Catalog = ednevnik2022; Integrated Security = true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            da.Fill(tabela);
            for (int i = 0; i < tabela.Rows.Count; i++) cbID.Items.Add(tabela.Rows[i][0]);
            cbID.SelectedIndex = 0;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            cbID.SelectedIndex++;
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            cbID.SelectedIndex = 0;
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            cbID.SelectedIndex--;
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            cbID.SelectedIndex = tabela.Rows.Count - 1;
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtPopulate();
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE osoba SET ";
            naredba += "ime = '" + tbIme.Text + "', prezime = '" + tbPrezime.Text + "', adresa = '" + tbAdresa.Text + "', jmbg = '" + tbJMBG.Text + "', email = '" + tbEmail.Text + "' ";
            naredba += "WHERE id = " + cbID.SelectedItem.ToString();
            tabela = new DataTable();
            SqlConnection veza = new SqlConnection("Data Source = INF_4_09\\SQLPBG; Initial Catalog = ednevnik2022; Integrated Security = true");
            SqlCommand komanda = new SqlCommand(naredba, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            da.Fill(tabela);
        }

        private void btUnesi_Click(object sender, EventArgs e)
        {
            string naredba = "INSERT INTO osoba VALUES('";
            naredba += tbIme.Text + "','";
            naredba += tbPrezime.Text + "','";
            naredba += tbAdresa.Text + "','";
            naredba += tbJMBG.Text + "','";
            naredba += tbEmail.Text + "',";
            naredba += "null, 0)"; 
        }
    }
}
