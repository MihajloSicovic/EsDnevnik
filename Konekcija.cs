using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace EsDnevnik2022
{
    class Konekcija
    {
        public static SqlConnection Connect()
        {
            SqlConnection veza = new SqlConnection(ConfigurationManager.ConnectionStrings["home"].ConnectionString);
            return veza;
        }
    }
}
