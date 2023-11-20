namespace Mantenedor_de_almacenamiento
{
    partial class MantendorProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantendorProveedor));
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.cbForma_Pago = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEstProveedor = new System.Windows.Forms.CheckBox();
            this.dtpProveedor = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.cbForma_Pago);
            this.gbProveedor.Controls.Add(this.label9);
            this.gbProveedor.Controls.Add(this.cbCategoria);
            this.gbProveedor.Controls.Add(this.label8);
            this.gbProveedor.Controls.Add(this.cbxEstProveedor);
            this.gbProveedor.Controls.Add(this.dtpProveedor);
            this.gbProveedor.Controls.Add(this.label7);
            this.gbProveedor.Controls.Add(this.txtCorreo);
            this.gbProveedor.Controls.Add(this.label6);
            this.gbProveedor.Controls.Add(this.txtTelefono);
            this.gbProveedor.Controls.Add(this.label5);
            this.gbProveedor.Controls.Add(this.txt_Direccion);
            this.gbProveedor.Controls.Add(this.label4);
            this.gbProveedor.Controls.Add(this.txtNombre);
            this.gbProveedor.Controls.Add(this.label3);
            this.gbProveedor.Controls.Add(this.txtRuc);
            this.gbProveedor.Controls.Add(this.label2);
            this.gbProveedor.Controls.Add(this.txtIdProveedor);
            this.gbProveedor.Controls.Add(this.label1);
            this.gbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProveedor.Location = new System.Drawing.Point(19, 96);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Size = new System.Drawing.Size(1268, 217);
            this.gbProveedor.TabIndex = 0;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "Datos del Proveedor";
            // 
            // cbForma_Pago
            // 
            this.cbForma_Pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cbForma_Pago.FormattingEnabled = true;
            this.cbForma_Pago.Items.AddRange(new object[] {
            "Efectivo",
            "Credito",
            "Debito",
            "Transferencia Bancaria",
            "Cheque"});
            this.cbForma_Pago.Location = new System.Drawing.Point(592, 87);
            this.cbForma_Pago.Name = "cbForma_Pago";
            this.cbForma_Pago.Size = new System.Drawing.Size(235, 24);
            this.cbForma_Pago.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Forma de pago:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Persona Natural",
            "Persona Juridica",
            "Entidad Publica"});
            this.cbCategoria.Location = new System.Drawing.Point(174, 139);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(235, 24);
            this.cbCategoria.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Categoria RUC:";
            // 
            // cbxEstProveedor
            // 
            this.cbxEstProveedor.AutoSize = true;
            this.cbxEstProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxEstProveedor.Location = new System.Drawing.Point(932, 181);
            this.cbxEstProveedor.Name = "cbxEstProveedor";
            this.cbxEstProveedor.Size = new System.Drawing.Size(155, 20);
            this.cbxEstProveedor.TabIndex = 14;
            this.cbxEstProveedor.Text = "Estado Proveedor";
            this.cbxEstProveedor.UseVisualStyleBackColor = false;
            // 
            // dtpProveedor
            // 
            this.dtpProveedor.CalendarMonthBackground = System.Drawing.Color.Orange;
            this.dtpProveedor.CalendarTitleBackColor = System.Drawing.Color.Orange;
            this.dtpProveedor.Location = new System.Drawing.Point(1018, 37);
            this.dtpProveedor.Name = "dtpProveedor";
            this.dtpProveedor.Size = new System.Drawing.Size(230, 22);
            this.dtpProveedor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(863, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de Registro:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtCorreo.Location = new System.Drawing.Point(592, 139);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(235, 22);
            this.txtCorreo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo Electronico:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtTelefono.Location = new System.Drawing.Point(1018, 136);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 22);
            this.txtTelefono.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(929, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txt_Direccion.Location = new System.Drawing.Point(1018, 92);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(230, 22);
            this.txt_Direccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(925, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtNombre.Location = new System.Drawing.Point(592, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // txtRuc
            // 
            this.txtRuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtRuc.Location = new System.Drawing.Point(174, 89);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(235, 22);
            this.txtRuc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruc Proveedor:";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtIdProveedor.Location = new System.Drawing.Point(174, 42);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(235, 22);
            this.txtIdProveedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID del Proveedor:";
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProveedor.Location = new System.Drawing.Point(19, 319);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(1114, 405);
            this.dgvProveedor.TabIndex = 1;
            this.dgvProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellDoubleClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1139, 667);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 57);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1139, 501);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 57);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1139, 440);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 55);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1139, 380);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 54);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(1139, 319);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 55);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(385, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-93, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1399, 91);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(-22, 730);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1399, 91);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // MantendorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 797);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.gbProveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantendorProveedor";
            this.Text = "MantenedorProveedor";
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxEstProveedor;
        private System.Windows.Forms.DateTimePicker dtpProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbForma_Pago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}