using Desafio02.DataBase;
using Desafio02.Models;
using System.Data;
using System.Windows.Forms;

namespace Desafio02
{
    public partial class Form1 : Form
    {
        private int Id;
        private string tabla;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = cmbTablas.SelectedItem.ToString();

            TraerTabla(opcionSeleccionada);
        }

        public void TraerTabla(string? opcionSeleccionada)
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
            int id = 0;
            // Extraer datos de la fila seleccionada
            if (dgvDatos.Rows.Count > 0)
            {
                id = Convert.ToInt32(fila.Cells[0].Value);
            }


            switch (tabla)
            {
                case "Producto":
                    FormProducto formProducto = new FormProducto(id);
                    formProducto.FormClosed += FormProducto_FormClosed;
                    formProducto.ShowDialog();
                    break;

                case "ProductoVendido":
                    FormProductoVendido formProductoVendido = new FormProductoVendido(id);
                    formProductoVendido.ShowDialog();
                    break;

                case "Usuario":
                    FormUsuario formUsuario = new FormUsuario(id);
                    formUsuario.ShowDialog();
                    break;

                case "Venta":
                    FormVenta formVenta = new FormVenta(id);
                    formVenta.ShowDialog();
                    break;
                default:
                    break;
            }

        }

        private void FormProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            TraerTabla("Producto");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            switch (cmbTablas.Text)
            {
                case "Producto":
                    FormProducto fprod = new FormProducto(0);
                    fprod.FormClosed += FormProducto_FormClosed;
                    fprod.ShowDialog();
                    break;

                case "ProductoVendido":
                    FormProductoVendido fprodVendido = new FormProductoVendido(0);
                    fprodVendido.FormClosed += FormProductoVendido_FormClosed;
                    fprodVendido.ShowDialog();
                    break;

                case "Usuario":
                    FormUsuario fUsuario = new FormUsuario(0);
                    fUsuario.FormClosed += FormUsuario_FormClosed;
                    fUsuario.ShowDialog();
                    break;

                case "Venta":
                    FormVenta fVenta = new FormVenta(0);
                    fVenta.FormClosed += FormVenta_FormClosed;
                    fVenta.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void FormVenta_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("Venta");
        }

        private void FormUsuario_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("Usuario");
        }

        private void FormProductoVendido_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TraerTabla("ProductoVendido");
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDatos.Rows[e.RowIndex];

                // Aquí puedes acceder a las celdas de la fila seleccionada
                this.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                this.tabla = cmbTablas.Text.Trim();

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.Id > 0 && this.tabla != "")
            {
                switch (this.tabla)
                {
                    case "Producto":
                        ProductoData.EliminarProducto(this.Id);
                        TraerTabla(this.tabla);
                        break;

                    case "ProductoVendido":
                        ProductoVendidoData.EliminarProductoVendido(this.Id);
                        TraerTabla(this.tabla);
                        break;

                    case "Usuario":
                        UsuarioData.EliminarUsuario(this.Id);
                        TraerTabla(this.tabla);
                        break;

                    case "Venta":
                        VentaData.EliminarVenta(this.Id);
                        TraerTabla(this.tabla);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
