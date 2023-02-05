using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manejo_Inventario.Models
{
    public class EP_VerMateriales_del_producto
    {
        public int ID_Producto { get; set; }
        public List<Material_Usado> Materiales_del_Producto { get; set; }
    }
}