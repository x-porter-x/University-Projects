using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manejo_Inventario.Models
{
    public class Porcentajes_Runtime
    {
        public int ID_Producto {get;set;}
        public decimal Porcentaje_Tienda17 { get; set; }
        public decimal Porcentaje_Tienda2 { get; set; }
        public decimal IVA17 { get; set; }
        public decimal IVA2 { get; set; }
        public decimal Venta17 { get; set; }
        public decimal Venta2 { get; set; }
        public decimal PERVenta17 { get; set; }
        public decimal PERVenta2 { get; set; }
        public decimal Ganancia17 { get; set; }
        public decimal Ganancia2 { get; set; }
        public decimal PrecioPorHora { get; set; }
    }
}