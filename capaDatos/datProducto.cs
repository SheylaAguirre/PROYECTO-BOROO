using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
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
                cmd = new SqlCommand("ObtenerProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto Pro = new entProducto();
                    Pro.IDProducto = Convert.ToInt32(dr["IDProducto"]);
                    Pro.Nombre = dr["Nombre"].ToString();
                    Pro.Costo = (float)Convert.ToDecimal(dr["Costo"]);
                    Pro.Descripcion = dr["Descripcion"].ToString();
                    Pro.FechaEmision = Convert.ToDateTime(dr["FechaEmision"]);
                    Pro.FechaVencimiento = Convert.ToDateTime(dr["FechaVencimiento"]);
                    lista.Add(Pro);
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

        public Boolean InsertarProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Pro.Nombre);
                cmd.Parameters.AddWithValue("@Costo", Pro.Costo);
                cmd.Parameters.AddWithValue("@Descripcion", Pro.Descripcion);
                cmd.Parameters.AddWithValue("@FechaEmision", Pro.FechaEmision);
                cmd.Parameters.AddWithValue("@FechaVencimiento", Pro.FechaVencimiento);

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

        public Boolean DeshabilitarProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BorrarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDProducto", Pro.IDProducto);
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

        public Boolean EditarProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ActualizarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDProducto", Pro.IDProducto);
                cmd.Parameters.AddWithValue("@Nombre", Pro.Nombre);
                cmd.Parameters.AddWithValue("@Costo", Pro.Costo);
                cmd.Parameters.AddWithValue("@Descripcion", Pro.Descripcion);
                cmd.Parameters.AddWithValue("@FechaEmision", Pro.FechaEmision);
                cmd.Parameters.AddWithValue("@FechaVencimiento", Pro.FechaVencimiento);
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

        #endregion metodos
    }
}
