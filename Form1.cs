using Desafio02.DataBase;
using Desafio02.Models;
using System.Data;
using System.Windows.Forms;

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

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dgvDatos.Rows[e.RowIndex];
                AbrirForm(selectedRow, cmbTablas.Text);
            }
        }

        private void AbrirForm(DataGridViewRow fila, string tabla)
        {
            // Extraer datos de la fila seleccionada
            int id = Convert.ToInt32(fila.Cells[0].Value);

            switch (tabla)
            {
                case "Producto":
                    FormProducto formProducto = new FormProducto(id);
                    break;

                case "ProductoVendido":
                    FormProductoVendido formProductoVendido = new FormProductoVendido(id);
                    break;

                case "Usuario":
                    FormUsuario formUsuario = new FormUsuario(id);
                    break;

                case "Venta":
                    FormVenta formVenta = new FormVenta(id);
                    break;
                default:
                    break;
            }
            // Crear una instancia de FormProducto y pasar los datos
            
            formulario.ShowDialog(); // Mostrar el formulario como un cuadro de di�logo modal
        }
    }
}
