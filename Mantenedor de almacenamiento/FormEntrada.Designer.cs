namespace Mantenedor_de_almacenamiento
{
    partial class FormEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrada));
            this.dtpFecRegProduct = new System.Windows.Forms.DateTimePicker();
            this.txtIDEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbDatproduc = new System.Windows.Forms.GroupBox();
            this.cbLlegada = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCalidad = new System.Windows.Forms.TextBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.txtCantEntra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProductosL = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAnula = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gpbDatproduc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecRegProduct
            // 
            this.dtpFecRegProduct.Location = new System.Drawing.Point(578, 117);
            this.dtpFecRegProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecRegProduct.Name = "dtpFecRegProduct";
            this.dtpFecRegProduct.Size = new System.Drawing.Size(265, 24);
            this.dtpFecRegProduct.TabIndex = 7;
            // 
            // txtIDEntrada
            // 
            this.txtIDEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtIDEntrada.Location = new System.Drawing.Point(204, 33);
            this.txtIDEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDEntrada.Name = "txtIDEntrada";
            this.txtIDEntrada.Size = new System.Drawing.Size(187, 24);
            this.txtIDEntrada.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento de calidad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de entrada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Entrada :";
            // 
            // gpbDatproduc
            // 
            this.gpbDatproduc.Controls.Add(this.cbLlegada);
            this.gpbDatproduc.Controls.Add(this.label7);
            this.gpbDatproduc.Controls.Add(this.txtCalidad);
            this.gpbDatproduc.Controls.Add(this.cbProductos);
            this.gpbDatproduc.Controls.Add(this.label6);
            this.gpbDatproduc.Controls.Add(this.cbProveedor);
            this.gpbDatproduc.Controls.Add(this.txtCantEntra);
            this.gpbDatproduc.Controls.Add(this.dtpFecRegProduct);
            this.gpbDatproduc.Controls.Add(this.txtIDEntrada);
            this.gpbDatproduc.Controls.Add(this.label5);
            this.gpbDatproduc.Controls.Add(this.label4);
            this.gpbDatproduc.Controls.Add(this.label3);
            this.gpbDatproduc.Controls.Add(this.label2);
            this.gpbDatproduc.Controls.Add(this.label1);
            this.gpbDatproduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatproduc.Location = new System.Drawing.Point(13, 86);
            this.gpbDatproduc.Margin = new System.Windows.Forms.Padding(4);
            this.gpbDatproduc.Name = "gpbDatproduc";
            this.gpbDatproduc.Padding = new System.Windows.Forms.Padding(4);
            this.gpbDatproduc.Size = new System.Drawing.Size(891, 210);
            this.gpbDatproduc.TabIndex = 1;
            this.gpbDatproduc.TabStop = false;
            this.gpbDatproduc.Text = "Datos de Entrada";
            // 
            // cbLlegada
            // 
            this.cbLlegada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cbLlegada.FormattingEnabled = true;
            this.cbLlegada.Location = new System.Drawing.Point(578, 33);
            this.cbLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.cbLlegada.Name = "cbLlegada";
            this.cbLlegada.Size = new System.Drawing.Size(196, 26);
            this.cbLlegada.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sucursal de Llegada:";
            // 
            // txtCalidad
            // 
            this.txtCalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtCalidad.Location = new System.Drawing.Point(204, 161);
            this.txtCalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalidad.Name = "txtCalidad";
            this.txtCalidad.Size = new System.Drawing.Size(187, 24);
            this.txtCalidad.TabIndex = 13;
            // 
            // cbProductos
            // 
            this.cbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(204, 73);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(183, 26);
            this.cbProductos.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Producto:";
            // 
            // cbProveedor
            // 
            this.cbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Items.AddRange(new object[] {
            "Ala Oeste",
            "Ala Este ",
            "Ala Norte",
            "Ala Sur"});
            this.cbProveedor.Location = new System.Drawing.Point(578, 73);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(196, 26);
            this.cbProveedor.TabIndex = 10;
            // 
            // txtCantEntra
            // 
            this.txtCantEntra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtCantEntra.Location = new System.Drawing.Point(204, 119);
            this.txtCantEntra.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantEntra.Name = "txtCantEntra";
            this.txtCantEntra.Size = new System.Drawing.Size(183, 24);
            this.txtCantEntra.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proveedor:";
            // 
            // dgvProductosL
            // 
            this.dgvProductosL.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvProductosL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosL.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductosL.Location = new System.Drawing.Point(13, 304);
            this.dgvProductosL.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductosL.Name = "dgvProductosL";
            this.dgvProductosL.RowHeadersWidth = 51;
            this.dgvProductosL.Size = new System.Drawing.Size(975, 349);
            this.dgvProductosL.TabIndex = 2;
            this.dgvProductosL.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosL_CellContentDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnNuevo.Location = new System.Drawing.Point(962, 91);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 54);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(996, 449);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 51);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAnula
            // 
            this.btnAnula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnAnula.Location = new System.Drawing.Point(962, 153);
            this.btnAnula.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnula.Name = "btnAnula";
            this.btnAnula.Size = new System.Drawing.Size(148, 55);
            this.btnAnula.TabIndex = 7;
            this.btnAnula.Text = "Anula";
            this.btnAnula.UseVisualStyleBackColor = false;
            this.btnAnula.Click += new System.EventHandler(this.btnAnula_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnResta.Location = new System.Drawing.Point(996, 508);
            this.btnResta.Margin = new System.Windows.Forms.Padding(4);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(148, 51);
            this.btnResta.TabIndex = 8;
            this.btnResta.Text = "Quitar";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(962, 216);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 55);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1163, 81);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 660);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1163, 73);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(249, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 731);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnAnula);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProductosL);
            this.Controls.Add(this.gpbDatproduc);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEntrada";
            this.Text = "FormEntrada";
            this.gpbDatproduc.ResumeLayout(false);
            this.gpbDatproduc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFecRegProduct;
        private System.Windows.Forms.TextBox txtIDEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbDatproduc;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductosL;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAnula;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCantEntra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalidad;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.ComboBox cbLlegada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}