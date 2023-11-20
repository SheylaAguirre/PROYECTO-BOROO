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
    public partial class FormPresupuesto : Form
    {
        public FormPresupuesto()
        {
            InitializeComponent();
            ListarPresupuesto();
            LlenardatosCbProveedores();
            
            dgv_presupuesto.Enabled = false;
            grupDatosPresupuesto.Enabled = false;
            txt_IdPresupuesto.Enabled = false;
        }
        public void LlenardatosCbProveedores()
        {
            cmb_nombreproveedor.DataSource = logProveedor.Instancia.ListarProveedor();
            cmb_nombreproveedor.DisplayMember = "NombreProveedor";
            cmb_nombreproveedor.ValueMember = "IDProveedor";
        }
        public void ListarPresupuesto()
        {
            dgv_presupuesto.DataSource = logPresupuesto.Instancia.ListarPresupuesto();
        }
        private void LimpiarVariables()
        {
            txt_IdPresupuesto.Text = " ";
            txtFactura.Text = " ";
            txtMonto.Text = " ";
            txtSaldo.Text = " ";
            cmb_metodosdepago.Text = "";
            cmb_nombreproveedor.Text = "";
            dtp_fecha.Value = dtp_fecha.Value;
            
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupDatosPresupuesto.Enabled = true;
            dgv_presupuesto.Enabled = true;
            Btn_Agregar.Visible = true;
            LimpiarVariables();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            grupDatosPresupuesto.Enabled = false;
            LimpiarVariables();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_presupuesto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdPresupuesto.Enabled = true;
            DataGridViewRow filaActual = dgv_presupuesto.Rows[e.RowIndex]; 
            txt_IdPresupuesto.Text = filaActual.Cells[0].Value.ToString();
            txtFactura.Text = filaActual.Cells[1].Value.ToString();
            cmb_nombreproveedor.Text = filaActual.Cells[2].Value.ToString();
            txtMonto.Text = filaActual.Cells[3].Value.ToString();
            cmb_metodosdepago.Text = filaActual.Cells[4].Value.ToString();
            txtSaldo.Text = filaActual.Cells[5].Value.ToString();  
            dtp_fecha.Text = filaActual.Cells[6].Value.ToString();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                entPresupuesto p = new entPresupuesto();
                p.Factura = txtFactura.Text.Trim();
                p.IDProveedor = int.Parse(cmb_nombreproveedor.SelectedValue.ToString());
                p.Monto = int.Parse(txtMonto.Text.Trim());
                p.MetodoDePago = cmb_metodosdepago.Text.Trim();
                p.Saldo = int.Parse(txtSaldo.Text.Trim());
                p.dtp_fecha = dtp_fecha.Value;
                logPresupuesto.Instancia.InsertarPresupuesto(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupDatosPresupuesto.Enabled = false;
            ListarPresupuesto();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            grupDatosPresupuesto.Enabled = true;
            try
            {
                entPresupuesto p = new entPresupuesto();
                p.IdPresupuesto = int.Parse(txt_IdPresupuesto.Text.Trim());
                logPresupuesto.Instancia.DeshabilitarPresupuesto(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupDatosPresupuesto.Enabled = false;
            ListarPresupuesto();
        }
    }
}
