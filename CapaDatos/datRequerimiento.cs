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
    public class datRequerimiento
    {
        #region sigleton
        private static readonly datRequerimiento _instancia = new datRequerimiento();
        public static datRequerimiento Instancia
        {
            get
            {
                return datRequerimiento._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entRequerimiento> ListarRequerimiento()
        {
            SqlCommand cmd = null;
            List<entRequerimiento> lista = new List<entRequerimiento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRequerimiento Req = new entRequerimiento();
                    Req.nroReq = Convert.ToInt32(dr["nroReq"]);
                    Req.idProducto = Convert.ToInt32(dr["idProducto"]); ///
                    Req.cantReq = Convert.ToInt32(dr["cantReq"]);
                    Req.fecReq = Convert.ToDateTime(dr["fecReq"]);
                    lista.Add(Req);
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

        public Boolean InsertarRequerimiento(entRequerimiento Req)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", Req.idProducto);
                cmd.Parameters.AddWithValue("@cantReq", Req.cantReq);
                cmd.Parameters.AddWithValue("@fecReq", Req.fecReq);
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

        public Boolean DeshabilitarRequerimiento(entRequerimiento Req)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nroReq", Req.nroReq);
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

        public entRequerimiento BuscarRequerimiento(int nroReq)
        {
            SqlCommand cmd = null;
            entRequerimiento Req = new entRequerimiento();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarNroReq", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmintnroReq", nroReq);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) 
                {
                    Req.nroReq = Convert.ToInt32(dr["nroReq"]);
                    Req.idProducto = Convert.ToInt32(dr["idProducto"]);
                    entProducto producto = new entProducto();
                    producto.nombreProducto = dr["nombreProducto"].ToString();
                    Req.producto = producto;
                    Req.cantReq = Convert.ToInt32(dr["cantReq"]);
                    Req.fecReq = Convert.ToDateTime(dr["fecReq"]);
                }
                
            }
            catch (Exception e )
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Req;

        }


        #endregion metodos

    }
}
