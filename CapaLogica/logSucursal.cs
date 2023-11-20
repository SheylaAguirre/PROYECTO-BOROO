using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logSucursal
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logSucursal _instancia = new logSucursal();
        //privado para evitar la instanciación directa
        public static logSucursal Instancia
        {
            get
            {
                return logSucursal._instancia;
            }
        }
        #endregion singleton

        public List<entSucursal> ListarSucursal()
        {
            return datSucursal.Instancia.ListarSucursal();
        }
        public void InsertarSucursal(entSucursal suc)
        {
            datSucursal.Instancia.InsertarSucursal(suc);
        }

        public void EditarSucursal(entSucursal suc)
        {
            datSucursal.Instancia.EditarSucursal(suc);
        }

        public void DeshabilitarSucursal(entSucursal suc)
        {
            datSucursal.Instancia.DeshabilitarSucursal(suc);
        }

        
    }
}
