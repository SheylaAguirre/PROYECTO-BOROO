using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int idProducto { get; set; }

        public string nombreProducto { get; set; }

        public string Categoria { get; set; }

        public int IDProveedor { get; set; }

        public int stock { get; set; }

        public float precioProducto { get; set; }

        public string tamaño { get; set; }

        public DateTime FecVencimiento { get; set; }

        public Boolean estProducto { get; set; }

    }
}
