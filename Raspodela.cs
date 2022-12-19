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
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        public Raspodela()
        {
            InitializeComponent();
        }

        private void TextPopulate()
        {
            if (raspodela.Rows.Count == 0)
            {
                cbNastavnik.SelectedValue = -1;
                cbGodina.SelectedValue = -1;
                cbPredmet.SelectedValue = -1;
                cbOdeljenje.SelectedValue = -1;
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
            cbNastavnik.SelectedValue = raspodela.Rows[broj_sloga][1];
            cbGodina.SelectedValue = raspodela.Rows[broj_sloga][2];
            cbPredmet.SelectedValue = raspodela.Rows[broj_sloga][3];
            cbOdeljenje.SelectedValue = raspodela.Rows[broj_sloga][4];
            btPrev.Enabled = true;
            btFirst.Enabled = true;
            btLast.Enabled = true;
            btNext.Enabled = true;
            if (broj_sloga == 0)
            {
                btPrev.Enabled = false;
                btFirst.Enabled = false;
            }
            if (broj_sloga == raspodela.Rows.Count - 1)
            {
                btLast.Enabled = false;
                btNext.Enabled = false;
            }
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextPopulate();
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            cbID.SelectedIndex = 0;
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            cbID.SelectedIndex--;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            cbID.SelectedIndex++;
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            cbID.SelectedIndex = raspodela.Rows.Count - 1; 
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE raspodela SET ";
            naredba += "nastavnik_id = " + cbNastavnik.SelectedValue + ", godina_id = " + cbGodina.SelectedValue;
            naredba += ", predmet_id = " + cbPredmet.SelectedValue + ", odeljenje_id = " + cbOdeljenje.SelectedValue + " ";
            naredba += "WHERE id = " + cbID.SelectedItem.ToString();
            if (!Konekcija.DML(naredba, ref raspodela))
            {
                DataLoad();
                TextPopulate();
            }
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            string naredba = "INSERT INTO raspodela VALUES(";
            naredba += cbNastavnik.SelectedValue + ", ";
            naredba += cbGodina.SelectedValue + ", ";
            naredba += cbPredmet.SelectedValue + ", ";
            naredba += cbOdeljenje.SelectedValue + ")";
            if (Konekcija.DML(naredba, ref raspodela))
            {
                cbID.Items.Add(raspodela.Rows[raspodela.Rows.Count - 1][0]);
                if (cbID.Items.Count == 1) cbID.SelectedIndex = 0;
                else
                {
                    DataLoad();
                    TextPopulate();
                }
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM raspodela WHERE id = " + cbID.SelectedItem.ToString();
            if (Konekcija.DML(naredba, ref raspodela))
            {
                if (cbID.SelectedIndex == 0)
                {
                    cbID.Items.RemoveAt(0);
                    if (cbID.Items.Count > 0) cbID.SelectedIndex = 0;
                    else
                    {
                        DataLoad();
                        TextPopulate();
                    }
                }
                else
                {
                    cbID.SelectedIndex--;
                    cbID.Items.RemoveAt(cbID.SelectedIndex + 1);
                }
            }
        }

        private void Raspodela_Load(object sender, EventArgs e)
        {
            raspodela = new DataTable("raspodela");
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM raspodela", veza);
            da.Fill(raspodela);
            DataLoad();
            for (int i = 0; i < raspodela.Rows.Count; i++) cbID.Items.Add(raspodela.Rows[i][0]);
            if (cbID.Items.Count > 0) cbID.SelectedIndex = 0;
            else TextPopulate();
        }

        private void DataLoad()
        {
            SqlConnection veza = Konekcija.Connect();

            // Godina

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable godina = new DataTable();
            da.Fill(godina);
            cbGodina.DataSource = godina;
            cbGodina.ValueMember = "id";
            cbGodina.DisplayMember = "naziv";

            // Nastavnik

            da = new SqlDataAdapter("SELECT id, ime + ' ' + prezime as naziv FROM osoba", veza);
            DataTable nastavnik = new DataTable();
            da.Fill(nastavnik);
            cbNastavnik.DataSource = nastavnik;
            cbNastavnik.ValueMember = "id";
            cbNastavnik.DisplayMember = "naziv";

            // Predmet

            da = new SqlDataAdapter("SELECT id, naziv as naziv FROM predmet", veza);
            DataTable predmet = new DataTable();
            da.Fill(predmet);
            cbPredmet.DataSource = predmet;
            cbPredmet.ValueMember = "id";
            cbPredmet.DisplayMember = "naziv";

            // Odeljenje

            da = new SqlDataAdapter("SELECT id, trim(str(razred)) + '-' + indeks as naziv FROM odeljenje", veza);
            DataTable odeljenje = new DataTable();
            da.Fill(odeljenje);
            cbOdeljenje.DataSource = odeljenje;
            cbOdeljenje.ValueMember = "id";
            cbOdeljenje.DisplayMember = "naziv";
        }
    }
}
