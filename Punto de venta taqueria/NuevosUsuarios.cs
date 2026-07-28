using Org.BouncyCastle.Crypto.Generators;
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
    public partial class NuevosUsuarios : Form
    {
        public NuevosUsuarios()
        {
            InitializeComponent();
        }



        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtnombre.Text == "" || txtapellidop.Text == "" || txtapellidom.Text == "" || txtusuario.Text == "" || txtcontraseña.Text == "")
                {
                    MessageBox.Show("Uno o más campos estan incompletos, favor de llenar todos los campos..");
                    return;
                }
                string nombre = txtnombre.Text;
                string apellidop = txtapellidop.Text;
                string apellidom = txtapellidom.Text;
                string usuario = txtusuario.Text;
                string contraseña = txtcontraseña.Text;

                Usuarios usuarios = new Usuarios();
                usuarios.RegistrarUsuario(nombre, apellidop, apellidom, usuario, contraseña);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtapellidop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtapellidom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
               
                e.Handled = false;
            }
            else
            {
               
                e.Handled = true;
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
             
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
