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

        private void TextPopulate()
        {
            if (tabela.Rows.Count == 0)
            {
                tbIme.Clear();
                tbPrezime.Clear();
                tbAdresa.Clear();
                tbJMBG.Clear();
                tbEmail.Clear();
                tbLozinka.Clear();
                tbUloga.Clear();
                btBrisi.Enabled = false;
                btIzmeni.Enabled = false;
                btPrev.Enabled = false;
                btFirst.Enabled = false;
                btLast.Enabled = false;
                btNext.Enabled = false;
                return;
            }
            btIzmeni.Enabled = true;
            btBrisi.Enabled = true;
            int broj_sloga = cbID.SelectedIndex;
            tbIme.Text = tabela.Rows[broj_sloga][1].ToString();
            tbPrezime.Text = tabela.Rows[broj_sloga][2].ToString();
            tbAdresa.Text = tabela.Rows[broj_sloga][3].ToString();
            tbJMBG.Text = tabela.Rows[broj_sloga][4].ToString();
            tbEmail.Text = tabela.Rows[broj_sloga][5].ToString();
            tbLozinka.Text = tabela.Rows[broj_sloga][6].ToString();
            tbUloga.Text = tabela.Rows[broj_sloga][7].ToString();
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

        private bool DML(SqlConnection veza, SqlCommand komanda)
        {
            bool izvrseno = true;
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
                izvrseno = false;
            }
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela.Clear();
            da.Fill(tabela);
            return izvrseno;
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            tabela = new DataTable();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            da.Fill(tabela);
            for (int i = 0; i < tabela.Rows.Count; i++) cbID.Items.Add(tabela.Rows[i][0]);
            if (cbID.Items.Count > 0) cbID.SelectedIndex = 0;
            else TextPopulate();
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

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE osoba SET ";
            naredba += "ime = '" + tbIme.Text + "', prezime = '" + tbPrezime.Text + "', adresa = '" + tbAdresa.Text;
            naredba += "', jmbg = '" + tbJMBG.Text + "', email = '" + tbEmail.Text + "', pass = '" + tbLozinka.Text;
            naredba += "', uloga ='" + tbUloga.Text + "'";
            naredba += "WHERE id = " + cbID.SelectedItem.ToString();
            tabela = new DataTable();
            SqlConnection veza = Konekcija.Connect();
            if (!DML(veza, new SqlCommand(naredba, veza))) TextPopulate();
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            string naredba = "INSERT INTO osoba VALUES('";
            naredba += tbIme.Text + "','";
            naredba += tbPrezime.Text + "','";
            naredba += tbAdresa.Text + "','";
            naredba += tbJMBG.Text + "','";
            naredba += tbEmail.Text + "','";
            naredba += tbLozinka.Text + "','";
            naredba += tbUloga.Text + "')";
            SqlConnection veza = Konekcija.Connect();
            if (DML(veza, new SqlCommand(naredba, veza)))
            {
                cbID.Items.Add(tabela.Rows[tabela.Rows.Count - 1][0]);
                if (cbID.Items.Count == 1) cbID.SelectedIndex = 0;
                else TextPopulate();
            }
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextPopulate();
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            string naredba = "DELETE FROM osoba WHERE id = " + cbID.SelectedItem.ToString();
            if (DML(veza, new SqlCommand(naredba, veza)))
            {
                if (cbID.SelectedIndex == 0)
                {
                    cbID.Items.RemoveAt(0);
                    if (cbID.Items.Count > 0) cbID.SelectedIndex = 0;
                    else TextPopulate();
                }
                else
                {
                    cbID.SelectedIndex--;
                    cbID.Items.RemoveAt(cbID.SelectedIndex + 1);
                }
            }
        }
    }
}
