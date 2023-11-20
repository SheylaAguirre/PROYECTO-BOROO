namespace Mantenedor_de_almacenamiento
{
    partial class MantenedorProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorProducto));
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.gbSql = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbAlmacen = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.dtpProducto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_estProducto = new System.Windows.Forms.CheckBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.gbSql.SuspendLayout();
            this.gbAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.AccessibleDescription = "";
            this.dgvAlmacen.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Location = new System.Drawing.Point(6, 21);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.RowHeadersWidth = 51;
            this.dgvAlmacen.RowTemplate.Height = 24;
            this.dgvAlmacen.Size = new System.Drawing.Size(1082, 478);
            this.dgvAlmacen.TabIndex = 0;
            this.dgvAlmacen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlmacen_CellDoubleClick);
            // 
            // gbSql
            // 
            this.gbSql.Controls.Add(this.btnNuevo);
            this.gbSql.Controls.Add(this.btnSalir);
            this.gbSql.Controls.Add(this.btnEliminar);
            this.gbSql.Controls.Add(this.btnEditar);
            this.gbSql.Controls.Add(this.btnAgregar);
            this.gbSql.Controls.Add(this.dgvAlmacen);
            this.gbSql.Location = new System.Drawing.Point(12, 287);
            this.gbSql.Name = "gbSql";
            this.gbSql.Size = new System.Drawing.Size(1239, 505);
            this.gbSql.TabIndex = 1;
            this.gbSql.TabStop = false;
            this.gbSql.Text = "SQL";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(1094, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 54);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1094, 442);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 57);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1094, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 55);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1094, 140);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 54);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1094, 79);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 55);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbAlmacen
            // 
            this.gbAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbAlmacen.Controls.Add(this.label7);
            this.gbAlmacen.Controls.Add(this.txtPrecio);
            this.gbAlmacen.Controls.Add(this.label8);
            this.gbAlmacen.Controls.Add(this.txtTamaño);
            this.gbAlmacen.Controls.Add(this.dtpProducto);
            this.gbAlmacen.Controls.Add(this.label3);
            this.gbAlmacen.Controls.Add(this.cbx_estProducto);
            this.gbAlmacen.Controls.Add(this.txtStock);
            this.gbAlmacen.Controls.Add(this.label6);
            this.gbAlmacen.Controls.Add(this.cbProveedor);
            this.gbAlmacen.Controls.Add(this.label5);
            this.gbAlmacen.Controls.Add(this.txtProducto);
            this.gbAlmacen.Controls.Add(this.label4);
            this.gbAlmacen.Controls.Add(this.cbTipo);
            this.gbAlmacen.Controls.Add(this.label2);
            this.gbAlmacen.Controls.Add(this.txtId);
            this.gbAlmacen.Controls.Add(this.label1);
            this.gbAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlmacen.Location = new System.Drawing.Point(12, 96);
            this.gbAlmacen.Name = "gbAlmacen";
            this.gbAlmacen.Size = new System.Drawing.Size(1239, 185);
            this.gbAlmacen.TabIndex = 2;
            this.gbAlmacen.TabStop = false;
            this.gbAlmacen.Text = "Datos del almacen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(881, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tamaño envase:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtPrecio.Location = new System.Drawing.Point(602, 142);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(228, 22);
            this.txtPrecio.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Precio del producto:";
            // 
            // txtTamaño
            // 
            this.txtTamaño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtTamaño.Location = new System.Drawing.Point(1014, 39);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(201, 22);
            this.txtTamaño.TabIndex = 17;
            // 
            // dtpProducto
            // 
            this.dtpProducto.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpProducto.Location = new System.Drawing.Point(1014, 82);
            this.dtpProducto.Name = "dtpProducto";
            this.dtpProducto.Size = new System.Drawing.Size(201, 22);
            this.dtpProducto.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(846, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha de Vencimiento:";
            // 
            // cbx_estProducto
            // 
            this.cbx_estProducto.AutoSize = true;
            this.cbx_estProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbx_estProducto.Location = new System.Drawing.Point(1014, 137);
            this.cbx_estProducto.Name = "cbx_estProducto";
            this.cbx_estProducto.Size = new System.Drawing.Size(170, 20);
            this.cbx_estProducto.TabIndex = 14;
            this.cbx_estProducto.Text = "Estado del Producto";
            this.cbx_estProducto.UseVisualStyleBackColor = false;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtStock.Location = new System.Drawing.Point(602, 85);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(228, 22);
            this.txtStock.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stock:";
            // 
            // cbProveedor
            // 
            this.cbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(602, 36);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(228, 24);
            this.cbProveedor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proveedor del Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtProducto.Location = new System.Drawing.Point(185, 85);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(222, 22);
            this.txtProducto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre del Producto:";
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Alimentos frescos",
            "Productos enlatados",
            "Productos envasados",
            "Productos de panadería y confitería",
            "Productos lácteos",
            "Bebidas",
            "Alimentos congelados",
            "Productos de cuidado personal",
            "Artículos para el hogar",
            "Productos de cuidado personal"});
            this.cbTipo.Location = new System.Drawing.Point(185, 134);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(222, 24);
            this.cbTipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtId.Location = new System.Drawing.Point(185, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(222, 22);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del producto:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(380, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-88, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1352, 90);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(-40, 798);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1352, 90);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // MantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 858);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbAlmacen);
            this.Controls.Add(this.gbSql);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenedorProducto";
            this.Text = "MantenedorProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.gbSql.ResumeLayout(false);
            this.gbAlmacen.ResumeLayout(false);
            this.gbAlmacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.Windows.Forms.GroupBox gbSql;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbAlmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbx_estProducto;
        private System.Windows.Forms.DateTimePicker dtpProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

