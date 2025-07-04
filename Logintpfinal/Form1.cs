using System.Resources;
using System.Windows.Forms;

namespace Logintpfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            var usuario = BaseDeDatos.Usuarios.FirstOrDefault(u => u.NombreUsuario == username);
            if (usuario != null && usuario.Contraseña == password)
            {
                if (usuario.Rol == "Admin")
                {
                    FormAdmin adminForm = new FormAdmin();
                    adminForm.Show();
                }
                else
                {
                    FormUsuario userForm = new FormUsuario();
                    userForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");


            }
        }

        private void btnOlvidaste_Click(object sender, EventArgs e)
        {
            RecuperarForm formRecuperar = new RecuperarForm();
            formRecuperar.ShowDialog();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
