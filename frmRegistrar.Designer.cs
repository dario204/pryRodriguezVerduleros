namespace pryRodriguezVerduleros
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.lblVerduleria = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.lblKilos = new System.Windows.Forms.Label();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.mtbKilos = new System.Windows.Forms.MaskedTextBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cboVendedores = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mrcRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVerduleria
            // 
            this.lblVerduleria.AutoSize = true;
            this.lblVerduleria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerduleria.ForeColor = System.Drawing.Color.Green;
            this.lblVerduleria.Location = new System.Drawing.Point(177, 9);
            this.lblVerduleria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerduleria.Name = "lblVerduleria";
            this.lblVerduleria.Size = new System.Drawing.Size(276, 29);
            this.lblVerduleria.TabIndex = 0;
            this.lblVerduleria.Text = "Verduleria Lo de Pepe";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(16, 36);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(168, 20);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Nombre del vendedor";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(16, 95);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(165, 20);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Nombre del producto";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Enabled = false;
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.Location = new System.Drawing.Point(532, 82);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(112, 41);
            this.btnRegistar.TabIndex = 6;
            this.btnRegistar.Text = "Registrar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(16, 207);
            this.lblKilos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(46, 20);
            this.lblKilos.TabIndex = 7;
            this.lblKilos.Text = "Kilos";
            this.lblKilos.Click += new System.EventHandler(this.lblKilos_Click);
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.lblFecha);
            this.mrcRegistro.Controls.Add(this.dtpFecha);
            this.mrcRegistro.Controls.Add(this.mtbKilos);
            this.mrcRegistro.Controls.Add(this.cboProducto);
            this.mrcRegistro.Controls.Add(this.cboVendedores);
            this.mrcRegistro.Controls.Add(this.lblVendedor);
            this.mrcRegistro.Controls.Add(this.lblProducto);
            this.mrcRegistro.Controls.Add(this.lblKilos);
            this.mrcRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcRegistro.Location = new System.Drawing.Point(28, 53);
            this.mrcRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.mrcRegistro.Size = new System.Drawing.Size(487, 315);
            this.mrcRegistro.TabIndex = 10;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro";
            // 
            // mtbKilos
            // 
            this.mtbKilos.Location = new System.Drawing.Point(196, 207);
            this.mtbKilos.Margin = new System.Windows.Forms.Padding(4);
            this.mtbKilos.Mask = "99999";
            this.mtbKilos.Name = "mtbKilos";
            this.mtbKilos.Size = new System.Drawing.Size(210, 27);
            this.mtbKilos.TabIndex = 11;
            this.mtbKilos.ValidatingType = typeof(int);
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(196, 95);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(210, 28);
            this.cboProducto.TabIndex = 10;
            // 
            // cboVendedores
            // 
            this.cboVendedores.FormattingEnabled = true;
            this.cboVendedores.Location = new System.Drawing.Point(196, 36);
            this.cboVendedores.Margin = new System.Windows.Forms.Padding(4);
            this.cboVendedores.Name = "cboVendedores";
            this.cboVendedores.Size = new System.Drawing.Size(210, 28);
            this.cboVendedores.TabIndex = 9;
            this.cboVendedores.SelectedIndexChanged += new System.EventHandler(this.cboVendedores_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(532, 148);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 41);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(196, 153);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(210, 27);
            this.dtpFecha.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 153);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 20);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(679, 393);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcRegistro);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.lblVerduleria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrar";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerduleria;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ComboBox cboVendedores;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox mtbKilos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}

