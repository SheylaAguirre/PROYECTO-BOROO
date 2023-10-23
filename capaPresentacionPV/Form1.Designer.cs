namespace capaPresentacionPV
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
            this.groupBoxMostrarEliminarPRO = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtIdMostrarEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMostarEliminar = new System.Windows.Forms.DataGridView();
            this.groupBoxRegistrarPRO = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxMostrarEliminarPRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostarEliminar)).BeginInit();
            this.groupBoxRegistrarPRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMostrarEliminarPRO
            // 
            this.groupBoxMostrarEliminarPRO.Controls.Add(this.btnEditar);
            this.groupBoxMostrarEliminarPRO.Controls.Add(this.txtIdMostrarEliminar);
            this.groupBoxMostrarEliminarPRO.Controls.Add(this.btnEliminar);
            this.groupBoxMostrarEliminarPRO.Controls.Add(this.btnMostrar);
            this.groupBoxMostrarEliminarPRO.Controls.Add(this.label1);
            this.groupBoxMostrarEliminarPRO.Controls.Add(this.dgvMostarEliminar);
            this.groupBoxMostrarEliminarPRO.Location = new System.Drawing.Point(20, 390);
            this.groupBoxMostrarEliminarPRO.Name = "groupBoxMostrarEliminarPRO";
            this.groupBoxMostrarEliminarPRO.Size = new System.Drawing.Size(773, 191);
            this.groupBoxMostrarEliminarPRO.TabIndex = 0;
            this.groupBoxMostrarEliminarPRO.TabStop = false;
            this.groupBoxMostrarEliminarPRO.Text = "Mostrar/Eliminar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(628, 108);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 24);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "ACTUALIZAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtIdMostrarEliminar
            // 
            this.txtIdMostrarEliminar.Location = new System.Drawing.Point(643, 37);
            this.txtIdMostrarEliminar.Name = "txtIdMostrarEliminar";
            this.txtIdMostrarEliminar.Size = new System.Drawing.Size(113, 22);
            this.txtIdMostrarEliminar.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(628, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 25);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(628, 79);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(99, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // dgvMostarEliminar
            // 
            this.dgvMostarEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostarEliminar.Location = new System.Drawing.Point(15, 37);
            this.dgvMostarEliminar.Name = "dgvMostarEliminar";
            this.dgvMostarEliminar.RowHeadersWidth = 51;
            this.dgvMostarEliminar.RowTemplate.Height = 24;
            this.dgvMostarEliminar.Size = new System.Drawing.Size(593, 148);
            this.dgvMostarEliminar.TabIndex = 0;
            // 
            // groupBoxRegistrarPRO
            // 
            this.groupBoxRegistrarPRO.Controls.Add(this.btnRegistrar);
            this.groupBoxRegistrarPRO.Location = new System.Drawing.Point(20, 125);
            this.groupBoxRegistrarPRO.Name = "groupBoxRegistrarPRO";
            this.groupBoxRegistrarPRO.Size = new System.Drawing.Size(773, 259);
            this.groupBoxRegistrarPRO.TabIndex = 1;
            this.groupBoxRegistrarPRO.TabStop = false;
            this.groupBoxRegistrarPRO.Text = "Registrar/Actualizar";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(607, 73);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 29);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(880, 325);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(148, 153);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1, 587);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1040, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(760, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 632);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxRegistrarPRO);
            this.Controls.Add(this.groupBoxMostrarEliminarPRO);
            this.Name = "Form1";
            this.Text = "PROVEEDOR";
            this.groupBoxMostrarEliminarPRO.ResumeLayout(false);
            this.groupBoxMostrarEliminarPRO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostarEliminar)).EndInit();
            this.groupBoxRegistrarPRO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMostrarEliminarPRO;
        private System.Windows.Forms.TextBox txtIdMostrarEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMostarEliminar;
        private System.Windows.Forms.GroupBox groupBoxRegistrarPRO;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnEditar;
    }
}

