using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02.Models
{
    public class Venta
    {
        //Clase: Venta;
        //Propiedades: Id, Comentarios, IdUsuario
        public int Id { get; set; }
        public string Comentarios { get; set; } = string.Empty;
        public int IdUsuario { get; set; } = 0;

        public Venta()
        {
        }

        public Venta(int id, string comentarios, int idUsuario)
        {
            Id = id;
            Comentarios = comentarios;
            IdUsuario = idUsuario;
        }
    }
}
