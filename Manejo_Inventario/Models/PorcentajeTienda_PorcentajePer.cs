using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manejo_Inventario.Models
{
    public class PorcentajeTienda_PorcentajePer
    {
        public int ID_Linea { get; set; }
        public int ID_Sys_Settings { get; set; }
        public string Nombre_Linea { get; set; }
        public decimal Porcentaje_Tienda { get; set; }
        public decimal Porcentaje_Personalización { get; set; }
        public decimal Precio_Por_Hora { get; set; }
    }
}