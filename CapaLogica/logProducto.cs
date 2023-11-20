using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
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

        #endregion singleton

        #region metodos

        public List<entProducto> ListarProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }
        public void InsertarProducto(entProducto Alm)
        {
            datProducto.Instancia.InsertarProducto(Alm);
        }

        public void EditarProducto(entProducto Alm)
        {
            datProducto.Instancia.EditarProducto(Alm);
        }

        public void DeshabilitarProducto(entProducto Alm)
        {
            datProducto.Instancia.DeshabilitarProducto(Alm);
        }

        #endregion metodos


    }
}
