using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenedor_de_almacenamiento
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            MantenedorProducto mantenedorProducto = new MantenedorProducto();
            mantenedorProducto.Show();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            FormOrdenCompra formOrdenCompra = new FormOrdenCompra();
            formOrdenCompra.Show();
        }

        private void btnRequerimiento_Click(object sender, EventArgs e)
        {
            FormRequerimiento formRequerimiento = new FormRequerimiento();
            formRequerimiento.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            MantendorProveedor mantendorProveedor = new MantendorProveedor();
            mantendorProveedor.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            FormEntrada formEntrada = new FormEntrada();
            formEntrada.Show();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            FormPresupuesto formPresupuesto = new FormPresupuesto();
            formPresupuesto.Show();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            FormSalida formSalida = new FormSalida();
            formSalida.Show();
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            MantenedorSucursal mantenedorSucursal = new MantenedorSucursal();
            mantenedorSucursal.Show();
        }
    }
}
