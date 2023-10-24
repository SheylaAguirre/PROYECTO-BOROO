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
    public class datCotizacion
    {
        #region sigleton
        private static readonly datCotizacion _instancia = new datCotizacion();
        public static datCotizacion Instancia
        {
            get
            {
                return datCotizacion._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entCotizacion> ListarCotizacion()
        {
            SqlCommand cmd = null;
            List<entCotizacion> lista = new List<entCotizacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("LeerCotizacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCotizacion Pro = new entCotizacion();
                    Pro.IDCotizacion = Convert.ToInt32(dr["IDCotizacion"]);
                    Pro.Nombre = dr["Nombre"].ToString();
                    Pro.OrdenDeCompra = dr["OrdenDeCompra"].ToString();
                    Pro.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    Pro.Total = (float)Convert.ToDecimal(dr["Total"]);
                    Pro.Descripcion = dr["Descripcion"].ToString();
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

        public Boolean InsertarCotizacion(entCotizacion Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("CrearCotizacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Pro.Nombre);
                cmd.Parameters.AddWithValue("@OrdenDeCompra", Pro.OrdenDeCompra);
                cmd.Parameters.AddWithValue("@Fecha", Pro.Fecha);
                cmd.Parameters.AddWithValue("@Total", Pro.Total);
                cmd.Parameters.AddWithValue("@Descripcion", Pro.Descripcion);

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

        public Boolean DeshabilitarCotizacion(entCotizacion Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BorrarCotizacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCotizacion", Pro.IDCotizacion);
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
