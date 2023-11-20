using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRequerimiento
    {
        public int nroReq { get; set; }

        public int idProducto { get; set; }

        public int cantReq { get; set; }

        public DateTime fecReq { get; set; }

        public entProducto producto { get; set; }

    }
}
