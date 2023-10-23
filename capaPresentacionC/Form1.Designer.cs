namespace capaPresentacionC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRegistrar = new System.Windows.Forms.GroupBox();
            this.groupBoxMostrar = new System.Windows.Forms.GroupBox();
            this.dgvCotización = new System.Windows.Forms.DataGridView();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnMostra = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCotizacion = new System.Windows.Forms.TextBox();
            this.txtIdMostrar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotización)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRegistrar
            // 
            this.groupBoxRegistrar.Location = new System.Drawing.Point(14, 46);
            this.groupBoxRegistrar.Name = "groupBoxRegistrar";
            this.groupBoxRegistrar.Size = new System.Drawing.Size(369, 176);
            this.groupBoxRegistrar.TabIndex = 0;
            this.groupBoxRegistrar.TabStop = false;
            this.groupBoxRegistrar.Text = "Registrar";
            // 
            // groupBoxMostrar
            // 
            this.groupBoxMostrar.Controls.Add(this.txtIdMostrar);
            this.groupBoxMostrar.Controls.Add(this.label1);
            this.groupBoxMostrar.Controls.Add(this.btnMostra);
            this.groupBoxMostrar.Controls.Add(this.dgvMostrar);
            this.groupBoxMostrar.Location = new System.Drawing.Point(400, 50);
            this.groupBoxMostrar.Name = "groupBoxMostrar";
            this.groupBoxMostrar.Size = new System.Drawing.Size(373, 172);
            this.groupBoxMostrar.TabIndex = 1;
            this.groupBoxMostrar.TabStop = false;
            this.groupBoxMostrar.Text = "Mostrar";
            // 
            // dgvCotización
            // 
            this.dgvCotización.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotización.Location = new System.Drawing.Point(31, 246);
            this.dgvCotización.Name = "dgvCotización";
            this.dgvCotización.RowHeadersWidth = 51;
            this.dgvCotización.RowTemplate.Height = 24;
            this.dgvCotización.Size = new System.Drawing.Size(475, 119);
            this.dgvCotización.TabIndex = 2;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(23, 60);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.RowTemplate.Height = 24;
            this.dgvMostrar.Size = new System.Drawing.Size(331, 87);
            this.dgvMostrar.TabIndex = 0;
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(208, 28);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(109, 26);
            this.btnMostra.TabIndex = 1;
            this.btnMostra.Text = "MOSTRAR";
            this.btnMostra.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(577, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // txtIdCotizacion
            // 
            this.txtIdCotizacion.Location = new System.Drawing.Point(617, 246);
            this.txtIdCotizacion.Name = "txtIdCotizacion";
            this.txtIdCotizacion.Size = new System.Drawing.Size(100, 22);
            this.txtIdCotizacion.TabIndex = 5;
            // 
            // txtIdMostrar
            // 
            this.txtIdMostrar.Location = new System.Drawing.Point(70, 28);
            this.txtIdMostrar.Name = "txtIdMostrar";
            this.txtIdMostrar.Size = new System.Drawing.Size(100, 22);
            this.txtIdMostrar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacionC.Properties.Resources.Mass_logo_con_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(520, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIdCotizacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvCotización);
            this.Controls.Add(this.groupBoxMostrar);
            this.Controls.Add(this.groupBoxRegistrar);
            this.Name = "Form1";
            this.Text = "COTIZACIÓN";
            this.groupBoxMostrar.ResumeLayout(false);
            this.groupBoxMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotización)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegistrar;
        private System.Windows.Forms.GroupBox groupBoxMostrar;
        private System.Windows.Forms.TextBox txtIdMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.DataGridView dgvCotización;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCotizacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

