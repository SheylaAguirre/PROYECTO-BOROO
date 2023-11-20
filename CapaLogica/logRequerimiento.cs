using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRequerimiento
    {

        #region sigleton

        private static readonly logRequerimiento _instancia = new logRequerimiento();

        public static logRequerimiento Instancia
        {
            get
            {
                return logRequerimiento._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entRequerimiento> ListarRequerimiento()
        {
            return datRequerimiento.Instancia.ListarRequerimiento();
        }
        public void InsertarRequerimiento(entRequerimiento Req)
        {
            datRequerimiento.Instancia.InsertarRequerimiento(Req);
        }

        public void DeshabilitarRequerimiento(entRequerimiento Req)
        {
            datRequerimiento.Instancia.DeshabilitarRequerimiento(Req);
        }

        public entRequerimiento BuscarRequerimiento(int nroReq)
        {
           return datRequerimiento.Instancia.BuscarRequerimiento(nroReq);
        }
        #endregion metodos

    }
}
