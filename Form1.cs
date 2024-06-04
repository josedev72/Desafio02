using Desafio02.DataBase;
using Desafio02.Models;
using System.Data;

namespace Desafio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = cmbTablas.SelectedItem.ToString();

            TraerTabla(opcionSeleccionada);
        }

        private void TraerTabla(string? opcionSeleccionada)
        {
            switch (opcionSeleccionada)
            {
                case "Producto":
                    CargarDGVProd(ProductoData.ListarProductos());
                    break;
                
                case "ProductoVendido":
                    CargarDGVProdVendido(ProductoVendidoData.ListarProductoVendido());
                    break;

                case "Usuario":
                    CargarDGVUsuario(UsuarioData.ListarUsuarios());
                    break;

                case "Venta":
                    CargarDGVVenta(VentaData.ListarVentas());
                    break;
                default:
                    break;
            }
        }

        private void CargarDGVVenta(List<Venta> lista)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista; ;
        }

        private void CargarDGVUsuario(List<Usuario> lista)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }

        private void CargarDGVProdVendido(List<ProductoVendido> lista)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }

        private void CargarDGVProd(List<Producto> lista)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }
    }
}