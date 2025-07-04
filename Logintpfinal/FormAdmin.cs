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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
                BaseDeDatos.Usuarios.Remove(usuario);

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = BaseDeDatos.Usuarios;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;

                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Contraseña = txtContraseña.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.Rol = txtRol.Text;

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = BaseDeDatos.Usuarios;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario()
            {
                NombreUsuario = txtNombreUsuario.Text,
                Contraseña = txtContraseña.Text,
                Correo = txtCorreo.Text,
                Rol = txtRol.Text
            };

            BaseDeDatos.Usuarios.Add(nuevo);


            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = BaseDeDatos.Usuarios;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = BaseDeDatos.Usuarios;
        }

        private void dgvUsuarios_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;

                txtNombreUsuario.Text = usuario.NombreUsuario;
                txtContraseña.Text = usuario.Contraseña;
                txtCorreo.Text = usuario.Correo;
                txtRol.Text = usuario.Rol;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}