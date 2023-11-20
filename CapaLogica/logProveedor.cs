using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {

        #region sigleton

        private static readonly logProveedor _instancia = new logProveedor();

        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }
        public void InsertarProveedor(entProveedor Pro)
        {
            datProveedor.Instancia.InsertarProveedor(Pro);
        }

        public void EditarProveedor(entProveedor Pro)
        {
            datProveedor.Instancia.EditarProveedor(Pro);
        }

        public void DeshabilitarProveedor(entProveedor Pro)
        {
            datProveedor.Instancia.DeshabilitarProveedor(Pro);
        }

        #endregion metodos

    }
}
