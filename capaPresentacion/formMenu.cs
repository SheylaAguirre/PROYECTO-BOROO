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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formOrdenCompra formOrdenCompra = new formOrdenCompra();
            formOrdenCompra.ShowDialog();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formPresupuesto formPresupuesto = new formPresupuesto();
            formPresupuesto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formMantenedorProveedor formMantenedorProveedor = new formMantenedorProveedor();
            formMantenedorProveedor.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formMantenedorProducto formMantenedorProducto = new formMantenedorProducto();
            formMantenedorProducto.ShowDialog();
        }
    }
}
