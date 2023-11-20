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
    public partial class FormOrdenCompra : Form
    {
        public FormOrdenCompra()
        {
            InitializeComponent();
            listarOrden();
          
            gbDetalle.Enabled = false;
            txtOrden.Enabled = false;
            dgvOrdenCompra.Enabled = false;
            txtCantidad.Enabled = false;    
            txtProducto.Enabled = false;
            LlenardatosCbProveedor();
        }

        private void listarOrden()
        {
            dgvOrdenCompra.DataSource = logOrden.Instancia.ListarOrden();
        }

        private void LlenardatosCbProveedor()
        {
            cbProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
            cbProveedor.DisplayMember = "NombreProveedor";
            cbProveedor.ValueMember = "IDProveedor";
        }
        private void LimpiarVariables() 
        {
            txtOrden.Text = "";
            txtCantidad.Text = "";
            txtCotizacion.Text = "";
            txtProducto.Text = "";
            txtRequerimiento.Text = "";
            cbProveedor.Text = "";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvOrdenCompra.Enabled = true;
            gbDetalle.Enabled = true;
            LimpiarVariables();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnula_Click(object sender, EventArgs e)
        {
            gbDetalle.Enabled = false;
            LimpiarVariables();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                entOrden o = new entOrden();
                o.fecOrden = dtpOrden.Value;
                o.nroCotizacion = txtCotizacion.Text.Trim();
                o.IDProveedor = int.Parse(cbProveedor.SelectedValue.ToString());
                o.nroReq = int.Parse(txtRequerimiento.Text.Trim());
                logOrden.Instancia.InsertarOrden(o);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarOrden();
            gbDetalle.Enabled = true;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            gbDetalle.Enabled = true;
            try
            {
                entOrden o = new entOrden();
                o.nroOrden = int.Parse(txtOrden.Text.Trim());
                logOrden.Instancia.DeshabilitarOrden(o);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDetalle.Enabled = false;
            listarOrden();
        }

        private void dgvOrdenCompra_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrden.Enabled = true;
            gbDetalle.Enabled = true;
            DataGridViewRow filaActual = dgvOrdenCompra.Rows[e.RowIndex];
            txtOrden.Text = filaActual.Cells[0].Value.ToString();
            dtpOrden.Text = filaActual.Cells[1].Value.ToString();
            txtCotizacion.Text = filaActual.Cells[2].Value.ToString();
            cbProveedor.Text = filaActual.Cells[3].Value.ToString();
            txtRequerimiento.Text = filaActual.Cells[4].Value.ToString();
            
        }

        private void btnBuscarReq_Click(object sender, EventArgs e)
        {
            txtRequerimiento.Focus();

            int nroReq = Convert.ToInt32(txtRequerimiento.Text);
            entRequerimiento Req = logRequerimiento.Instancia.BuscarRequerimiento(nroReq);

            if (Req != null)
            {
                txtCantidad.Text = Convert.ToString(Req.nroReq);
                txtProducto.Text = Convert.ToString(Req.producto.nombreProducto);
                txtCantidad.Text = Convert.ToString(Req.cantReq);
            }
            else
            {
                MessageBox.Show("El producto no existe o esta inhabilitado. Verfique nuevamente");
            }
        }
    }
}
