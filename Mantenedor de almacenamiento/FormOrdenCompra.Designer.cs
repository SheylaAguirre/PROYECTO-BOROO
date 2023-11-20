namespace Mantenedor_de_almacenamiento
{
    partial class FormOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOrden = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAnula = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarReq = new System.Windows.Forms.Button();
            this.txtRequerimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.dgvOrdenCompra = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Orden de Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Orden de Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro de Cotizacion:";
            // 
            // txtOrden
            // 
            this.txtOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtOrden.Location = new System.Drawing.Point(224, 37);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(250, 22);
            this.txtOrden.TabIndex = 3;
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtCotizacion.Location = new System.Drawing.Point(225, 158);
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(249, 22);
            this.txtCotizacion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proveedor:";
            // 
            // dtpOrden
            // 
            this.dtpOrden.Location = new System.Drawing.Point(225, 97);
            this.dtpOrden.Name = "dtpOrden";
            this.dtpOrden.Size = new System.Drawing.Size(249, 22);
            this.dtpOrden.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(828, 187);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(143, 54);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAnula
            // 
            this.btnAnula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnAnula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnula.Location = new System.Drawing.Point(828, 247);
            this.btnAnula.Name = "btnAnula";
            this.btnAnula.Size = new System.Drawing.Size(143, 55);
            this.btnAnula.TabIndex = 10;
            this.btnAnula.Text = "Anula";
            this.btnAnula.UseVisualStyleBackColor = false;
            this.btnAnula.Click += new System.EventHandler(this.btnAnula_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(828, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 56);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.cbProveedor);
            this.gbDetalle.Controls.Add(this.txtCantidad);
            this.gbDetalle.Controls.Add(this.label7);
            this.gbDetalle.Controls.Add(this.txtProducto);
            this.gbDetalle.Controls.Add(this.label6);
            this.gbDetalle.Controls.Add(this.btnBuscarReq);
            this.gbDetalle.Controls.Add(this.txtRequerimiento);
            this.gbDetalle.Controls.Add(this.label5);
            this.gbDetalle.Controls.Add(this.txtCotizacion);
            this.gbDetalle.Controls.Add(this.dtpOrden);
            this.gbDetalle.Controls.Add(this.label1);
            this.gbDetalle.Controls.Add(this.label4);
            this.gbDetalle.Controls.Add(this.label2);
            this.gbDetalle.Controls.Add(this.label3);
            this.gbDetalle.Controls.Add(this.txtOrden);
            this.gbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalle.Location = new System.Drawing.Point(12, 105);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(810, 331);
            this.gbDetalle.TabIndex = 12;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle de Orden Compra";
            // 
            // cbProveedor
            // 
            this.cbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(224, 218);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(250, 24);
            this.cbProveedor.TabIndex = 16;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCantidad.Location = new System.Drawing.Point(611, 175);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(179, 22);
            this.txtCantidad.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(508, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad:";
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtProducto.Location = new System.Drawing.Point(611, 114);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(179, 22);
            this.txtProducto.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Producto:";
            // 
            // btnBuscarReq
            // 
            this.btnBuscarReq.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarReq.Location = new System.Drawing.Point(587, 270);
            this.btnBuscarReq.Name = "btnBuscarReq";
            this.btnBuscarReq.Size = new System.Drawing.Size(102, 34);
            this.btnBuscarReq.TabIndex = 13;
            this.btnBuscarReq.Text = "Buscar";
            this.btnBuscarReq.UseVisualStyleBackColor = false;
            this.btnBuscarReq.Click += new System.EventHandler(this.btnBuscarReq_Click);
            // 
            // txtRequerimiento
            // 
            this.txtRequerimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtRequerimiento.Location = new System.Drawing.Point(224, 276);
            this.txtRequerimiento.Name = "txtRequerimiento";
            this.txtRequerimiento.Size = new System.Drawing.Size(250, 22);
            this.txtRequerimiento.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nro Requerimiento:";
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(828, 594);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(143, 56);
            this.btnSuma.TabIndex = 13;
            this.btnSuma.Text = "Agregar";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(828, 656);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(143, 56);
            this.btnResta.TabIndex = 14;
            this.btnResta.Text = "Quitar";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // dgvOrdenCompra
            // 
            this.dgvOrdenCompra.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenCompra.Location = new System.Drawing.Point(12, 442);
            this.dgvOrdenCompra.Name = "dgvOrdenCompra";
            this.dgvOrdenCompra.RowHeadersWidth = 51;
            this.dgvOrdenCompra.RowTemplate.Height = 24;
            this.dgvOrdenCompra.Size = new System.Drawing.Size(810, 343);
            this.dgvOrdenCompra.TabIndex = 15;
            this.dgvOrdenCompra.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenCompra_CellContentDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-95, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1163, 81);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(-110, 791);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1163, 81);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(249, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // FormOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 872);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvOrdenCompra);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnula);
            this.Controls.Add(this.btnNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrdenCompra";
            this.Text = "FormOrdenCompra";
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.TextBox txtCotizacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOrden;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAnula;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarReq;
        private System.Windows.Forms.TextBox txtRequerimiento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.DataGridView dgvOrdenCompra;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}