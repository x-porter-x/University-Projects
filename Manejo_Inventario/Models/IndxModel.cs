using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manejo_Inventario.Models
{
    public class IndxModel
    {
        public List<Producto> listaProductos { get; set; }
        public List<Material_Usado> listaMaterialesUsados { get; set; }
        public List<Porcentajes_Runtime> listaPorcentajes_Runtimes { get; set; }
    }
}   