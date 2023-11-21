using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class DatEntrada
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly DatEntrada _instancia = new DatEntrada();
        //privado para evitar la instanciación directa
        public static DatEntrada Instancia
        {
            get
            {
                return DatEntrada._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<EntEntrada> ListarEntrada()
        {
            SqlCommand cmd = null;
            List<EntEntrada> lista = new List<EntEntrada>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaEntradas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntEntrada Cli = new EntEntrada();
                    Cli.IDEntrada = Convert.ToInt32(dr["IDEntrada"]);
                    Cli.idProducto = Convert.ToInt32(dr["idProducto"]);
                    Cli.Cant_entradas = Convert.ToInt32(dr["Cant_entradas"].ToString());
                    Cli.NroDocCal = dr["NroDocCal"].ToString();
                    Cli.idSucursal = Convert.ToInt32(dr["idSucursal"]);
                    Cli.IDProveedor = Convert.ToInt32(dr["IDProveedor"]);
                    Cli.fecRegProduct = Convert.ToDateTime(dr["fecRegProduct"]);
                    lista.Add(Cli);
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

        public Boolean InsertarEntrada(EntEntrada Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaEntradas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", Cli.idProducto);
                cmd.Parameters.AddWithValue("@Cant_entradas", Cli.Cant_entradas);
                cmd.Parameters.AddWithValue("@NroDocCal", Cli.NroDocCal);
                cmd.Parameters.AddWithValue("@idSucursal", Cli.idSucursal);
                cmd.Parameters.AddWithValue("@IDProveedor", Cli.IDProveedor);
                cmd.Parameters.AddWithValue("@fecRegProduct", Cli.fecRegProduct);
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
        public Boolean DeshabilitarEntradas(EntEntrada Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabiltarEntradas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDEntrada", Cli.IDEntrada);
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
        #endregion
    }
}
