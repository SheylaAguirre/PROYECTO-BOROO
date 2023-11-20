using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPresupuesto
    {
        public int IdPresupuesto { get; set; }
        
        public string Factura { get; set; }

        public int IDProveedor { get; set; }

        public float Monto { get; set; }

        public string MetodoDePago { get; set; }

        public int Saldo { get; set; }
        
        public DateTime dtp_fecha { get; set; }

    }
}
