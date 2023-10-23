using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entProveedor
    {
        public int IDProveedor { get; set; }

        public string RUCProveedor { get; set; }

        public string Categoria { get; set; }

        public string NombreProveedor { get; set; }

        public string FormaPago { get; set; }

        public string TelefonoProveedor { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
