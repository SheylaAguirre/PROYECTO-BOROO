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
    public class datSalida
    {
        #region sigleton

        private static readonly datSalida _instancia = new datSalida();
        public static datSalida Instancia
        {
            get
            {
                return datSalida._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Distribucion
        public List<entSalida> ListarSalida()
        {
            SqlCommand cmd = null;
            List<entSalida> lista = new List<entSalida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entSalida Salida = new entSalida();
                    Salida.IdSalida = Convert.ToInt32(dr["IdSalida"]);
                    Salida.idProducto = Convert.ToInt32(dr["idProducto"]);
                    Salida.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    Salida.idSucursal = Convert.ToInt32(dr["idSucursal"]);
                    Salida.DocSalida = dr["DocSalida"].ToString();
                    Salida.FecSalida = Convert.ToDateTime(dr["FecSalida"]);
                    lista.Add(Salida);
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
        /////////////////////////InsertaDistribucion
        public Boolean InsertarDistri(entSalida salida)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", salida.idProducto);
                cmd.Parameters.AddWithValue("@Cantidad", salida.Cantidad);
                cmd.Parameters.AddWithValue("@idSucursal", salida.idSucursal);
                cmd.Parameters.AddWithValue("@DocSalida", salida.DocSalida);
                cmd.Parameters.AddWithValue("@FecSalida", salida.FecSalida);
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

        public Boolean DeshabilitarSalida(entSalida sali)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSalida", sali.IdSalida);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return delete;
        }
        #endregion metodos

    }
}
