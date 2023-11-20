using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int IDProveedor { get; set; }

        public string RUCProveedor { get; set; }

        public string Categoria { get; set; }

        public string NombreProveedor { get; set; }

        public string FormaPago { get; set; }

        public string DireccionProveedor { get; set; }

        public string TelefonoProveedor { get; set; }

        public string CorreoElectronicoProveedor { get; set; }

        public DateTime FechaRegistro { get; set; }

        public Boolean EstadoProveedor { get; set; }

    }
}
