using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPresupuesto
    {
        #region sigleton
        private static readonly logPresupuesto _instancia = new logPresupuesto();
        public static logPresupuesto Instancia
        {
            get
            {
                return logPresupuesto._instancia;
            }
        }
        #endregion singleton
        public List<entPresupuesto> ListarPresupuesto()
        {
            return datPresupuesto.Instancia.ListarPresupuesto();
        }

        public void InsertarPresupuesto(entPresupuesto Pre)
        {
            datPresupuesto.Instancia.InsertarPresupuesto(Pre);
        }
        public void DeshabilitarPresupuesto(entPresupuesto Pre)
        {
            datPresupuesto.Instancia.DeshabilitarPresupuesto(Pre);
        }
    }
}
