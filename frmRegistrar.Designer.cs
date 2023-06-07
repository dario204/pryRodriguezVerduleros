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
            this.lblVerduleria = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.lblKilos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboVendedores = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mtbKilos = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVerduleria
            // 
            this.lblVerduleria.AutoSize = true;
            this.lblVerduleria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerduleria.Location = new System.Drawing.Point(196, 9);
            this.lblVerduleria.Name = "lblVerduleria";
            this.lblVerduleria.Size = new System.Drawing.Size(83, 18);
            this.lblVerduleria.TabIndex = 0;
            this.lblVerduleria.Text = "Verduleria";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(12, 29);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(109, 13);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Nombre del vendedor";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(12, 97);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(106, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Nombre del producto";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(328, 82);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(84, 33);
            this.btnRegistar.TabIndex = 6;
            this.btnRegistar.Text = "Registrar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(15, 144);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(29, 13);
            this.lblKilos.TabIndex = 7;
            this.lblKilos.Text = "Kilos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbKilos);
            this.groupBox1.Controls.Add(this.cboProducto);
            this.groupBox1.Controls.Add(this.cboVendedores);
            this.groupBox1.Controls.Add(this.lblVendedor);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.lblKilos);
            this.groupBox1.Location = new System.Drawing.Point(21, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cboVendedores
            // 
            this.cboVendedores.FormattingEnabled = true;
            this.cboVendedores.Location = new System.Drawing.Point(148, 29);
            this.cboVendedores.Name = "cboVendedores";
            this.cboVendedores.Size = new System.Drawing.Size(121, 21);
            this.cboVendedores.TabIndex = 9;
            this.cboVendedores.SelectedIndexChanged += new System.EventHandler(this.cboVendedores_SelectedIndexChanged);
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(148, 97);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(121, 21);
            this.cboProducto.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(328, 137);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 33);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // mtbKilos
            // 
            this.mtbKilos.Location = new System.Drawing.Point(148, 144);
            this.mtbKilos.Mask = "99999";
            this.mtbKilos.Name = "mtbKilos";
            this.mtbKilos.Size = new System.Drawing.Size(120, 20);
            this.mtbKilos.TabIndex = 11;
            this.mtbKilos.ValidatingType = typeof(int);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 270);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.lblVerduleria);
            this.Name = "frmRegistrar";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerduleria;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ComboBox cboVendedores;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox mtbKilos;
    }
}

