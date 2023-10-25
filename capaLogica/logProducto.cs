using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using System.Data.SqlClient;
using capaDatos;

namespace capaLogica
{
    public class logProducto
    {
        #region sigleton
        private static readonly logProducto _instancia = new logProducto();
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion sigleton

        #region metodos
        public List<entProducto> ListarProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }
        public void InsertarProducto(entProducto Pro)
        {
            datProducto.Instancia.InsertarProducto(Pro);
        }

        public void DeshabilitarProducto(entProducto Pro)
        {
            datProducto.Instancia.DeshabilitarProducto(Pro);
        }

        public void EditarProducto(entProducto Pro)
        {
            datProducto.Instancia.EditarProducto(Pro);
        }

        #endregion metodos

    }
}
