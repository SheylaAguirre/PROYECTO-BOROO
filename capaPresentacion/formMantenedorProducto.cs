using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaLogica;

namespace capaPresentacion
{
    public partial class formMantenedorProducto : Form
    {
        public void ListarProductos()
        {
            dgvMostrar.DataSource = logProducto.Instancia.ListarProducto();
        }

        public void limpiarTextBoxes()
        {
            txtCostoProducto.Text = "";
            txtBoxIDeditar.Text = "";
            txtDescripcionProducto.Text = "";
            txtBoxIDeditar.Text = "";
            txtNombreProducto.Text = "";
        }

        public formMantenedorProducto()
        {
            InitializeComponent();
            ListarProductos();
        }

        private void dgvMostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMostrar.Rows[e.RowIndex];
            txtBoxIDeditar.Text = filaActual.Cells[0].Value.ToString();
            txtNombreProducto.Text = filaActual.Cells[1].Value.ToString();
            txtCostoProducto.Text = filaActual.Cells[2].Value.ToString();
            dtpEmision.Text = filaActual.Cells[3].Value.ToString();
            dtpVencimiento.Text = filaActual.Cells[4].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto();
                p.Nombre = txtNombreProducto.Text.Trim();
                p.Costo = (float)Convert.ToDecimal(txtCostoProducto.Text);
                p.FechaEmision = dtpEmision.Value;
                p.FechaVencimiento = dtpVencimiento.Value;
                p.Descripcion = txtDescripcionProducto.Text.Trim();
                logProducto.Instancia.InsertarProducto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarTextBoxes();
            ListarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto();
                p.IDProducto = int.Parse(txtBoxIDeditar.Text.Trim());
                logProducto.Instancia.DeshabilitarProducto(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarTextBoxes();
            ListarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto();
                p.IDProducto = int.Parse(txtBoxIDeditar.Text);
                p.Nombre = txtNombreProducto.Text.Trim();
                p.Costo = (float)Convert.ToDecimal(txtCostoProducto.Text);
                p.FechaEmision = dtpEmision.Value;
                p.FechaVencimiento = dtpVencimiento.Value;
                p.Descripcion = txtDescripcionProducto.Text.Trim();
                logProducto.Instancia.EditarProducto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            limpiarTextBoxes();
            ListarProductos();
        }
    }
}
