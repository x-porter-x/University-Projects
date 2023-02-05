using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manejo_Inventario.Models
{
    public class Material
    {
        public int ID_Material { get; set; }
        public int ID_Tipo_De_Material { get; set; }
        public string Nombre_Material { get; set; }
        public string Nombre_del_Tipo_de_Material { get; set; }
        public decimal Precio_Por_Metro { get; set; }
        public string Especificaciones { get; set; }
        public string Proveedor { get; set; }
        public string Fecha_Actualizada { get; set; }
       }
}