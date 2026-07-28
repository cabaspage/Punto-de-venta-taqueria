using Punto_de_venta_taqueria.Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta_taqueria
{
    public partial class LoginPermisos : Form
    {
        public LoginPermisos()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            try
            {
                usuarios.ValidarUsuario(cmbusuarios.Text, txtcontrasena.Text);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
