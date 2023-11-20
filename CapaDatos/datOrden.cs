using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datOrden
    {

        #region sigleton
        private static readonly datOrden _instancia = new datOrden();
        public static datOrden Instancia
        {
            get
            {
                return datOrden._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entOrden> ListarOrden()
        {
            SqlCommand cmd = null;
            List<entOrden> lista = new List<entOrden>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrden Or = new entOrden();
                    Or.nroOrden = Convert.ToInt32(dr["nroOrden"]);
                    Or.fecOrden = Convert.ToDateTime(dr["fecOrden"]);
                    Or.nroCotizacion = dr["nroCotizacion"].ToString(); ;
                    Or.IDProveedor = Convert.ToInt32(dr["IDProveedor"]);
                    Or.nroReq = Convert.ToInt32(dr["nroReq"]);

                    lista.Add(Or);
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


        public Boolean InsertarOrden(entOrden Or)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecOrden", Or.fecOrden);
                cmd.Parameters.AddWithValue("@nroCotizacion", Or.nroCotizacion);
                cmd.Parameters.AddWithValue("@IDProveedor", Or.IDProveedor);
                cmd.Parameters.AddWithValue("@nroReq", Or.nroReq);
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

        public Boolean DeshabilitarOrden(entOrden or)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nroOrden", or.nroOrden);
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
