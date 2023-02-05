using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manejo_Inventario.Models
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public int ID_Linea { get; set; }
        public string Linea { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Duración { get; set; }
        public decimal Margen17 { get; set; }
        public decimal Margen2 { get; set; }
        public decimal Precio_Elaboracion { get; set; }
    }
}