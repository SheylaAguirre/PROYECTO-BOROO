using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datProducto
    {
        #region sigleton
        private static readonly datProducto _instancia = new datProducto();
        public static datProducto Instancia
        {
            get
            {
                return datProducto._instancia;
            }
        }

        #endregion singleton

        #region metodos
        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto Alm = new entProducto();
                    Alm.idProducto = Convert.ToInt32(dr["idProducto"]);
                    Alm.nombreProducto = dr["nombreProducto"].ToString();
                    Alm.Categoria = dr["Categoria"].ToString();
                    Alm.IDProveedor = Convert.ToInt32(dr["IDProveedor"]);
                    Alm.stock = Convert.ToInt32(dr["stock"]);
                    Alm.precioProducto = Convert.ToSingle(dr["precioProducto"]);
                    Alm.tamaño = dr["tamaño"].ToString();
                    Alm.FecVencimiento = Convert.ToDateTime(dr["FecVencimiento"]);
                    Alm.estProducto = Convert.ToBoolean(dr["estProducto"]);
                    lista.Add(Alm);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public Boolean InsertarProducto(entProducto Alm)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreProducto", Alm.nombreProducto);
                cmd.Parameters.AddWithValue("@Categoria", Alm.Categoria);
                cmd.Parameters.AddWithValue("@IDProveedor", Alm.IDProveedor);
                cmd.Parameters.AddWithValue("@stock", Alm.stock);
                cmd.Parameters.AddWithValue("@precioProducto", Alm.precioProducto);
                cmd.Parameters.AddWithValue("@tamaño", Alm.tamaño);
                cmd.Parameters.AddWithValue("@FecVencimiento", Alm.FecVencimiento);
                cmd.Parameters.AddWithValue("@estProducto", Alm.estProducto);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) 
                { 
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarProducto(entProducto Alm)
        {
            
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", Alm.idProducto);
                cmd.Parameters.AddWithValue("@nombreProducto", Alm.nombreProducto);
                cmd.Parameters.AddWithValue("@Categoria", Alm.Categoria);
                cmd.Parameters.AddWithValue("@IDProveedor", Alm.IDProveedor);
                cmd.Parameters.AddWithValue("@stock", Alm.stock);
                cmd.Parameters.AddWithValue("@precioProducto", Alm.precioProducto);
                cmd.Parameters.AddWithValue("@tamaño", Alm.tamaño);
                cmd.Parameters.AddWithValue("@FecVencimiento", Alm.FecVencimiento);
                cmd.Parameters.AddWithValue("@estProducto", Alm.estProducto);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarProducto(entProducto Alm)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", Alm.idProducto);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        #endregion metodos

    }

      
    }
