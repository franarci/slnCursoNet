namespace WindowsApp
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
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnCienteIndividuo = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnRemito = new System.Windows.Forms.Button();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.lstInstancias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(569, 339);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(75, 23);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(569, 285);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnEmpresa.TabIndex = 1;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnCienteIndividuo
            // 
            this.btnCienteIndividuo.Location = new System.Drawing.Point(338, 285);
            this.btnCienteIndividuo.Name = "btnCienteIndividuo";
            this.btnCienteIndividuo.Size = new System.Drawing.Size(75, 23);
            this.btnCienteIndividuo.TabIndex = 2;
            this.btnCienteIndividuo.Text = "ClienteIndividuo";
            this.btnCienteIndividuo.UseVisualStyleBackColor = true;
            this.btnCienteIndividuo.Click += new System.EventHandler(this.btnCienteIndividuo_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(463, 285);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(75, 23);
            this.btnFactura.TabIndex = 3;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnRemito
            // 
            this.btnRemito.Location = new System.Drawing.Point(463, 339);
            this.btnRemito.Name = "btnRemito";
            this.btnRemito.Size = new System.Drawing.Size(75, 23);
            this.btnRemito.TabIndex = 5;
            this.btnRemito.Text = "Remito";
            this.btnRemito.UseVisualStyleBackColor = true;
            this.btnRemito.Click += new System.EventHandler(this.btnRemito_Click);
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(338, 339);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnVendedor.TabIndex = 6;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // lstInstancias
            // 
            this.lstInstancias.FormattingEnabled = true;
            this.lstInstancias.Location = new System.Drawing.Point(29, 13);
            this.lstInstancias.Name = "lstInstancias";
            this.lstInstancias.Size = new System.Drawing.Size(993, 251);
            this.lstInstancias.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 453);
            this.Controls.Add(this.lstInstancias);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.btnRemito);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnCienteIndividuo);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnCienteIndividuo;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnRemito;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.ListBox lstInstancias;
    }
}

