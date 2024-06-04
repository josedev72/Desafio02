using Desafio02.DataBase;
using Desafio02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio02
{
    public partial class FormUsuario : Form
    {
        private int id;
        public FormUsuario(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            Limpiar();
            Usuario usuario = new Usuario();
            if (this.id == 0)
            {
                btnAceptar.Text = "Agregar";
                txtNombre.Focus();
            }
            else
            {
                btnAceptar.Text = "Editar";
                usuario = UsuarioData.ObtenerUsuario(this.id);
                CargarUsuario(usuario);
            }
        }

        private void CargarUsuario(Usuario usuario)
        {
            txtId.Text = usuario.Id.ToString();
            txtNombre.Text = usuario.Nombre.ToString();
            txtApellido.Text = usuario.Apellido.ToString();
            txtNombreUsuario.Text = usuario.NombreUsuario.ToString();
            txtPass.Text = usuario.Contrasenia.ToString();
            txtMail.Text = usuario.Mail.ToString();

            txtNombre.Focus();
        }

        private void Limpiar()
        {
            txtId.Text = txtNombre.Text = txtApellido.Text = txtNombreUsuario.Text =
                txtPass.Text = txtMail.Text = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            if (this.id == 0)
            {
                usu.Id = 0;
                usu.Nombre = txtNombre.Text.Trim();
                usu.Apellido = txtApellido.Text.Trim();
                usu.NombreUsuario = txtNombreUsuario.Text.Trim();
                usu.Contrasenia = txtPass.Text.Trim();
                usu.Mail = txtMail.Text.Trim();

                UsuarioData.CrearUsuario(usu);
            }
            else
            {
                usu.Id =Convert.ToInt32(txtId.Text);
                usu.Nombre = txtNombre.Text.Trim();
                usu.Apellido = txtApellido.Text.Trim();
                usu.NombreUsuario = txtNombreUsuario.Text.Trim();
                usu.Contrasenia = txtPass.Text.Trim();
                usu.Mail = txtMail.Text.Trim();

                UsuarioData.ModificarUsuario(usu);
            }

            this.Close();
        }
    }
}
