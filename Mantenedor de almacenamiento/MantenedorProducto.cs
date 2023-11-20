using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mantenedor_de_almacenamiento
{
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
            listarAlmacen();
            dgvAlmacen.Enabled= false;
            gbAlmacen.Enabled = false;
            txtId.Enabled = false;
            
            LlenardatosCbProveedores();
        }
        public void LlenardatosCbProveedores() 
        {
            cbProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
            cbProveedor.DisplayMember = "NombreProveedor";
            cbProveedor.ValueMember = "IDProveedor";
        }
        public void listarAlmacen()
        {
            dgvAlmacen.DataSource = logProducto.Instancia.ListarProducto();
        }
        private void LimpiarVariables()
        {
            txtId.Text = "";
            txtProducto.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            txtTamaño.Text = "";
            cbTipo.Text = "";
            cbProveedor.Text = "";
            cbx_estProducto.Checked = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbAlmacen.Enabled = true;
            dgvAlmacen.Enabled=true;
            LimpiarVariables();
 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto a = new entProducto();
                a.nombreProducto = txtProducto.Text.Trim();
                a.Categoria = cbTipo.Text.Trim();
                a.IDProveedor = int.Parse(cbProveedor.SelectedValue.ToString());
                a.stock = int.Parse(txtStock.Text.Trim());
                a.precioProducto = float.Parse(txtPrecio.Text.Trim());
                a.tamaño = txtTamaño.Text.Trim();
                a.FecVencimiento = dtpProducto.Value;
                a.estProducto = cbx_estProducto.Checked;
                logProducto.Instancia.InsertarProducto(a);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarAlmacen();
            gbAlmacen.Enabled = true;
            
        }

        private void dgvAlmacen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Enabled = true;
            gbAlmacen.Enabled = true;
            DataGridViewRow filaActual = dgvAlmacen.Rows[e.RowIndex];
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtProducto.Text = filaActual.Cells[1].Value.ToString();
            cbTipo.Text = filaActual.Cells[2].Value.ToString();
            cbProveedor.Text = filaActual.Cells[3].Value.ToString();
            txtStock.Text = filaActual.Cells[4].Value.ToString();
            txtPrecio.Text = filaActual.Cells[5].Value.ToString();
            txtTamaño.Text = filaActual.Cells[6].Value.ToString();
            dtpProducto.Text = filaActual.Cells[7].Value.ToString();
            cbx_estProducto.Checked = Convert.ToBoolean(filaActual.Cells[8].Value);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbAlmacen.Enabled = true;

            try
            {
                entProducto a = new entProducto();
                a.idProducto = int.Parse(txtId.Text);
                a.nombreProducto = txtProducto.Text.Trim();
                a.Categoria = cbTipo.Text.Trim();
                a.IDProveedor = int.Parse(cbProveedor.SelectedValue.ToString());
                a.stock = int.Parse(txtStock.Text);
                a.precioProducto = float.Parse(txtPrecio.Text);
                a.tamaño = txtTamaño.Text.Trim() ;
                a.FecVencimiento = dtpProducto.Value;
                a.estProducto = cbx_estProducto.Checked;
                logProducto.Instancia.EditarProducto(a);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbAlmacen.Enabled = false;
            listarAlmacen();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            gbAlmacen.Enabled = true;
            try
            {
                entProducto a = new entProducto();
                a.idProducto = int.Parse(txtId.Text.Trim());
                cbx_estProducto.Checked = false;
                a.estProducto = cbx_estProducto.Checked;
                logProducto.Instancia.DeshabilitarProducto(a);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbAlmacen.Enabled = false;
            listarAlmacen();
        }

      
    }
}
