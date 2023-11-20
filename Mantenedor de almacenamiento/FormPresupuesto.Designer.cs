namespace Mantenedor_de_almacenamiento
{
    partial class FormPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPresupuesto));
            this.grupDatosPresupuesto = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_nombreproveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IdPresupuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_metodosdepago = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.dgv_presupuesto = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grupDatosPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_presupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grupDatosPresupuesto
            // 
            this.grupDatosPresupuesto.BackColor = System.Drawing.Color.Transparent;
            this.grupDatosPresupuesto.Controls.Add(this.txtSaldo);
            this.grupDatosPresupuesto.Controls.Add(this.label3);
            this.grupDatosPresupuesto.Controls.Add(this.txtFactura);
            this.grupDatosPresupuesto.Controls.Add(this.label1);
            this.grupDatosPresupuesto.Controls.Add(this.cmb_nombreproveedor);
            this.grupDatosPresupuesto.Controls.Add(this.label7);
            this.grupDatosPresupuesto.Controls.Add(this.txt_IdPresupuesto);
            this.grupDatosPresupuesto.Controls.Add(this.label2);
            this.grupDatosPresupuesto.Controls.Add(this.dtp_fecha);
            this.grupDatosPresupuesto.Controls.Add(this.cmb_metodosdepago);
            this.grupDatosPresupuesto.Controls.Add(this.txtMonto);
            this.grupDatosPresupuesto.Controls.Add(this.label6);
            this.grupDatosPresupuesto.Controls.Add(this.label5);
            this.grupDatosPresupuesto.Controls.Add(this.label4);
            this.grupDatosPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupDatosPresupuesto.Location = new System.Drawing.Point(21, 86);
            this.grupDatosPresupuesto.Name = "grupDatosPresupuesto";
            this.grupDatosPresupuesto.Size = new System.Drawing.Size(803, 247);
            this.grupDatosPresupuesto.TabIndex = 11;
            this.grupDatosPresupuesto.TabStop = false;
            this.grupDatosPresupuesto.Text = "Producto";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtSaldo.Location = new System.Drawing.Point(551, 93);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(221, 22);
            this.txtSaldo.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Saldo Presupuestario:";
            // 
            // txtFactura
            // 
            this.txtFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtFactura.Location = new System.Drawing.Point(139, 90);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(194, 22);
            this.txtFactura.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Factura:";
            // 
            // cmb_nombreproveedor
            // 
            this.cmb_nombreproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cmb_nombreproveedor.FormattingEnabled = true;
            this.cmb_nombreproveedor.Location = new System.Drawing.Point(139, 142);
            this.cmb_nombreproveedor.Name = "cmb_nombreproveedor";
            this.cmb_nombreproveedor.Size = new System.Drawing.Size(194, 24);
            this.cmb_nombreproveedor.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Proveedor:";
            // 
            // txt_IdPresupuesto
            // 
            this.txt_IdPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txt_IdPresupuesto.Location = new System.Drawing.Point(139, 38);
            this.txt_IdPresupuesto.Name = "txt_IdPresupuesto";
            this.txt_IdPresupuesto.Size = new System.Drawing.Size(194, 22);
            this.txt_IdPresupuesto.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Presupuesto:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(551, 145);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(221, 22);
            this.dtp_fecha.TabIndex = 20;
            // 
            // cmb_metodosdepago
            // 
            this.cmb_metodosdepago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cmb_metodosdepago.FormattingEnabled = true;
            this.cmb_metodosdepago.Items.AddRange(new object[] {
            "Efectivo",
            "Credito",
            "Debito",
            "Transferencia Bancaria",
            "Cheque"});
            this.cmb_metodosdepago.Location = new System.Drawing.Point(551, 41);
            this.cmb_metodosdepago.Name = "cmb_metodosdepago";
            this.cmb_metodosdepago.Size = new System.Drawing.Size(221, 24);
            this.cmb_metodosdepago.TabIndex = 19;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtMonto.Location = new System.Drawing.Point(139, 199);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(194, 22);
            this.txtMonto.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Método de pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Monto a pagar:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(839, 179);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(144, 54);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.Btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(989, 444);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(144, 50);
            this.Btn_Agregar.TabIndex = 5;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // dgv_presupuesto
            // 
            this.dgv_presupuesto.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_presupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_presupuesto.Location = new System.Drawing.Point(21, 339);
            this.dgv_presupuesto.Name = "dgv_presupuesto";
            this.dgv_presupuesto.RowHeadersWidth = 51;
            this.dgv_presupuesto.RowTemplate.Height = 24;
            this.dgv_presupuesto.Size = new System.Drawing.Size(962, 285);
            this.dgv_presupuesto.TabIndex = 10;
            this.dgv_presupuesto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_presupuesto_CellContentDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(839, 111);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(144, 54);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(839, 246);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(144, 56);
            this.Btn_Salir.TabIndex = 27;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(989, 500);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(144, 55);
            this.btnResta.TabIndex = 29;
            this.btnResta.Text = "Quitar";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(330, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-90, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1244, 81);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(-90, 630);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1244, 107);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // FormPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 709);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.grupDatosPresupuesto);
            this.Controls.Add(this.dgv_presupuesto);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.BtnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPresupuesto";
            this.Text = "FormPresupuesto";
            this.grupDatosPresupuesto.ResumeLayout(false);
            this.grupDatosPresupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_presupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grupDatosPresupuesto;
        private System.Windows.Forms.ComboBox cmb_nombreproveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox txt_IdPresupuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox cmb_metodosdepago;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.DataGridView dgv_presupuesto;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}