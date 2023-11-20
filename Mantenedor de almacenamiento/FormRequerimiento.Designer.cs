namespace Mantenedor_de_almacenamiento
{
    partial class FormRequerimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequerimiento));
            this.label1 = new System.Windows.Forms.Label();
            this.txtreq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpReq = new System.Windows.Forms.DateTimePicker();
            this.gbReq = new System.Windows.Forms.GroupBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.dgvReq = new System.Windows.Forms.DataGridView();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAnula = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOrden = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbReq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro de Requerimiento:";
            // 
            // txtreq
            // 
            this.txtreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtreq.Location = new System.Drawing.Point(208, 38);
            this.txtreq.Name = "txtreq";
            this.txtreq.Size = new System.Drawing.Size(253, 22);
            this.txtreq.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto Requerido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad Requerida:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.txtCantidad.Location = new System.Drawing.Point(208, 147);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(253, 22);
            this.txtCantidad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // dtpReq
            // 
            this.dtpReq.Location = new System.Drawing.Point(208, 209);
            this.dtpReq.Name = "dtpReq";
            this.dtpReq.Size = new System.Drawing.Size(253, 22);
            this.dtpReq.TabIndex = 8;
            // 
            // gbReq
            // 
            this.gbReq.Controls.Add(this.cbProductos);
            this.gbReq.Controls.Add(this.label1);
            this.gbReq.Controls.Add(this.dtpReq);
            this.gbReq.Controls.Add(this.txtreq);
            this.gbReq.Controls.Add(this.label4);
            this.gbReq.Controls.Add(this.label2);
            this.gbReq.Controls.Add(this.txtCantidad);
            this.gbReq.Controls.Add(this.label3);
            this.gbReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReq.Location = new System.Drawing.Point(12, 94);
            this.gbReq.Name = "gbReq";
            this.gbReq.Size = new System.Drawing.Size(696, 250);
            this.gbReq.TabIndex = 9;
            this.gbReq.TabStop = false;
            this.gbReq.Text = "Requerimientos";
            // 
            // cbProductos
            // 
            this.cbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(208, 91);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(253, 24);
            this.cbProductos.TabIndex = 9;
            // 
            // dgvReq
            // 
            this.dgvReq.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq.Location = new System.Drawing.Point(12, 350);
            this.dgvReq.Name = "dgvReq";
            this.dgvReq.RowHeadersWidth = 51;
            this.dgvReq.RowTemplate.Height = 24;
            this.dgvReq.Size = new System.Drawing.Size(696, 281);
            this.dgvReq.TabIndex = 10;
            this.dgvReq.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReq_CellContentDoubleClick);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuma.Location = new System.Drawing.Point(714, 401);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(145, 51);
            this.btnSuma.TabIndex = 9;
            this.btnSuma.Text = "Agregar";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResta.Location = new System.Drawing.Point(714, 458);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(145, 49);
            this.btnResta.TabIndex = 11;
            this.btnResta.Text = "Quitar";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Location = new System.Drawing.Point(714, 114);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(145, 56);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAnula
            // 
            this.btnAnula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnAnula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnula.Location = new System.Drawing.Point(714, 185);
            this.btnAnula.Name = "btnAnula";
            this.btnAnula.Size = new System.Drawing.Size(145, 51);
            this.btnAnula.TabIndex = 13;
            this.btnAnula.Text = "Anula";
            this.btnAnula.UseVisualStyleBackColor = false;
            this.btnAnula.Click += new System.EventHandler(this.btnAnula_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(714, 252);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 52);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.btnOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrden.Location = new System.Drawing.Point(714, 568);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(145, 52);
            this.btnOrden.TabIndex = 15;
            this.btnOrden.Text = "Ordenes de Compra";
            this.btnOrden.UseVisualStyleBackColor = false;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(330, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-86, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1244, 90);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(-148, 642);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1244, 90);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // FormRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 733);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOrden);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnula);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.dgvReq);
            this.Controls.Add(this.gbReq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRequerimiento";
            this.Text = "FormRequerimiento";
            this.gbReq.ResumeLayout(false);
            this.gbReq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtreq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpReq;
        private System.Windows.Forms.GroupBox gbReq;
        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAnula;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}