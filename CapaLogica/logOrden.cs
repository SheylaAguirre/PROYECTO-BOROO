using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrden
    {

        #region sigleton

        private static readonly logOrden _instancia = new logOrden();

        public static logOrden Instancia
        {
            get
            {
                return logOrden._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entOrden> ListarOrden()
        {
            return datOrden.Instancia.ListarOrden();
        }
        public void InsertarOrden(entOrden Or)
        {
            datOrden.Instancia.InsertarOrden(Or);
        }

        public void DeshabilitarOrden(entOrden Or)
        {
            datOrden.Instancia.DeshabilitarOrden(Or);
        }

        #endregion metodos
    }
}
