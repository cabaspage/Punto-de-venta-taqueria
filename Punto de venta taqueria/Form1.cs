using Punto_de_venta_taqueria.Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta_taqueria
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConexionBD con = new ConexionBD();
            if (!con.ProbarConexion())
            {
                MessageBox.Show("Error al conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarUsuarios();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            NuevosUsuarios registrar = new NuevosUsuarios();
            this.Hide();
            registrar.ShowDialog();
        }

        private void cmbusuario_DropDown(object sender, EventArgs e)
        {

        }

        private void CargarUsuarios()
        {
            ConexionBD con = new ConexionBD();
            using (SqlConnection conn = con.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerUsuarios", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        cmbusuario.Items.Clear();
                        while (dr.Read())
                        {
                            cmbusuario.Items.Add(dr["Usuario"].ToString());
                        }
                    }
                }
            }
        }

       

        private void btningresar_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            ConexionBD con = new ConexionBD();
            int usuario = Convert.ToInt32(cmbusuario.Text);
            if(user.ValidarUsuario(cmbusuario.Text, txtcontrasena.Text))
            {
                MessageBox.Show("Login Correcto!");
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                using (SqlConnection conn = con.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ReintentosUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdUsuario",usuario );
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                int resultado = Convert.ToInt32(dr["Resultado"]);
                                string mensaje = dr["Mensaje"].ToString();

                                if (resultado == 0)
                                {
                                    MessageBox.Show(mensaje);
                                }
                                
                            }
                        }
                    }
                }
                txtcontrasena.Clear();
            }
        }
    }
}
