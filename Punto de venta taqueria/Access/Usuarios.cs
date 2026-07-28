using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta_taqueria.Access
{
    public class Usuarios
    {
        public void RegistrarUsuario(string nombre, string apellidop, string apellidom, string usuario, string contraseña)
        {
            ConexionBD con = new ConexionBD();

            using (SqlConnection conn = con.GetConnection())
            using (SqlCommand cmd = new SqlCommand("RegistrarUsuariosNuevos", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellidop", apellidop);
                cmd.Parameters.AddWithValue("@Apellidom", string.IsNullOrWhiteSpace(apellidom) ? (object)DBNull.Value : apellidom);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                string hash = BCrypt.Net.BCrypt.HashPassword(contraseña);
                cmd.Parameters.AddWithValue("@Contrasena", hash);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int resultado = Convert.ToInt32(reader["Resultado"]);
                        string mensaje = reader["Mensaje"].ToString();

                        MessageBox.Show(mensaje);
                    }
                }
            }
        }

        public bool ValidarUsuario(string usuario, string contraseña)
        {
            ConexionBD con = new ConexionBD();

            using (SqlConnection conn = con.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Login", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string hash = reader["Contrasena"].ToString();
                        if (BCrypt.Net.BCrypt.Verify(contraseña, hash))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public void CargaUsuarios(ComboBox comboBox)
        {
            ConexionBD con = new ConexionBD();

            using (SqlConnection conn = con.GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT Usuario FROM Usuarios", conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["Usuario"].ToString());
                    }
                }
            }
        }
    }
}
