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
    public partial class FormProductoVendido : Form
    {
        private int id;
        public FormProductoVendido(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductoVendido_Load(object sender, EventArgs e)
        {
            Limpiar();
            ProductoVendido prodVendido = new ProductoVendido();
            if (this.id == 0)
            {
                btnAceptar.Text = "Agregar";
                txtIdProducto.Focus();
            }
            else
            {
                btnAceptar.Text = "Editar";
                prodVendido = ProductoVendidoData.ObtenerProductoVendido(this.id);
                CargarProductoVendido(prodVendido);
            }
        }

        private void CargarProductoVendido(ProductoVendido prodVendido)
        {
            txtId.Text = prodVendido.Id.ToString();
            txtIdProducto.Text = prodVendido.IdProducto.ToString();
            txtStock.Text = prodVendido.Stock.ToString();
            txtIdVenta.Text = prodVendido.IdVenta.ToString();
            txtIdProducto.Focus();
        }

        private void Limpiar()
        {
            txtId.Text = txtIdProducto.Text = txtStock.Text = txtIdVenta.Text = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoVendido p = new ProductoVendido();
            if (this.id == 0)
            {
                p.Id = 0;
                p.IdProducto = Convert.ToInt32(txtIdProducto.Text.Trim());
                p.Stock = Convert.ToInt32(txtStock.Text.Trim());
                p.IdVenta = Convert.ToInt32(txtIdVenta.Text.Trim());

                ProductoVendidoData.CrearProductoVendido(p);
            }
            else
            {
                p.Id = Convert.ToInt32(txtId.Text);
                p.IdProducto = Convert.ToInt32(txtIdProducto.Text.Trim());
                p.Stock = Convert.ToInt32(txtStock.Text.Trim());
                p.IdVenta = Convert.ToInt32(txtIdVenta.Text.Trim());

                ProductoVendidoData.ModificarProductoVendido(p);
            }

            this.Close();
        }
    }
}
