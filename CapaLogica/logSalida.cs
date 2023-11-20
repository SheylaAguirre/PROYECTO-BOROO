using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logSalida
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logSalida _instancia = new logSalida();
        //privado para evitar la instanciación directa
        public static logSalida Instancia
        {
            get
            {
                return logSalida._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        public List<entSalida> ListarSalida()
        {
            return datSalida.Instancia.ListarSalida();
        }
        ///inserta
        public void InsertaCliente(entSalida sali)
        {
            datSalida.Instancia.InsertarDistri(sali);
        }

        public void DeshabilitarSalida(entSalida sali)
        {
            datSalida.Instancia.DeshabilitarSalida(sali);
        }
        #endregion metodos
    }
}
