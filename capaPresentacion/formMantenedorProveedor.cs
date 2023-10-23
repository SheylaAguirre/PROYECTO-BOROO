using capaEntidad;
using capaLogica;
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
    public partial class formMantenedorProveedor : Form
    {
        public void listarProveedor()
        {
            dgvMostrarProveedores.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        public formMantenedorProveedor()
        {
            InitializeComponent();
            listarProveedor();
        }

        void limpiarTextBoxes()
        {
            txtRucProveedor.Text = "";
            txtCategoriaProveedor.Text = "";
            txtProveedorNombre.Text = "";
            txtFormaDePagoProveedor.Text = "";
            txtBoxTelefonoProveedor.Text = "";
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.RUCProveedor = txtRucProveedor.Text.Trim();
                p.Categoria = txtCategoriaProveedor.Text.Trim();
                p.NombreProveedor = txtProveedorNombre.Text.Trim();
                p.FormaPago = txtFormaDePagoProveedor.Text.Trim();
                p.TelefonoProveedor = txtBoxTelefonoProveedor.Text.Trim();
                p.FechaRegistro = dateTimePickerFechaProveedor.Value;
                logProveedor.Instancia.InsertarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }


            limpiarTextBoxes();
            listarProveedor();


        }

        private void dgvMostrarProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMostrarProveedores.Rows[e.RowIndex];
            txtRucProveedor.Text = filaActual.Cells[1].Value.ToString();
            txtCategoriaProveedor.Text = filaActual.Cells[2].Value.ToString();
            txtProveedorNombre.Text = filaActual.Cells[3].Value.ToString();
            txtFormaDePagoProveedor.Text = filaActual.Cells[4].Value.ToString();
            txtBoxTelefonoProveedor.Text = filaActual.Cells[6].Value.ToString();
        }
    }
}
