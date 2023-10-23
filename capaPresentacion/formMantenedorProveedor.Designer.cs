namespace capaPresentacion
{
    partial class formMantenedorProveedor
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
            this.groupBoxMostrar = new System.Windows.Forms.GroupBox();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.txtIdMostrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMostrarProveedores = new System.Windows.Forms.DataGridView();
            this.groupBoxRegistrar = new System.Windows.Forms.GroupBox();
            this.txtProveedorNombre = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaProveedor = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtCategoriaProveedor = new System.Windows.Forms.TextBox();
            this.txtRucProveedor = new System.Windows.Forms.TextBox();
            this.btnActualizarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFormaDePagoProveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBoxMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProveedores)).BeginInit();
            this.groupBoxRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMostrar
            // 
            this.groupBoxMostrar.Controls.Add(this.btnEliminarProveedor);
            this.groupBoxMostrar.Controls.Add(this.txtIdMostrar);
            this.groupBoxMostrar.Controls.Add(this.label1);
            this.groupBoxMostrar.Controls.Add(this.dgvMostrarProveedores);
            this.groupBoxMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMostrar.Location = new System.Drawing.Point(11, 323);
            this.groupBoxMostrar.Name = "groupBoxMostrar";
            this.groupBoxMostrar.Size = new System.Drawing.Size(840, 262);
            this.groupBoxMostrar.TabIndex = 20;
            this.groupBoxMostrar.TabStop = false;
            this.groupBoxMostrar.Text = "Mostrar/Eliminar";
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Location = new System.Drawing.Point(367, 214);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(237, 32);
            this.btnEliminarProveedor.TabIndex = 4;
            this.btnEliminarProveedor.Text = "ELIMINAR";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // txtIdMostrar
            // 
            this.txtIdMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtIdMostrar.Location = new System.Drawing.Point(201, 217);
            this.txtIdMostrar.Name = "txtIdMostrar";
            this.txtIdMostrar.Size = new System.Drawing.Size(135, 27);
            this.txtIdMostrar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // dgvMostrarProveedores
            // 
            this.dgvMostrarProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProveedores.Location = new System.Drawing.Point(10, 27);
            this.dgvMostrarProveedores.Name = "dgvMostrarProveedores";
            this.dgvMostrarProveedores.RowHeadersWidth = 51;
            this.dgvMostrarProveedores.RowTemplate.Height = 24;
            this.dgvMostrarProveedores.Size = new System.Drawing.Size(815, 176);
            this.dgvMostrarProveedores.TabIndex = 0;
            this.dgvMostrarProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarProveedores_CellDoubleClick);
            // 
            // groupBoxRegistrar
            // 
            this.groupBoxRegistrar.Controls.Add(this.txtFormaDePagoProveedor);
            this.groupBoxRegistrar.Controls.Add(this.txtProveedorNombre);
            this.groupBoxRegistrar.Controls.Add(this.dateTimePickerFechaProveedor);
            this.groupBoxRegistrar.Controls.Add(this.label2);
            this.groupBoxRegistrar.Controls.Add(this.txtBoxTelefonoProveedor);
            this.groupBoxRegistrar.Controls.Add(this.txtCategoriaProveedor);
            this.groupBoxRegistrar.Controls.Add(this.txtRucProveedor);
            this.groupBoxRegistrar.Controls.Add(this.btnActualizarProveedor);
            this.groupBoxRegistrar.Controls.Add(this.btnAgregarProveedor);
            this.groupBoxRegistrar.Controls.Add(this.label7);
            this.groupBoxRegistrar.Controls.Add(this.label6);
            this.groupBoxRegistrar.Controls.Add(this.label5);
            this.groupBoxRegistrar.Controls.Add(this.label4);
            this.groupBoxRegistrar.Controls.Add(this.label3);
            this.groupBoxRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistrar.Location = new System.Drawing.Point(11, 105);
            this.groupBoxRegistrar.Name = "groupBoxRegistrar";
            this.groupBoxRegistrar.Size = new System.Drawing.Size(840, 212);
            this.groupBoxRegistrar.TabIndex = 19;
            this.groupBoxRegistrar.TabStop = false;
            this.groupBoxRegistrar.Text = "Registrar/Actualizar";
            // 
            // txtProveedorNombre
            // 
            this.txtProveedorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedorNombre.Location = new System.Drawing.Point(160, 99);
            this.txtProveedorNombre.Name = "txtProveedorNombre";
            this.txtProveedorNombre.Size = new System.Drawing.Size(195, 27);
            this.txtProveedorNombre.TabIndex = 14;
            // 
            // dateTimePickerFechaProveedor
            // 
            this.dateTimePickerFechaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaProveedor.Location = new System.Drawing.Point(446, 60);
            this.dateTimePickerFechaProveedor.Name = "dateTimePickerFechaProveedor";
            this.dateTimePickerFechaProveedor.Size = new System.Drawing.Size(334, 27);
            this.dateTimePickerFechaProveedor.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(433, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "FECHA REGISTRO:";
            // 
            // txtBoxTelefonoProveedor
            // 
            this.txtBoxTelefonoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTelefonoProveedor.Location = new System.Drawing.Point(160, 168);
            this.txtBoxTelefonoProveedor.Name = "txtBoxTelefonoProveedor";
            this.txtBoxTelefonoProveedor.Size = new System.Drawing.Size(195, 27);
            this.txtBoxTelefonoProveedor.TabIndex = 9;
            // 
            // txtCategoriaProveedor
            // 
            this.txtCategoriaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaProveedor.Location = new System.Drawing.Point(160, 65);
            this.txtCategoriaProveedor.Name = "txtCategoriaProveedor";
            this.txtCategoriaProveedor.Size = new System.Drawing.Size(195, 27);
            this.txtCategoriaProveedor.TabIndex = 8;
            // 
            // txtRucProveedor
            // 
            this.txtRucProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRucProveedor.Location = new System.Drawing.Point(160, 27);
            this.txtRucProveedor.Name = "txtRucProveedor";
            this.txtRucProveedor.Size = new System.Drawing.Size(195, 27);
            this.txtRucProveedor.TabIndex = 7;
            // 
            // btnActualizarProveedor
            // 
            this.btnActualizarProveedor.Location = new System.Drawing.Point(470, 99);
            this.btnActualizarProveedor.Name = "btnActualizarProveedor";
            this.btnActualizarProveedor.Size = new System.Drawing.Size(136, 38);
            this.btnActualizarProveedor.TabIndex = 6;
            this.btnActualizarProveedor.Text = "ACTUALIZAR";
            this.btnActualizarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(612, 99);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(125, 39);
            this.btnAgregarProveedor.TabIndex = 5;
            this.btnAgregarProveedor.Text = "AGREGAR";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "TELEFONO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "FORMA PAGO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "CATEGORIA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "RUC:";
            // 
            // txtFormaDePagoProveedor
            // 
            this.txtFormaDePagoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormaDePagoProveedor.Location = new System.Drawing.Point(160, 132);
            this.txtFormaDePagoProveedor.Name = "txtFormaDePagoProveedor";
            this.txtFormaDePagoProveedor.Size = new System.Drawing.Size(195, 27);
            this.txtFormaDePagoProveedor.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::capaPresentacion.Properties.Resources.partes;
            this.label8.Location = new System.Drawing.Point(53, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(493, 38);
            this.label8.TabIndex = 24;
            this.label8.Text = "MANTENEDOR PROVEEDOR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::capaPresentacion.Properties.Resources.Mass_logo_con_fondo;
            this.pictureBox2.Location = new System.Drawing.Point(591, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacion.Properties.Resources.partes;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::capaPresentacion.Properties.Resources.partes;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 601);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1060, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // formMantenedorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(869, 667);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBoxMostrar);
            this.Controls.Add(this.groupBoxRegistrar);
            this.Name = "formMantenedorProveedor";
            this.Text = "formMantenedorProveedor";
            this.groupBoxMostrar.ResumeLayout(false);
            this.groupBoxMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProveedores)).EndInit();
            this.groupBoxRegistrar.ResumeLayout(false);
            this.groupBoxRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBoxMostrar;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.TextBox txtIdMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMostrarProveedores;
        private System.Windows.Forms.GroupBox groupBoxRegistrar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTelefonoProveedor;
        private System.Windows.Forms.TextBox txtCategoriaProveedor;
        private System.Windows.Forms.TextBox txtRucProveedor;
        private System.Windows.Forms.Button btnActualizarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProveedorNombre;
        private System.Windows.Forms.TextBox txtFormaDePagoProveedor;
    }
}