using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entSalida
    {
        public int IdSalida { get; set; }

        public int idProducto { get; set; }

        public int Cantidad { get; set; }

        public int idSucursal { get; set; }

        public string DocSalida { get; set; }

        public DateTime FecSalida { get; set; }
    }
}
