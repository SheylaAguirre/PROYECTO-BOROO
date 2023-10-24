using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class formOrdenCompra : Form
    {
        public formOrdenCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMantenedorProveedor formProveedor = new formMantenedorProveedor();
            formProveedor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMantenedorCotizacion formCotizacion = new formMantenedorCotizacion();
            formCotizacion.Show();
        }
    }
}
