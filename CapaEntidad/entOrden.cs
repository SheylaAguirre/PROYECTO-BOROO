using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrden
    {
        public int nroOrden { get; set; }

        public DateTime fecOrden { get; set; }

        public string nroCotizacion { get; set; }

        public int IDProveedor { get; set; }

        public int nroReq { get; set; }

    }
}
