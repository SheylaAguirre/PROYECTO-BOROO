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
    public partial class FormSalida : Form
    {
        public FormSalida()
        {
            InitializeComponent();
            listarSalida();
            LlenardatosCbProductos();
            llenardatosCbSucursal();
           
            dgvSalida.Enabled = false;
            groupBox1.Enabled = false;
            txtIdSalida.Enabled = false;
        }
        public void LlenardatosCbProductos()
        {
            cbProductos.DataSource = logProducto.Instancia.ListarProducto();
            cbProductos.DisplayMember = "nombreProducto";
            cbProductos.ValueMember = "idProducto";

        }
        public void llenardatosCbSucursal() 
        { 
            cbDestino.DataSource = logSucursal.Instancia.ListarSucursal();
            cbDestino.DisplayMember = "NombreSucursal";
            cbDestino.ValueMember = "idSucursal";
        
        }
        public void listarSalida()
        {
            dgvSalida.DataSource = logSalida.Instancia.ListarSalida();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvSalida.Enabled = true;
            groupBox1.Enabled = true;
            btnAgregar.Visible = true;
            limpiarVariables();
        }
        private void limpiarVariables()
        {
            txtIdSalida.Text = "";
            cbProductos.Text = "";
            txtCantidad.Text = "";
            cbDestino.Text = "";
            txtDoc.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entSalida c = new entSalida();
                c.idProducto = int.Parse(cbProductos.SelectedValue.ToString());
                c.Cantidad = int.Parse(txtCantidad.Text.Trim());
                c.idSucursal = int.Parse(cbDestino.SelectedValue.ToString());
                c.DocSalida= txtDoc.Text.Trim();
                c.FecSalida = dtpSalida.Value;
                logSalida.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            groupBox1.Enabled = false;
            listarSalida();
        }

        private void dgvSalida_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdSalida.Enabled = true;
            DataGridViewRow filaActual = dgvSalida.Rows[e.RowIndex];
            txtIdSalida.Text = filaActual.Cells[0].Value.ToString();
            cbProductos.Text = filaActual.Cells[1].Value.ToString();
            txtCantidad.Text = filaActual.Cells[2].Value.ToString();
            cbDestino.Text = filaActual.Cells[3].Value.ToString();
            txtDoc.Text = filaActual.Cells[4].Value.ToString();
            dtpSalida.Text = filaActual.Cells[5].Value.ToString();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnula_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            limpiarVariables();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            dgvSalida.Enabled = true;
            try
            {
                entSalida s = new entSalida();
                s.IdSalida = int.Parse(txtIdSalida.Text.Trim());
                logSalida.Instancia.DeshabilitarSalida(s);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarSalida();
        }
    }
}
