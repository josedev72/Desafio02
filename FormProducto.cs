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
    public partial class FormProducto : Form
    {
        private int Id;
        //this.Id = Id;

        public FormProducto(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            Limpiar();
            Producto producto = new Producto();
            if (Id == 0)
            {
                btnAceptar.Text = "Agregar";
                txtDescripcion.Focus();
            }
            else
            {
                btnAceptar.Text = "Editar";                
                producto = ProductoData.ObtenerProducto(Id);
                CargarProducto(producto);
            }
        }

        private void Limpiar()
        {
            txtId.Text = txtDescripcion.Text = txtCosto.Text = txtPrecioVenta.Text = 
                txtStock.Text = txtIdUsuario.Text = string.Empty;
        }

        private void CargarProducto(Producto producto)
        {
            txtId.Text = producto.Id.ToString();
            txtDescripcion.Text = producto.Descripcion.ToString();
            txtCosto.Text = producto.Costo.ToString();
            txtPrecioVenta.Text = producto.PrecioVenta.ToString();
            txtStock.Text = producto.Stock.ToString();
            txtIdUsuario.Text = producto.IdUsuario.ToString();
            txtDescripcion.Focus();
        }
    }
}
