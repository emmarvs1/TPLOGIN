using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logintpfinal
{
    public partial class RecuperarForm : Form
    {
        private string codigoGenerado;
        private Usuario usuarioRecuperado;
        public RecuperarForm()
        {
            InitializeComponent();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            string correoIngresado = txtCorreo.Text.Trim();

            usuarioRecuperado = BaseDeDatos.Usuarios.FirstOrDefault(u => u.Correo == correoIngresado);

            if (usuarioRecuperado != null)
            {
                Random rnd = new Random();
                codigoGenerado = rnd.Next(100000, 999999).ToString();

                MessageBox.Show("Código enviado (simulado): " + codigoGenerado);

                lblCodigo.Visible = true;
                txtCodigo.Visible = true;
                lblNuevaPass.Visible = true;
                txtNuevaPass.Visible = true;
                lblConfirmar.Visible = true;
                txtConfirmarPass.Visible = true;
                btnConfirmar.Visible = true;
                lblMensaje.Text = "";

            }
            else
            {
                lblMensaje.Text = "Correo no encontrado.";
            }
        }
        private void RecuperarForm_Load(object sender, EventArgs e)
        {
            lblCodigo.Visible = false;
            txtCodigo.Visible = false;
            lblNuevaPass.Visible = false;
            txtNuevaPass.Visible = false;
            lblConfirmar.Visible = false;
            txtConfirmarPass.Visible = false;
            btnConfirmar.Visible = false;
            lblMensaje.Text = "";
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNuevaPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == codigoGenerado)
            {
                if (txtNuevaPass.Text == txtConfirmarPass.Text)
                {
                    usuarioRecuperado.Contraseña = txtNuevaPass.Text;
                    MessageBox.Show("¡Contraseña actualizada con éxito!");

                    this.Close();
                }
                else
                {
                    lblMensaje.Text = "Las contraseñas no coinciden.";
                }
            }
            else
            {
                lblMensaje.Text = "El código ingresado es incorrecto.";
            }
        }
    }
}

