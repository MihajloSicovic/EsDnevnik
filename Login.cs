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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btUloguj_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPassword.Text == "") MessageBox.Show("Morate uneti mejl i lozinku!");
            else
            {
                SqlConnection veza = Konekcija.connect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba WHERE email = '" + tbEmail.Text + "'", veza);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                
                if (tabela.Rows.Count == 0) MessageBox.Show("Dati nalog ne postoji!");
                else if (string.Compare(tbPassword.Text, tabela.Rows[0]["pass"].ToString()) != 0) MessageBox.Show("Pogresna lozinka!");
                else
                {
                    MessageBox.Show("Dobrodosli!");
                    Glavna glavna = new Glavna(this);
                    glavna.Show();
                }
            }
        }

        private void btOtkazi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
