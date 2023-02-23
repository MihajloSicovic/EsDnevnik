using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EsDnevnik2022
{
    class Konekcija
    {
        public static SqlConnection connect()
        {
            SqlConnection veza = new SqlConnection("Data Source = DESKTOP-87M946F\\SQLEXPRESS; Initial Catalog = ednevnik2022; Integrated Security = true");
            return veza;
        }
    }
}
