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
    public class datSucursal
    {
        #region sigleton

        private static readonly datSucursal _instancia = new datSucursal();
        public static datSucursal Instancia
        {
            get
            {
                return datSucursal._instancia;
            }
        }


        #endregion singleton

        public List<entSucursal> ListarSucursal()
        {
            SqlCommand cmd = null;
            List<entSucursal> lista = new List<entSucursal>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarSucursal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entSucursal suc = new entSucursal();
                    suc.idSucursal = Convert.ToInt32(dr["idSucursal"]);
                    suc.NombreSucursal = dr["NombreSucursal"].ToString();
                    suc.Direccion = dr["Direccion"].ToString();
                    suc.Pais = dr["Pais"].ToString();
                    suc.Departamento = dr["Departamento"].ToString();
                    suc.Distrito = dr["Distrito"].ToString();
                    suc.estSucursal = Convert.ToBoolean(dr["estSucursal"]);
                    lista.Add(suc);
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

        public Boolean InsertarSucursal(entSucursal suc)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarSucursal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NombreSucursal", suc.NombreSucursal);
                cmd.Parameters.AddWithValue("Direccion", suc.Direccion);
                cmd.Parameters.AddWithValue("Pais", suc.Pais);
                cmd.Parameters.AddWithValue("Departamento", suc.Departamento);
                cmd.Parameters.AddWithValue("Distrito", suc.Distrito);
                cmd.Parameters.AddWithValue("estSucursal", suc.estSucursal);
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
        public Boolean EditarSucursal(entSucursal suc)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarSucursal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idSucursal", suc.idSucursal);
                cmd.Parameters.AddWithValue("NombreSucursal", suc.NombreSucursal);
                cmd.Parameters.AddWithValue("Direccion", suc.Direccion);
                cmd.Parameters.AddWithValue("Pais", suc.Pais);
                cmd.Parameters.AddWithValue("Departamento", suc.Departamento);
                cmd.Parameters.AddWithValue("Distrito", suc.Distrito);
                cmd.Parameters.AddWithValue("estSucursal", suc.estSucursal);
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
        public Boolean DeshabilitarSucursal(entSucursal suc)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarSucursal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSucursal", suc.idSucursal);
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

    }
}
