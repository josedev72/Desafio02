using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02.Models
{
    public class ProductoVendido
    {
        //Clase: ProductoVendido;
        //Propiedades: Id, IdProducto, Stock, IdVenta

        public int Id { get; set; }
        public int IdProducto { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public decimal IdVenta { get; set; } = 0;

        public ProductoVendido()
        {
        }

        public ProductoVendido(int id, int idProducto, int stock, decimal idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            Stock = stock;
            IdVenta = idVenta;
        }
    }
}
