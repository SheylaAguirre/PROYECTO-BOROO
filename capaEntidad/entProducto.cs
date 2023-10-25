using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entProducto
    {
        public int IDProducto { get; set; }
        public string Nombre {  get; set; }
        public float Costo {  get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEmision { get; set;}
        public DateTime FechaVencimiento { get; set;}
    }
}
