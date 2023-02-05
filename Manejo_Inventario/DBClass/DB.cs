using System;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Manejo_Inventario.Models;
using System.Collections.Generic;


namespace Manejo_Inventario.DBClass
{
    public class DB
    {
        string conString = Environment.MachineName.ToString();
        SqlConnection cnx;

        public void ConexionDB()
        {
            try
            {
                cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=" + conString + ";Initial Catalog=WInventario;Integrated Security=true";
                cnx.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public List<Producto> Select_Productos()
        {
            List<Producto> PRODUCTOS;
            try
            {
                PRODUCTOS = new List<Producto>();
                using (SqlCommand cmd = new SqlCommand("spSelect_ALL_Productos", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            Producto producto = new Producto();
                            producto.ID_Producto = Convert.ToInt32(dr.GetValue(0));
                            producto.ID_Linea = Convert.ToInt32(dr.GetValue(1));
                            producto.Linea = dr.GetValue(2).ToString();
                            producto.Nombre_Producto = dr.GetValue(3).ToString();
                            producto.Descripcion = dr.GetValue(4).ToString();
                            producto.Duración = Convert.ToDecimal(dr.GetValue(5));
                            producto.Margen17 = Convert.ToDecimal(dr.GetValue(6));
                            producto.Margen2 = Convert.ToDecimal(dr.GetValue(7));
                            producto.Precio_Elaboracion = Convert.ToDecimal(dr.GetValue(8));
                            PRODUCTOS.Add(producto);
                        }
                    }
                    cnx.Close();
                    return PRODUCTOS;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public Producto Select_Producto_Mas_Nuevo()
        {
            Producto producto = new Producto();
            try
            {
                using (SqlCommand cmd = new SqlCommand("spSelect_Producto_Mas_Nuevo", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            producto.ID_Producto = Convert.ToInt32(dr.GetValue(0));
                            producto.ID_Linea = Convert.ToInt32(dr.GetValue(1));
                            producto.Linea = dr.GetValue(2).ToString();
                            producto.Nombre_Producto = dr.GetValue(3).ToString();
                            producto.Descripcion = dr.GetValue(4).ToString();
                            producto.Duración = Convert.ToDecimal(dr.GetValue(5));
                            producto.Margen17 = Convert.ToDecimal(dr.GetValue(6));
                            producto.Margen2 = Convert.ToDecimal(dr.GetValue(7));
                            producto.Precio_Elaboracion = Convert.ToDecimal(dr.GetValue(8));
                        }
                    }
                    cnx.Close();
                    return producto;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }

        public void Insert_Producto(int ID_Linea, string Nombre_Producto,decimal Duracion_Elaboracion_Producto, string Descripcion_Producto)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spInsert_Producto", cnx))
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Linea", ID_Linea));
                    if (!String.IsNullOrEmpty(Nombre_Producto))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Nombre_Producto", Nombre_Producto));
                    }
                    else { cmd.Parameters.Add(new SqlParameter("@Nombre_Producto", " ")); }
                    cmd.Parameters.Add(new SqlParameter("@Duracion_Elaboracion_Producto", Duracion_Elaboracion_Producto));
                    if (!String.IsNullOrEmpty(Descripcion_Producto))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Descripcion_Producto", Descripcion_Producto));
                    }
                    else { cmd.Parameters.Add(new SqlParameter("@Descripcion_Producto", " ")); }
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public void Insert_Material_Usado(int ID_Producto, int ID_Material, decimal Cantidad_Usada,string Detalle)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spInsert_Material_Usado", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Producto", ID_Producto));
                    cmd.Parameters.Add(new SqlParameter("@ID_Material", ID_Material));
                    cmd.Parameters.Add(new SqlParameter("@Cantidad_Usada", Cantidad_Usada));
                    if (!String.IsNullOrEmpty(Detalle))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Detalle", Detalle));
                    }
                    else { cmd.Parameters.Add(new SqlParameter("@Detalle", " ")); }
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public List<Material_Usado> Select_Materiales_Usados()
        {
            List<Material_Usado> materialesUsados;
            try
            {
                materialesUsados = new List<Material_Usado>();
                using (SqlCommand cmd = new SqlCommand("spSelect_Material_Usado", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            Material_Usado material = new Material_Usado();

                            material.ID_Mat_Usado = Convert.ToInt32(dr.GetValue(0));
                            material.ID_Material = Convert.ToInt32(dr.GetValue(1));
                            material.ID_Producto = Convert.ToInt32(dr.GetValue(2));
                            material.Nombre_Material = dr.GetValue(3).ToString();
                            material.Candtidad_Metros_Unidades_Usado = Convert.ToDecimal(dr.GetValue(4));
                            material.Precio_Metro_Unidad = Convert.ToDecimal(dr.GetValue(5));
                            material.Detalle = dr.GetValue(6).ToString();
                            materialesUsados.Add(material);
                        }
                    }
                    cnx.Close();
                    return materialesUsados;
                }
            }
            catch (Exception)
            {
                cnx.Close();
                throw;
            }
        }
        public void Update_Tipo_Material(int ID, string Nombre_Tipo_Material)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spUpdate_Tipo_Material", cnx))
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Tipo_Material", ID));
                    cmd.Parameters.Add(new SqlParameter("@Nombre_Tipo_Material", Nombre_Tipo_Material));
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public void Insert_Tipo_Material(string Nombre_Tipo_Material)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spInsertar_Tipo_Material", cnx))
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Nombre_Tipo_Material", Nombre_Tipo_Material));
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }


        public void DELETE_Tipo_Material(int ID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spDELETE_Tipo_Material", cnx))
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Tipo_Material", ID));
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }

        public List<Tipo_De_Material> Select_Tipo_De_Material()
        {
            List<Tipo_De_Material> Tmateriales = new List<Tipo_De_Material>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("spSelect_Tipo_Material", cnx))
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            Tipo_De_Material Tmaterial = new Tipo_De_Material();
                            Tmaterial.ID_Tipo_Material = Convert.ToInt32(dr.GetValue(0));
                            Tmaterial.Nombre_del_Tipo_de_Material = dr.GetValue(1).ToString();
                            Tmateriales.Add(Tmaterial);
                        }
                    }
                    cnx.Close();
                    return Tmateriales;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public List<Material> Select_Materiales()
        {
            List<Material> MATERIALES;
            try
            {
                MATERIALES = new List<Material>();
                using (SqlCommand cmd = new SqlCommand("spSelect_Materiales", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            Material material = new Material();
                            material.ID_Material = Convert.ToInt32(dr.GetValue(0));
                            material.Nombre_Material = dr.GetValue(1).ToString();
                            material.Precio_Por_Metro = Convert.ToDecimal(dr.GetValue(2));
                            material.Especificaciones = dr.GetValue(3).ToString();
                            material.Fecha_Actualizada = dr.GetValue(4).ToString();
                            material.ID_Tipo_De_Material = Convert.ToInt32(dr.GetValue(5));
                            material.Nombre_del_Tipo_de_Material = dr.GetValue(6).ToString();  
                            material.Proveedor = dr.GetValue(7).ToString();
                            MATERIALES.Add(material);
                        }
                    }
                    cnx.Close();
                    return MATERIALES;
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public List<Producto> Select_Productos_Que_Usan_Material(int ID)
        {
            List<Producto> PRODUCTOS;
            try
            {

                PRODUCTOS = new List<Producto>();
                using (SqlCommand cmd = new SqlCommand("spSelect_Productos_Por_Material", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Material", ID));
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            Producto producto = new Producto();
                            producto.ID_Producto = Convert.ToInt32(dr.GetValue(0));
                            producto.ID_Linea = Convert.ToInt32(dr.GetValue(1));
                            producto.Linea = dr.GetValue(2).ToString();
                            producto.Nombre_Producto = dr.GetValue(3).ToString();
                            producto.Descripcion = dr.GetValue(4).ToString();
                            producto.Duración = Convert.ToDecimal(dr.GetValue(5));
                            producto.Margen17 = Convert.ToDecimal(dr.GetValue(6));
                            producto.Margen2 = Convert.ToDecimal(dr.GetValue(7));
                            producto.Precio_Elaboracion = Convert.ToDecimal(dr.GetValue(8));
                            PRODUCTOS.Add(producto);
                        }
                    }
                    cnx.Close();
                    return PRODUCTOS;
                }                
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public List<PorcentajeTienda_PorcentajePer> Select_SYS_Setings()
        {
            try
            {
                List<PorcentajeTienda_PorcentajePer> list = new List<PorcentajeTienda_PorcentajePer>();
                using (SqlCommand cmd = new SqlCommand("spSelect_SYS_Settings", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            PorcentajeTienda_PorcentajePer Info = new PorcentajeTienda_PorcentajePer();
                            Info.ID_Linea = Convert.ToInt32(dr.GetValue(0));
                            Info.ID_Sys_Settings = Convert.ToInt32(dr.GetValue(1));
                            Info.Nombre_Linea = dr.GetValue(2).ToString();
                            Info.Porcentaje_Tienda = Convert.ToDecimal(dr.GetValue(3));
                            Info.Porcentaje_Personalización = Convert.ToDecimal(dr.GetValue(4));
                            Info.Precio_Por_Hora = Convert.ToDecimal(dr.GetValue(5));
                            list.Add(Info);
                        }
                    }
                    cnx.Close();
                    return list;
                } 
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public List<MLineas> Select_Lineas()
        {
            List<MLineas> Lineas = new List<MLineas>(); 
            try
            {
                 using (SqlCommand cmd = new SqlCommand("spSelect_Lineas", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            MLineas linea = new MLineas();
                            linea.ID_Linea = Convert.ToInt32(dr.GetValue(0));
                            linea.Nombre_Linea = dr.GetValue(1).ToString();
                            Lineas.Add(linea);
                        }
                    }
                    cnx.Close();
                    return Lineas;
                } 
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public void Update_Lineas(int ID, string Nombre_Linea)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spUpdate_Linea", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Linea", ID));
                    if (!String.IsNullOrEmpty(Nombre_Linea))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Nombre_Linea", Nombre_Linea));
                    }
                    else { cmd.Parameters.Add(new SqlParameter("@Nombre_Linea", "SIN NOMBRE")); }
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }

        public void Insert_Linea(int ID_SYS, string Nombre_Linea)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spInsert_Linea", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_SYS", ID_SYS));
                    if (!String.IsNullOrEmpty(Nombre_Linea))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Nombre_Linea", Nombre_Linea));
                    }
                    else { cmd.Parameters.Add(new SqlParameter("@Nombre_Linea", "SIN NOMBRE")); }
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public void DELETE_Lineas(int ID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spDELETE_Linea", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Linea", ID));
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public void Update_SYS_Settings(int ID, decimal Porcentaje_Tienda, decimal Porcentaje_Personalización, decimal Precio_Por_Hora)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spUpdate_SYS_Settings", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_SYS_Settings", ID));
                    cmd.Parameters.Add(new SqlParameter("@Porcentaje_Tienda", Porcentaje_Tienda));
                    cmd.Parameters.Add(new SqlParameter("@Porcentaje_Personalización", Porcentaje_Personalización));
                    cmd.Parameters.Add(new SqlParameter("@Precio_Por_Hora", Precio_Por_Hora));
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }

        public void Update_Precio_Productos(int ID, decimal Precio_Fabricacion, decimal Margen_17, decimal Margen2) 
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spUpdate_Precios_Producto", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Producto", ID));
                    cmd.Parameters.Add(new SqlParameter("@Precio_Fabricacion", Precio_Fabricacion));
                    cmd.Parameters.Add(new SqlParameter("@Margen_17", Margen_17));
                    cmd.Parameters.Add(new SqlParameter("@Margen_2", Margen2));
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public void Update_Producto(int ID, int ID_Linea, string Nombre_Producto, decimal Duracion_Elaboracion_Producto, string Descripcion_Producto)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spUpdate_Producto", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Producto", ID));
                    cmd.Parameters.Add(new SqlParameter("@ID_Linea", ID_Linea));
                    cmd.Parameters.Add(new SqlParameter("@Nombre_Producto", Nombre_Producto));
                    cmd.Parameters.Add(new SqlParameter("@Duracion_Elaboracion_Producto", Duracion_Elaboracion_Producto));
                    if (!String.IsNullOrEmpty(Descripcion_Producto))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Descripcion_Producto", Descripcion_Producto));
                    }
                    else { cmd.Parameters.Add(new SqlParameter("@Descripcion_Producto", " ")); }

                    cmd.ExecuteNonQuery();
                    cnx.Close();
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public void DELETE_Producto(int ID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spDelete_Producto", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Producto", ID));
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }

        public void DELETE_Material_Usado(int ID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spDelete_Material_Usado", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Material_Usado", ID));
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public void Update_Material(int ID,int ID_Tipo_Material, string Nombre_Material, decimal Precio_Por_Metro, string Especificaciones, string Proveedor)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spUpdate_Material", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Material", ID));
                    cmd.Parameters.Add(new SqlParameter("@ID_Tipo_Material", ID_Tipo_Material));
                    if (!String.IsNullOrEmpty(Proveedor))
                        cmd.Parameters.Add(new SqlParameter("@Proveedor", Proveedor));
                    else { cmd.Parameters.Add(new SqlParameter("@Proveedor", " ")); }
                    cmd.Parameters.Add(new SqlParameter("@Nombre_Material", Nombre_Material));
                    cmd.Parameters.Add(new SqlParameter("@Precio_Por_Metro", Precio_Por_Metro));
                    if (!String.IsNullOrEmpty(Especificaciones))
                        cmd.Parameters.Add(new SqlParameter("@Especificaciones", Especificaciones));
                    else { cmd.Parameters.Add(new SqlParameter("@Especificaciones", " ")); }
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }

        public void Insert_Material(int ID_Tipo_Material, string Nombre_Material, decimal Precio_Por_Metro, string Especificaciones, string Proveedor)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spInsert_Material", cnx)) 
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID_Tipo_Material", ID_Tipo_Material));
                    if (!String.IsNullOrEmpty(Proveedor))
                        cmd.Parameters.Add(new SqlParameter("@Proveedor", Proveedor));
                    else { cmd.Parameters.Add(new SqlParameter("@Proveedor", " ")); }
                    cmd.Parameters.Add(new SqlParameter("@Nombre_Material", Nombre_Material));
                    cmd.Parameters.Add(new SqlParameter("@Precio_Por_Metro", Precio_Por_Metro));
                    if (!String.IsNullOrEmpty(Especificaciones))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Especificaciones", Especificaciones));
                    }
                    else { cmd.Parameters.Add(new SqlParameter("@Especificaciones", " ")); }
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }

        public void DELETE_Material(int ID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spDELETE_Material", cnx)) 
                {
                ConexionDB();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID_Material", ID));
                cmd.ExecuteNonQuery();
                cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public void Insert_SYS()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spInsert_SYS", cnx))
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                throw;
            }
        }
        public int Select_SYS_ID_Mas_Nuevo()
        {
            int ID = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("spSelect_SYS_ID_Mas_Nuevo", cnx))
                {
                    ConexionDB();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            ID = Convert.ToInt32(dr.GetValue(0));
                        }
                    }
                    cnx.Close();
                    return ID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                cnx.Close();
                return 0;
            }
        }
    }
}
