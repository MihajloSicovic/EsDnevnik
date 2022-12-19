using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace EsDnevnik2022
{
    class Konekcija
    {
        public static SqlConnection Connect()
        {
            SqlConnection veza = new SqlConnection(ConfigurationManager.ConnectionStrings["home"].ConnectionString);
            return veza;
        }

        public static bool DML(string naredba, ref DataTable tabela)
        {
            SqlConnection veza = Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + tabela.TableName, veza);
            tabela.Clear();
            da.Fill(tabela);
            return izvrseno;
        }
    }
}
