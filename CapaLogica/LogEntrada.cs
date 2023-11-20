using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogEntrada
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogEntrada _instancia = new LogEntrada();
        //privado para evitar la instanciación directa
        public static LogEntrada Instancia
        {
            get
            {
                return LogEntrada._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<EntEntrada> ListarEntrada()
        {
            return DatEntrada.Instancia.ListarEntrada();
        }
        ///inserta
        public void InsertaEntrada(EntEntrada Cli)
        {
            DatEntrada.Instancia.InsertarEntrada(Cli);
        }

        public void DeshabilitarEntrada(EntEntrada Cli)
        {
            DatEntrada.Instancia.DeshabilitarEntradas(Cli);
        }

        #endregion singleton

    }
}
