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
            txtNombreProd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxProd).BeginInit();
            SuspendLayout();
            // 
            // pbxProd
            // 
            pbxProd.Location = new Point(3, 3);
            pbxProd.Name = "pbxProd";
            pbxProd.Size = new Size(130, 107);
            pbxProd.TabIndex = 0;
            pbxProd.TabStop = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(29, 139);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(44, 29);
            txtPrecio.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(79, 139);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(34, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtNombreProd
            // 
            txtNombreProd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreProd.Location = new Point(3, 116);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(130, 23);
            txtNombreProd.TabIndex = 5;
            // 
            // Prod_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtNombreProd);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(pbxProd);
            Name = "Prod_Control";
            Size = new Size(136, 175);
            ((System.ComponentModel.ISupportInitialize)pbxProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pbxProd;
        public TextBox txtPrecio;
        public Button btnAgregar;
        public TextBox txtNombreProd;
    }
}
