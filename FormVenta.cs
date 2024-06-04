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
    public partial class FormVenta : Form
    {
        private int id;
        public FormVenta(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            Limpiar();
            Venta venta = new Venta();
            if (this.id == 0)
            {
                btnAceptar.Text = "Agregar";
                txtComentarios.Focus();
            }
            else
            {
                btnAceptar.Text = "Editar";
                venta = VentaData.ObtenerVenta(this.id);
                CargarVenta(venta);
            }
        }

        private void CargarVenta(Venta venta)
        {
            txtId.Text = venta.Id.ToString();
            txtComentarios.Text = venta.Comentarios.ToString();
            txtIdUsuario.Text = venta.IdUsuario.ToString();

            txtComentarios.Focus();
        }

        private void Limpiar()
        {
            txtId.Text = txtComentarios.Text = txtIdUsuario.Text = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Venta vta = new Venta();
            if (this.id == 0)
            {
                vta.Id = 0;
                vta.Comentarios = txtComentarios.Text.Trim();
                vta.IdUsuario = Convert.ToInt32(txtIdUsuario.Text.Trim());
                
                VentaData.CrearVenta(vta);
            }
            else
            {
                vta.Id = Convert.ToInt32(txtId.Text);
                vta.Comentarios = txtComentarios.Text.Trim();
                vta.IdUsuario = Convert.ToInt32(txtIdUsuario.Text.Trim());

                VentaData.ModificarVenta(vta);
            }

            this.Close();
        }
    }
}
