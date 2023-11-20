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

namespace Mantenedor_de_almacenamiento
{
    public partial class MantenedorSucursal : Form
    {
        public MantenedorSucursal()
        {
            InitializeComponent();
            listarSucursal();
            gbSucursal.Enabled = false;
            txtId.Enabled = false;
            dgvSucursal.Enabled = false;
        }

        public void listarSucursal()
        {
            dgvSucursal.DataSource = logSucursal.Instancia.ListarSucursal();
        }

        public void limpiarVariables() 
        {
        
            txtId.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtSucursal.Text = string.Empty;
            txtDepartamento.Text = string.Empty;
            txtDistrito.Text = string.Empty;
            txtPais.Text = string.Empty;
            cbxEstSucursal.Checked= false;
        
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvSucursal.Enabled = true;
            gbSucursal.Enabled=true;
            limpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entSucursal suc = new entSucursal();
                suc.NombreSucursal = txtSucursal.Text.Trim();
                suc.Direccion = txtDireccion.Text.Trim();
                suc.Pais = txtPais.Text.Trim();
                suc.Departamento = txtDepartamento.Text.Trim();
                suc.Distrito = txtDistrito.Text.Trim();
                suc.estSucursal = cbxEstSucursal.Checked;
                logSucursal.Instancia.InsertarSucursal(suc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listarSucursal();
            gbSucursal.Enabled = true;
            dgvSucursal.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                entSucursal suc = new entSucursal();
                suc.idSucursal = int.Parse(txtId.Text.Trim());
                suc.NombreSucursal = txtSucursal.Text.Trim();
                suc.Direccion = txtDireccion.Text.Trim();
                suc.Pais = txtPais.Text.Trim();
                suc.Departamento = txtDepartamento.Text.Trim();
                suc.Distrito = txtDistrito.Text.Trim();
                suc.estSucursal = cbxEstSucursal.Checked;
                logSucursal.Instancia.EditarSucursal(suc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            listarSucursal();
            gbSucursal.Enabled = true;
            dgvSucursal.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entSucursal a = new entSucursal();
                a.idSucursal = int.Parse(txtId.Text.Trim());
                cbxEstSucursal.Checked = false;
                a.estSucursal = cbxEstSucursal.Checked;
                logSucursal.Instancia.DeshabilitarSucursal(a);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbSucursal.Enabled = true;
            dgvSucursal.Enabled = true;
            listarSucursal();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvSucursal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Enabled = true;
            DataGridViewRow filaActual = dgvSucursal.Rows[e.RowIndex];
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtSucursal.Text = filaActual.Cells[1].Value.ToString();
            txtDireccion.Text = filaActual.Cells[2].Value.ToString();
            txtPais.Text = filaActual.Cells[3].Value.ToString();
            txtDepartamento.Text = filaActual.Cells[4].ToString();
            txtDistrito.Text = filaActual.Cells[5].ToString();
            cbxEstSucursal.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);

        }

        private void MantenedorSucursal_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
