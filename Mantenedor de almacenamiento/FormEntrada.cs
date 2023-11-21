using CapaDatos;
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
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();
            listarProductos();
            LlenardatosCbProductos();
            LlenardatosCbProveedores();
            llenardatosCbSucursal();
            
            dgvProductosL.Enabled = false;
            gpbDatproduc.Enabled = false;
            txtIDEntrada.Enabled = false;
        }
        public void LlenardatosCbProveedores()
        {
            cbProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
            cbProveedor.DisplayMember = "NombreProveedor";
            cbProveedor.ValueMember = "IDProveedor";
        }
        public void LlenardatosCbProductos()
        {
            cbProductos.DataSource = logProducto.Instancia.ListarProducto();
            cbProductos.DisplayMember = "nombreProducto";
            cbProductos.ValueMember = "idProducto";

        }
        public void llenardatosCbSucursal()
        {
            cbLlegada.DataSource = logSucursal.Instancia.ListarSucursal();
            cbLlegada.DisplayMember = "NombreSucursal";
            cbLlegada.ValueMember = "idSucursal";

        }
        public void listarProductos()
        {
            dgvProductosL.DataSource = LogEntrada.Instancia.ListarEntrada();
        }

        private void LimpiarVariables()
        {
            txtCantEntra.Text = "";
            txtCalidad.Text = "";
            txtIDEntrada.Text = "";
            cbProveedor.Text = "";
            cbProductos.Text = "";
            cbLlegada.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gpbDatproduc.Enabled = true;
            dgvProductosL.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
        }

        private void dgvProductosL_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProductosL.Rows[e.RowIndex]; 
            txtIDEntrada.Text = filaActual.Cells[0].Value.ToString();
            cbProductos.Text = filaActual.Cells[1].Value.ToString();
            txtCantEntra.Text = filaActual.Cells[2].Value.ToString();
            txtCalidad.Text = filaActual.Cells[3].Value.ToString();
            cbLlegada.Text = filaActual.Cells[4].Value.ToString();
            cbProveedor.Text = filaActual.Cells[5].Value.ToString();
            dtpFecRegProduct.Text = filaActual.Cells[6].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntEntrada c = new EntEntrada();
                c.idProducto = int.Parse(cbProductos.SelectedValue.ToString());
                c.Cant_entradas = int.Parse(txtCantEntra.Text.Trim());
                c.NroDocCal = txtCalidad.Text.Trim();
                c.idSucursal = int.Parse(cbLlegada.SelectedValue.ToString());
                c.IDProveedor = int.Parse(cbProveedor.SelectedValue.ToString());
                c.fecRegProduct = dtpFecRegProduct.Value;
                LogEntrada.Instancia.InsertaEntrada(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gpbDatproduc.Enabled = true;
            listarProductos();
        }

        private void btnAnula_Click(object sender, EventArgs e)
        {
            gpbDatproduc.Enabled = false;
            LimpiarVariables();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            gpbDatproduc.Enabled = true;
            try
            {
                EntEntrada r = new EntEntrada();
                r.IDEntrada = int.Parse(txtIDEntrada.Text.Trim());
                LogEntrada.Instancia.DeshabilitarEntrada(r);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();

            listarProductos();
        }
    }
}
