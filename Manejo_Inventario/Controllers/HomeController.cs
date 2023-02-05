using System;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using System.Collections.Generic;
using Manejo_Inventario.Models;
using Manejo_Inventario.DBClass;

namespace Manejo_Inventario.Controllers
{
    public class HomeController : Controller
    {
        DB Con;
        public ActionResult Index()
        {
            Con = new DB();
            IndxModel model = new IndxModel();
            model.listaPorcentajes_Runtimes = Actualizar_Precios();
            model.listaProductos = Con.Select_Productos();
            model.listaMaterialesUsados = Con.Select_Materiales_Usados();
            return View(model);
        }
        public ActionResult Productos_Simplificado()
        {
            Con = new DB();
            IndxModel model = new IndxModel();
            model.listaPorcentajes_Runtimes = Actualizar_Precios();
            model.listaProductos = Con.Select_Productos();
            model.listaMaterialesUsados = Con.Select_Materiales_Usados();
            return View(model);
        }
        public ActionResult PercUpdate()
        {
            Con = new DB();
            var model = new List<PorcentajeTienda_PorcentajePer>();
            model = Con.Select_SYS_Setings();
            return View(model);
        }
        public ActionResult IndexRefresh(PorcentajeTienda_PorcentajePer Per)
        {
            Con = new DB();
            Con.Update_SYS_Settings(Per.ID_Sys_Settings, Per.Porcentaje_Tienda, Per.Porcentaje_Personalización, Per.Precio_Por_Hora);
            return RedirectToAction("Index");
        }
        public ActionResult SYSUpdate(PorcentajeTienda_PorcentajePer Per)
        {
            return View(Per);
        }


        decimal precioElaboracion;
        private List<Porcentajes_Runtime> Actualizar_Precios() 
        {
            Con = new DB();
            List<Porcentajes_Runtime> porcentajes_Runtime = new List<Porcentajes_Runtime>();  
            foreach (var producto in Con.Select_Productos())
            {
                precioElaboracion = 0;
                foreach (var material_Usado in Con.Select_Materiales_Usados())
                {
                    if (producto.ID_Producto == material_Usado.ID_Producto)
                    {
                        precioElaboracion = precioElaboracion + (material_Usado.Precio_Metro_Unidad * material_Usado.Candtidad_Metros_Unidades_Usado);
                    }
                }
                List<PorcentajeTienda_PorcentajePer> porcentajes_ = new List<PorcentajeTienda_PorcentajePer>();
                porcentajes_ = Con.Select_SYS_Setings();
                foreach (var Info in porcentajes_)
                {
                    if (Info.ID_Linea == producto.ID_Linea)
                    {
                        precioElaboracion = precioElaboracion + (producto.Duración * Info.Precio_Por_Hora);
                        decimal PTienda = Info.Porcentaje_Tienda / 100;
                        decimal PPersonalizacion = Info.Porcentaje_Personalización / 100;
                        Porcentajes_Runtime Pinfo = new Porcentajes_Runtime();
                        Pinfo.ID_Producto = producto.ID_Producto;
                        Pinfo.Porcentaje_Tienda17 = Math.Round(((precioElaboracion * 1.70m) * PTienda) / 100m, 0) * 100;
                        Pinfo.Porcentaje_Tienda2 = Math.Round(((precioElaboracion * 2) * PTienda) / 100m, 0) * 100;
                        Pinfo.IVA17 = Math.Round((((precioElaboracion * 1.70m) + ((precioElaboracion * 1.70m) * PTienda)) * 0.13m) / 100m, 0) * 100;
                        Pinfo.IVA2 = Math.Round((((precioElaboracion * 2) + ((precioElaboracion * 2) * PTienda)) * 0.13m) / 100m, 0) * 100m;
                        Pinfo.Venta17 = Math.Round((((precioElaboracion * 1.70m) + (Pinfo.Porcentaje_Tienda17) + (Pinfo.IVA17))) / 100m, 0) * 100;
                        Pinfo.Venta2 = Math.Round((((precioElaboracion * 2) + (Pinfo.Porcentaje_Tienda2) + (Pinfo.IVA2))) / 100m, 0) * 100;
                        Pinfo.PERVenta17 = Math.Round((Pinfo.Venta17 + (Pinfo.Venta17 * PPersonalizacion)) / 100m, 0) * 100;
                        Pinfo.PERVenta2 = Math.Round((Pinfo.Venta2 + (Pinfo.Venta2 * PPersonalizacion)) / 100m, 0) * 100;
                        Pinfo.Ganancia17 = Math.Round(((precioElaboracion * 1.70m) - precioElaboracion) / 100m, 0) * 100;
                        Pinfo.Ganancia2 = Math.Round(((precioElaboracion * 2) - precioElaboracion) / 100m, 0) * 100;
                        Pinfo.PrecioPorHora = Info.Precio_Por_Hora;
                        porcentajes_Runtime.Add(Pinfo);
                        Con.Update_Precio_Productos(producto.ID_Producto, precioElaboracion, Math.Round((precioElaboracion * 1.70m) / 100m, 0) * 100, Math.Round((precioElaboracion * 2) / 100m, 0) * 100);
                    }
                }
            }
            return porcentajes_Runtime;
        }
        public ActionResult Insertar_Material_Usado(Material_Usado_Insert matu)
        {
            Con = new DB();
            var matus = Con.Select_Materiales()
            .Select(s => new { IdMaterial = s.ID_Material,Info = string.Format("{0} - ₡ {1}", s.Nombre_Material, s.Precio_Por_Metro) }).ToList();
            ViewBag.MatList = new SelectList(matus, "IdMaterial", "Info");
            return View(matu);
        }
        public ActionResult Insertar_Material_UsadoDB(Material_Usado_Insert matu)
        {
            Edit_Session_Model Editar_Producto_SessionI = Session["Editar_ProductoS"] as Edit_Session_Model;
            Con = new DB();
            Con.Insert_Material_Usado(matu.ID_Producto, matu.ID_Material, matu.Cantidad_Usada, matu.Detalle);
            return RedirectToAction("Editar_Producto", Editar_Producto_SessionI.Producto_A_Editar);
        }


        public ActionResult Ver_Lineas()
        {
            Con = new DB();
            Ver_LineasModel model = new Ver_LineasModel();
            model.Lineas = Con.Select_Lineas();
            return View(model);
        }
        public ActionResult Editar_Linea(MLineas L)
        {
            return View(L);
        }
        public ActionResult Insertar_Linea(MLineas L)
        {
            return View(L);
        }
        public ActionResult Insertar_LineaDB(MLineas L)
        {
            Con = new DB();
            Con.Insert_SYS();
            Con.Insert_Linea(Con.Select_SYS_ID_Mas_Nuevo(),L.Nombre_Linea);
            return RedirectToAction("Ver_Lineas");
        }
        public ActionResult Editar_LineasDB(MLineas L)
        {
            Con = new DB();
            Con.Update_Lineas(L.ID_Linea, L.Nombre_Linea);
            return RedirectToAction("Ver_Lineas");
        }

        public ActionResult DELETE_Linea(MLineas L)
        {
            Con = new DB();
            Con.DELETE_Lineas(L.ID_Linea);
            return RedirectToAction("Ver_Lineas");
        }

        public ActionResult Editar_Producto(Producto prod)
        {
            Con = new DB();
            Edit_Session_Model Editar_Producto_Session = new Edit_Session_Model();
            Editar_Producto_Session.Producto_A_Editar = prod;
            List<MLineas> L = new List<MLineas>();
            L = Con.Select_Lineas();
            ViewBag.LineasList = new SelectList(L, "ID_Linea", "Nombre_Linea",prod.ID_Linea);
            Session["Editar_ProductoS"] = Editar_Producto_Session;
            return View(Editar_Producto_Session.Producto_A_Editar);
        }
        public ActionResult Insertar_Producto(Producto prod)
        {
            Con = new DB();
            List<MLineas> L = new List<MLineas>();
            L = Con.Select_Lineas();
            ViewBag.LineasList = new SelectList(L, "ID_Linea", "Nombre_Linea");
            return View(prod);
        }
        public ActionResult Insertar_ProductoDB(Producto prod)
        {
            Con = new DB();
            Con.Insert_Producto(prod.ID_Linea,prod.Nombre_Producto,prod.Duración,prod.Descripcion);
            Producto PMas_Nuevo = new Producto();
            PMas_Nuevo = Con.Select_Producto_Mas_Nuevo();
            prod = PMas_Nuevo;
            return RedirectToAction("Editar_Producto", prod);
        }
        public ActionResult Editar_ProductoDB(Producto prod) 
        {
            Con = new DB();
            Con.Update_Producto(prod.ID_Producto,prod.ID_Linea,prod.Nombre_Producto,prod.Duración,prod.Descripcion);
            return RedirectToAction("Index");
        }
        public ActionResult DELETE_ProductoDB(Producto prod)
        {
            Con = new DB();
            Con.DELETE_Producto(prod.ID_Producto);
            return RedirectToAction("Index");
        }
        public ActionResult DELETE_Material_UsadoDB(Material_Usado Mat)
        {
            Edit_Session_Model Editar_Producto_SessionI = Session["Editar_ProductoS"] as Edit_Session_Model;
            Con = new DB();
            Producto prod = new Producto();
            Con.DELETE_Material_Usado(Mat.ID_Mat_Usado);
            EP_VerMateriales_del_producto model = new EP_VerMateriales_del_producto();
            model.ID_Producto = Mat.ID_Producto;
            model.Materiales_del_Producto = Con.Select_Materiales_Usados();
            return RedirectToAction("Editar_Producto", Editar_Producto_SessionI.Producto_A_Editar);
        }
        public ActionResult EPVer_Materiales(Producto prod)
        {
            Con = new DB();
            EP_VerMateriales_del_producto model = new EP_VerMateriales_del_producto();
            model.ID_Producto = prod.ID_Producto;
            model.Materiales_del_Producto = Con.Select_Materiales_Usados();
            return View(model);
        }

        public ActionResult Ver_Materiales(Producto prod)
        {
            Con = new DB();
            Ver_MaterialesModel model = new Ver_MaterialesModel();
            model.listaMateriales = Con.Select_Materiales();
            return View(model);
        }
        public ActionResult ELIMINAR_Material(Material mat) 
        {

            Con = new DB();
            Con.DELETE_Material(mat.ID_Material);
            return RedirectToAction("Ver_Materiales");
        }
        public ActionResult Insertar_Material(Material mat)
        {
            Con = new DB();
            List<Tipo_De_Material> TM = new List<Tipo_De_Material>();
            TM = Con.Select_Tipo_De_Material();
            ViewBag.TmaterialesList = new SelectList(TM, "ID_Tipo_Material", "Nombre_del_Tipo_de_Material");
            return View(mat);
        }
        public ActionResult Insertar_MaterialDB(Material mat)
        {
            Con = new DB();
            Con.Insert_Material(mat.ID_Tipo_De_Material,mat.Nombre_Material,mat.Precio_Por_Metro,mat.Especificaciones, mat.Proveedor);
            return RedirectToAction("Ver_Materiales");
        }

        public ActionResult Editar_Material(Material mat)
        {
            Con = new DB();
            List<Tipo_De_Material> TM = new List<Tipo_De_Material>();
            TM = Con.Select_Tipo_De_Material();
            var match = TM.FirstOrDefault(p => p.ID_Tipo_Material == mat.ID_Tipo_De_Material);
            if (match == null)
                ViewBag.TmaterialesList = new SelectList(TM, "ID_Tipo_Material", "Nombre_del_Tipo_de_Material");
            else 
                ViewBag.TmaterialesList = new SelectList(TM, "ID_Tipo_Material", "Nombre_del_Tipo_de_Material",mat.ID_Tipo_De_Material);
            return View(mat);
        }
        public ActionResult Editar_MaterialDB(Material mat)
        {
            Con = new DB();
            Con.Update_Material(mat.ID_Material,mat.ID_Tipo_De_Material, mat.Nombre_Material, mat.Precio_Por_Metro, mat.Especificaciones,mat.Proveedor);
            return RedirectToAction("Ver_Materiales");
        }
        public ActionResult Editar_Material_Ver_Productos_Que_lo_Usan(Material mat)
        {
            Con = new DB();
            IndxModel model = new IndxModel();
            List<Producto> Productos_Que_Usan_El_Material = new List<Producto>();
            model.listaPorcentajes_Runtimes = Actualizar_Precios();
            model.listaProductos = Productos_Que_Usan_El_Material = Con.Select_Productos_Que_Usan_Material(mat.ID_Material);
            model.listaMaterialesUsados = Con.Select_Materiales_Usados();
            return View(model);
        }
        public ActionResult Ver_Tipos_Materiales(Tipo_De_Material Tmat)
        {
            Con = new DB();
            Ver_TMaterial_Model model = new Ver_TMaterial_Model();
            model.Tmateriales = Con.Select_Tipo_De_Material();
            return View(model);
        }
        public ActionResult Insert_Tipo_Material(Tipo_De_Material Tmat)
        {
            return View(Tmat);
        }
        public ActionResult Insert_Tipo_MaterialDB(Tipo_De_Material Tmat)
        {
            Con = new DB();
            Con.Insert_Tipo_Material(Tmat.Nombre_del_Tipo_de_Material);
            return RedirectToAction("Ver_Tipos_Materiales");
        }
        public ActionResult Editar_Tipo_Material(Tipo_De_Material Tmat)
        {
            return View(Tmat);
        }
        public ActionResult Editar_Tipo_MaterialDB(Tipo_De_Material Tmat)
        {
            Con = new DB();
            Con.Update_Tipo_Material(Tmat.ID_Tipo_Material, Tmat.Nombre_del_Tipo_de_Material);
            return RedirectToAction("Ver_Tipos_Materiales");
        }
        public ActionResult DELETE_Tipo_Material(Tipo_De_Material Tmat)
        {
            Con = new DB();
            Con.DELETE_Tipo_Material(Tmat.ID_Tipo_Material);
            return RedirectToAction("Ver_Tipos_Materiales");
        }
    }
}