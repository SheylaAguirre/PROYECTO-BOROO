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
    public partial class formMantenedorCotizacion : Form
    {
        public void listarCotizaciones()
        {
            dgvMostrar.DataSource = logCotizacion.Instancia.ListarCotizacion();
        }

        public void limpiarTextBoxes()
        {
            txtBoxDescripcionCotizacion.Text = "";
            txtBoxTotalCotizacion.Text = "";
            txtIdMostrar.Text = "";
            txtNombreCotizacion.Text = "";
            txtOrdenDeCompraC.Text = "";
        }

        public formMantenedorCotizacion()
        {
            InitializeComponent();
            listarCotizaciones();
        }

        private void dgvMostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMostrar.Rows[e.RowIndex];
            txtIdMostrar.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCotizacion.Text = filaActual.Cells[1].Value.ToString();
            txtOrdenDeCompraC.Text = filaActual.Cells[2].Value.ToString();
            dateTPFechaCotizacion.Text = filaActual.Cells[3].Value.ToString();
            txtBoxTotalCotizacion.Text = filaActual.Cells[4].Value.ToString();
            txtBoxDescripcionCotizacion.Text = filaActual.Cells[5].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCotizacion p = new entCotizacion();
                p.Nombre = txtNombreCotizacion.Text.Trim();
                p.OrdenDeCompra = txtOrdenDeCompraC.Text.Trim();
                p.Fecha = dateTPFechaCotizacion.Value;
                p.Total = (float)Convert.ToDecimal(txtBoxTotalCotizacion.Text.Trim());
                p.Descripcion = txtBoxDescripcionCotizacion.Text.Trim();
                logCotizacion.Instancia.InsertarCotizacion(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarTextBoxes();
            listarCotizaciones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entCotizacion p = new entCotizacion();
                p.IDCotizacion = int.Parse(txtIdMostrar.Text.Trim());
                logCotizacion.Instancia.DeshabilitarCotizacion(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarTextBoxes();
            listarCotizaciones();
        }
    }
}
