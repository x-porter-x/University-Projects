using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manejo_Inventario.Models
{
    public class Material_Usado
    {
        public int ID_Mat_Usado { get; set; }
        public int ID_Material { get; set; }
        public int ID_Producto { get; set; }
        public string Nombre_Material { get; set; }
        public decimal Candtidad_Metros_Unidades_Usado { get; set; }
        public decimal Precio_Metro_Unidad { get; set; }
        public string Detalle { get; set; }
    }
}