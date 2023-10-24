using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entCotizacion
    {
        public int IDCotizacion { get; set; }
        public string Nombre {  get; set; }
        public string OrdenDeCompra { get; set;}
        public DateTime Fecha { get; set;}
        public float Total {  get; set; }
        public string Descripcion { get; set; }
    }
}
