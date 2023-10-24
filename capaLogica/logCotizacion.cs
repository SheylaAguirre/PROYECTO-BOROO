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
    public class logCotizacion
    {
        #region sigleton
        private static readonly logCotizacion _instancia = new logCotizacion();
        public static logCotizacion Instancia
        {
            get
            {
                return logCotizacion._instancia;
            }
        }
        #endregion sigleton

        #region metodos
        public List<entCotizacion> ListarCotizacion()
        {
            return datCotizacion.Instancia.ListarCotizacion();
        }
        public void InsertarCotizacion(entCotizacion Pro)
        {
            datCotizacion.Instancia.InsertarCotizacion(Pro);
        }

        public void DeshabilitarCotizacion(entCotizacion Pro)
        {
            datCotizacion.Instancia.DeshabilitarCotizacion(Pro);
        }

        #endregion metodos

    }
}
