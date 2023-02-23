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
    public partial class Ocena : Form
    {
        public Ocena()
        {
            InitializeComponent();
        }

        DataTable ucenik, predmet, ocena, profesor, godina, odeljenje;
        private void Ucenik_Populate()
        {
            StringBuilder s = new StringBuilder("SELECT osoba.id AS id, ime + ' ' + prezime AS naziv FROM osoba");
            s.Append(" JOIN upisnica ON osoba.id = osoba_id WHERE upisnica.odeljenje_id = " + cbOdeljenje.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(s.ToString(), Konekcija.connect());
            ucenik = new DataTable();
            da.Fill(ucenik);
            cbUcenik.DataSource = ucenik;
            cbUcenik.ValueMember = "id";
            cbUcenik.DisplayMember = "naziv";
            cbUcenik.SelectedIndex = -1;
        }

        private void Predmet_Populate()
        {
            StringBuilder s = new StringBuilder("SELECT DISTINCT predmet.id AS id, naziv FROM predmet");
            s.Append(" JOIN raspodela ON predmet.id = predmet_id WHERE godina_id = " + cbGodina.SelectedValue);
            s.Append(" AND nastavnik_id = " + cbProfesor.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(s.ToString(), Konekcija.connect());
            predmet = new DataTable();
            da.Fill(predmet);
            cbPredmet.DataSource = predmet;
            cbPredmet.ValueMember = "id";
            cbPredmet.DisplayMember = "naziv";
            cbPredmet.SelectedIndex = -1;
        }

        private void Profesor_Populate()
        {
            StringBuilder s = new StringBuilder("SELECT DISTINCT osoba.id AS id, ime + ' ' + prezime AS naziv FROM osoba");
            s.Append(" JOIN raspodela ON osoba.id = nastavnik_id WHERE godina_id = " + cbGodina.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(s.ToString(), Konekcija.connect());
            profesor = new DataTable();
            da.Fill(profesor);
            cbProfesor.DataSource = profesor;
            cbProfesor.ValueMember = "id";
            cbProfesor.DisplayMember = "naziv";
            cbProfesor.SelectedIndex = -1;
        }

        private void Godina_Populate()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT id, naziv FROM skolska_godina", Konekcija.connect());
            godina = new DataTable();
            da.Fill(godina);
            cbGodina.DataSource = godina;
            cbGodina.ValueMember = "id";
            cbGodina.DisplayMember = "naziv";
            if (cbGodina != null) cbGodina.SelectedIndex = cbGodina.Items.Count - 1;
        }

        private void Odeljenje_Populate()
        {
            StringBuilder s = new StringBuilder("SELECT DISTINCT odeljenje.id AS id, trim(str(razred)) + '-' + indeks AS naziv FROM odeljenje");
            s.Append(" JOIN raspodela ON odeljenje.id = odeljenje_id WHERE raspodela.godina_id = " + cbGodina.SelectedValue);
            s.Append(" AND nastavnik_id = " + cbProfesor.SelectedValue);
            s.Append(" AND predmet_id = " + cbPredmet.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(s.ToString(), Konekcija.connect());
            odeljenje = new DataTable();
            da.Fill(odeljenje);
            cbOdeljenje.DataSource = odeljenje;
            cbOdeljenje.ValueMember = "id";
            cbOdeljenje.DisplayMember = "naziv";
            cbOdeljenje.SelectedIndex = -1;
        }

        private void Ocena_Populate()
        {
            StringBuilder s = new StringBuilder("SELECT ocena.id AS id, ime + ' ' + prezime AS naziv, ocena, ucenik_id, datum FROM osoba");
            s.Append(" JOIN ocena ON osoba.id = ucenik_id");
            s.Append(" JOIN raspodela ON raspodela.id = raspodela_id WHERE raspodela_id =");
            s.Append(" (SELECT id from raspodela WHERE godina_id = " + cbGodina.SelectedValue);
            s.Append(" AND nastavnik_id = " + cbProfesor.SelectedValue);
            s.Append(" AND predmet_id = " + cbPredmet.SelectedValue);
            s.Append(" AND odeljenje_id = " + cbOdeljenje.SelectedValue + ")");

            SqlDataAdapter da = new SqlDataAdapter(s.ToString(), Konekcija.connect());
            ocena = new DataTable();
            da.Fill(ocena);
            dgOcena.DataSource = ocena;

            dgOcena.Columns["ucenik_id"].Visible = false;
            dgOcena.Columns["id"].Visible = false;
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder("SELECT id FROM raspodela");
            s.Append(" WHERE godina_id = " + cbGodina.SelectedValue);
            s.Append(" AND nastavnik_id = " + cbProfesor.SelectedValue);
            s.Append(" AND predmet_id = " + cbPredmet.SelectedValue);
            s.Append(" AND odeljenje_id = " + cbOdeljenje.SelectedValue);

            SqlConnection veza = Konekcija.connect();
            SqlCommand komanda = new SqlCommand(s.ToString(), veza);
            int raspodela_id = 0;

            try
            {
                veza.Open();
                raspodela_id = (int)komanda.ExecuteScalar();
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (raspodela_id == 0) return;

            komanda = new SqlCommand("INSERT INTO ocena VALUES ('" + dtDatum.Value.Date.ToString() + "', " + raspodela_id + ", " + ndOcena.Value + ", " + cbUcenik.SelectedValue + ")", veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                Ocena_Populate();
                dgOcena.CurrentCell = dgOcena[1, dgOcena.RowCount - 1];
                btBrisi.Enabled = btPromeni.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btPromeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.connect();
            SqlCommand komanda = new SqlCommand("UPDATE ocena SET ucenik_id = " + cbUcenik.SelectedValue + ", ocena = " + ndOcena.Value + ", datum = '" + dtDatum.Value.Date.ToString() + "' WHERE id = " + dgOcena.Rows[current_id].Cells["id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                Ocena_Populate();
                dgOcena.CurrentCell = dgOcena[current_cellC, current_id];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.connect();
            SqlCommand komanda = new SqlCommand("DELETE FROM ocena WHERE id = " + dgOcena.Rows[current_id].Cells["id"].Value, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                Ocena_Populate();
                if (CheckDataGrid())
                {
                    if (current_id > 0) dgOcena.CurrentCell = dgOcena[current_cellC, --current_id];
                    else dgOcena.CurrentCell = dgOcena[current_cellC, current_id];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckDataGrid()
        {
            if (dgOcena.RowCount == 0)
            {
                btBrisi.Enabled = false;
                btPromeni.Enabled = false;
                return false;
            }
            else 
            {
                btBrisi.Enabled = true;
                btPromeni.Enabled = true;
                SelectedRowChanged(0);
                return true;
            }
        }

        private void cbGodina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbGodina.IsHandleCreated && cbGodina.Focused) Profesor_Populate();
        }

        private void cbProfesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbProfesor.IsHandleCreated && cbProfesor.Focused)
            {
                Predmet_Populate();
                cbPredmet.Enabled = true;
            }
        }

        private void cbPredmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbPredmet.IsHandleCreated && cbPredmet.Focused)
            {
                Odeljenje_Populate();
                cbOdeljenje.Enabled = true;
            }
        }

        private void cbOdeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbOdeljenje.IsHandleCreated && cbOdeljenje.Focused)
            {
                Ucenik_Populate();
                Ocena_Populate();
                if (CheckDataGrid() || cbUcenik.Items.Count > 0)
                {
                    cbUcenik.Enabled = ndOcena.Enabled = dtDatum.Enabled = true;
                    btDodaj.Enabled = true;
                    current_id = 0;
                    current_cellC = 1;
                }
            }
        }

        private void cbProfesor_TextChanged(object sender, EventArgs e)
        {
            cbPredmet.SelectedIndex = -1;
            cbPredmet.Enabled = false;
        }

        private void cbPredmet_TextChanged(object sender, EventArgs e)
        {
            cbOdeljenje.SelectedIndex = -1;
            cbOdeljenje.Enabled = false;
        }

        private void cbOdeljenje_TextChanged(object sender, EventArgs e)
        {
            cbUcenik.SelectedIndex = -1;
            cbUcenik.Enabled = ndOcena.Enabled = dtDatum.Enabled = false;
            btDodaj.Enabled = btBrisi.Enabled = btPromeni.Enabled = false;
            dgOcena.DataSource = null;
            ndOcena.Value = 5;
            dtDatum.Value = DateTime.Now;
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            Godina_Populate();
            Profesor_Populate();
        }

        private void SelectedRowChanged(int n)
        {
            cbUcenik.SelectedValue = (int)dgOcena.Rows[n].Cells["ucenik_id"].Value;
            ndOcena.Value = (int)dgOcena.Rows[n].Cells["ocena"].Value;
            dtDatum.Value = (DateTime)dgOcena.Rows[n].Cells["datum"].Value;
        }

        int current_id = 0;
        int current_cellC = 1;
        private void dgOcena_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!dgOcena.Focused || dgOcena.CurrentRow == null) return;
            current_id = dgOcena.CurrentRow.Index;
            current_cellC = dgOcena.CurrentCell.ColumnIndex;
            SelectedRowChanged(current_id);
        }
    }
}
