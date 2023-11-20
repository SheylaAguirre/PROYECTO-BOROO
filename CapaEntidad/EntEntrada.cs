using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EntEntrada
    {
        public int IDEntrada { get; set; }

        public int idProducto { get; set; }
        public int Cant_entradas { get; set; }
        public string NroDocCal { get; set; }

        public int idSucursal { get; set; }

        public int IDProveedor { get; set; }
        
        public DateTime fecRegProduct { get; set; }
    }
}
