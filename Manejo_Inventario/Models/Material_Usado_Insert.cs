using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manejo_Inventario.Models
{
    public class Material_Usado_Insert
    {

        public int ID_Material { get; set; }
        public int ID_Producto { get; set; }
        public decimal Cantidad_Usada { get; set; }
        public string Detalle { get; set; }

    }
}