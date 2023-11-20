using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mantenedor_de_almacenamiento
{
    public partial class FormRequerimiento : Form
    {
        public FormRequerimiento()
        {
            InitializeComponent();
            listarRequerimiento();
            dgvReq.Enabled = false;
            gbReq.Enabled = false;
        
            txtreq.Enabled = false;
            LlenardatosCbProductos();

        }
        public void LlenardatosCbProductos()
        {
            cbProductos.DataSource = logProducto.Instancia.ListarProducto();
            cbProductos.DisplayMember = "nombreProducto";
            cbProductos.ValueMember = "idProducto";

        }
        public void listarRequerimiento()
        {
            dgvReq.DataSource = logRequerimiento.Instancia.ListarRequerimiento();
        }

        private void LimpiarVariables()
        {
            txtreq.Text = "";
            txtCantidad.Text = "";
            cbProductos.Text = "";

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvReq.Enabled = true;
            gbReq.Enabled = true;
            LimpiarVariables();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                entRequerimiento r = new entRequerimiento();
                r.idProducto = int.Parse(cbProductos.SelectedValue.ToString());
                r.cantReq = int.Parse(txtCantidad.Text.Trim());
                r.fecReq = dtpReq.Value;
                logRequerimiento.Instancia.InsertarRequerimiento(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarRequerimiento();
            gbReq.Enabled = true;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            gbReq.Enabled = true;
            try
            {
                entRequerimiento r = new entRequerimiento();
                r.nroReq = int.Parse(txtreq.Text.Trim());
                logRequerimiento.Instancia.DeshabilitarRequerimiento(r);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbReq.Enabled = false;
            listarRequerimiento();
        }

        private void btnAnula_Click(object sender, EventArgs e)
        {
            gbReq.Enabled = false;
            LimpiarVariables();
        }

        private void dgvReq_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtreq.Enabled = true;
            gbReq.Enabled = true;
            DataGridViewRow filaActual = dgvReq.Rows[e.RowIndex];
            txtreq.Text = filaActual.Cells[0].Value.ToString();
            cbProductos.Text = filaActual.Cells[1].Value.ToString();
            txtCantidad.Text = filaActual.Cells[2].Value.ToString();
            dtpReq.Text = filaActual.Cells[3].Value.ToString();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            FormOrdenCompra formOrdenCompra = new FormOrdenCompra();
            formOrdenCompra.Show();
        }
    }
}
