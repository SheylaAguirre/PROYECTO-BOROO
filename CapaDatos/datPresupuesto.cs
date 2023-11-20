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
    public class datPresupuesto
    {
        #region sigleton

        private static readonly datPresupuesto _instancia = new datPresupuesto();
        //privado para evitar la instanciación directa
        public static datPresupuesto Instancia
        {
            get
            {
                return datPresupuesto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entPresupuesto> ListarPresupuesto()
        {
            SqlCommand cmd = null;
            List<entPresupuesto> lista = new List<entPresupuesto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaPresupuesto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPresupuesto Pre = new entPresupuesto();
                    Pre.IdPresupuesto = Convert.ToInt32(dr["IdPresupuesto"]);
                    Pre.Factura = dr["Factura"].ToString();
                    Pre.IDProveedor = Convert.ToInt32(dr["IDProveedor"]);
                    Pre.Monto = Convert.ToSingle(dr["Monto"]);
                    Pre.MetodoDePago = dr["MetodoDePago"].ToString();
                    Pre.Saldo = Convert.ToInt32(dr["Saldo"]);
                    Pre.dtp_fecha = Convert.ToDateTime(dr["dtp_fecha"]);
                    lista.Add(Pre);
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

        /////////////////////////Inserta Presupuesto
        public Boolean InsertarPresupuesto(entPresupuesto Pre)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPresupuesto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Factura", Pre.Factura);
                cmd.Parameters.AddWithValue("@IDProveedor", Pre.IDProveedor);
                cmd.Parameters.AddWithValue("@Monto", Pre.Monto);
                cmd.Parameters.AddWithValue("@MetodoDePago", Pre.MetodoDePago);
                cmd.Parameters.AddWithValue("@Saldo", Pre.Saldo);
                cmd.Parameters.AddWithValue("@dtp_fecha", Pre.dtp_fecha);
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

        ///////////////////Deshabilita Presupuesto
        public Boolean DeshabilitarPresupuesto(entPresupuesto Pre)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarPresupuesto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPresupuesto", Pre.IdPresupuesto);
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
