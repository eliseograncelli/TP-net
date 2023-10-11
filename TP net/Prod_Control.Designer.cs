namespace TP_net
{
    partial class Prod_Control
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pbxProd = new PictureBox();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            txtNombreProd = new Label();
            label1 = new Label();
            txtPrecioX10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxProd).BeginInit();
            SuspendLayout();
            // 
            // pbxProd
            // 
            pbxProd.Location = new Point(3, 3);
            pbxProd.Name = "pbxProd";
            pbxProd.Size = new Size(131, 107);
            pbxProd.SizeMode = PictureBoxSizeMode.Zoom;
            pbxProd.TabIndex = 0;
            pbxProd.TabStop = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(8, 130);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(86, 29);
            txtPrecio.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(99, 131);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(34, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtNombreProd
            // 
            txtNombreProd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreProd.Location = new Point(0, 113);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(137, 15);
            txtNombreProd.TabIndex = 6;
            txtNombreProd.Text = "nombre";
            txtNombreProd.TextAlign = ContentAlignment.MiddleCenter;
            txtNombreProd.Click += txtNombreProd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 164);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 7;
            label1.Text = "Precio comprando mas\r\nde 10 unidades: \r\n";
            // 
            // txtPrecioX10
            // 
            txtPrecioX10.Anchor = AnchorStyles.Left;
            txtPrecioX10.Location = new Point(88, 179);
            txtPrecioX10.Name = "txtPrecioX10";
            txtPrecioX10.Size = new Size(54, 19);
            txtPrecioX10.TabIndex = 8;
            txtPrecioX10.Text = "precioX10";
            // 
            // Prod_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPrecioX10);
            Controls.Add(label1);
            Controls.Add(txtNombreProd);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(pbxProd);
            Name = "Prod_Control";
            Size = new Size(137, 198);
            ((System.ComponentModel.ISupportInitialize)pbxProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pbxProd;
        public TextBox txtPrecio;
        public Button btnAgregar;
        public Label txtNombreProd;
        private Label label1;
        public Label txtPrecioX10;
    }
}
