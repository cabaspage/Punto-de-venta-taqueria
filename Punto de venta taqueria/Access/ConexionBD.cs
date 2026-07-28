using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace Punto_de_venta_taqueria.Access
{
    public class ConexionBD
    {
        private readonly string connectionString;
        public ConexionBD() 
        {
            connectionString = ConfigurationManager.ConnectionStrings["TaqueriaBD"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
