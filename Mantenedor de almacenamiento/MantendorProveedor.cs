using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mantenedor_de_almacenamiento
{
    public partial class MantendorProveedor : Form
    {
        public MantendorProveedor()
        {
            InitializeComponent();
            listarProveedor();
            
            txtIdProveedor.Enabled = false;
            dgvProveedor.Enabled = false;
            gbProveedor.Enabled = false;
            
        }
        public void listarProveedor()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }
        private void LimpiarVariables()
        {
            txtIdProveedor.Text = "";
            txtRuc.Text = "";
            txtNombre.Text = "";
            txt_Direccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cbCategoria.Text = "";
            cbForma_Pago.Text = "";
            cbxEstProveedor.Checked = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdProveedor.Enabled = false;
            gbProveedor.Enabled = true;
            dgvProveedor.Enabled = true;
            LimpiarVariables();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.RUCProveedor = txtRuc.Text.Trim();
                p.Categoria = cbCategoria.Text.Trim();
                p.NombreProveedor = txtNombre.Text.Trim();
                p.FormaPago = cbForma_Pago.Text.Trim();
                p.DireccionProveedor = txt_Direccion.Text.Trim();
                p.TelefonoProveedor = txtTelefono.Text.Trim();
                p.CorreoElectronicoProveedor = txtCorreo.Text.Trim();
                p.FechaRegistro = dtpProveedor.Value;
                p.EstadoProveedor = cbxEstProveedor.Checked;
                logProveedor.Instancia.InsertarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarProveedor();
            gbProveedor.Enabled = true;
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProveedor.Enabled = true;
            gbProveedor.Enabled = true;
            DataGridViewRow filaActual = dgvProveedor.Rows[e.RowIndex];
            txtIdProveedor.Text = filaActual.Cells[0].Value.ToString();
            txtRuc.Text = filaActual.Cells[1].Value.ToString();
            cbCategoria.Text = filaActual.Cells[2].Value.ToString();
            txtNombre.Text = filaActual.Cells[3].Value.ToString();
            cbForma_Pago.Text = filaActual.Cells[4].Value.ToString();
            txt_Direccion.Text = filaActual.Cells[5].Value.ToString();
            txtTelefono.Text = filaActual.Cells[6].Value.ToString();
            txtCorreo.Text = filaActual.Cells[7].Value.ToString();
            dtpProveedor.Text = filaActual.Cells[8].Value.ToString();
            cbxEstProveedor.Checked = Convert.ToBoolean(filaActual.Cells[9].Value);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbProveedor.Enabled = true;
            try
            {
                entProveedor p = new entProveedor();
                p.IDProveedor = int.Parse(txtIdProveedor.Text.Trim());
                p.RUCProveedor = txtRuc.Text.Trim();
                p.Categoria = cbCategoria.Text.Trim();
                p.NombreProveedor = txtNombre.Text.Trim();
                p.FormaPago = cbForma_Pago.Text.Trim();
                p.DireccionProveedor = txt_Direccion.Text.Trim();
                p.TelefonoProveedor = txtTelefono.Text.Trim();
                p.CorreoElectronicoProveedor = txtCorreo.Text.Trim();
                p.FechaRegistro = dtpProveedor.Value;
                p.EstadoProveedor = cbxEstProveedor.Checked;
                logProveedor.Instancia.EditarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarProveedor();
            gbProveedor.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            gbProveedor.Enabled = true;
            try
            {
                entProveedor p = new entProveedor();
                p.IDProveedor = int.Parse(txtIdProveedor.Text.Trim());
                cbxEstProveedor.Checked = false;
                p.EstadoProveedor = cbxEstProveedor.Checked;
                logProveedor.Instancia.DeshabilitarProveedor(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbProveedor.Enabled = false;
            listarProveedor();
        }
    }
}
