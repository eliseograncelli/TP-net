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
            txtCantidad = new TextBox();
            btnAgregar = new Button();
            txtNombreProd = new Label();
            label1 = new Label();
            txtPrecioX10 = new Label();
            txtId = new Label();
            txtPrecio = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxProd).BeginInit();
            SuspendLayout();
            // 
            // pbxProd
            // 
            pbxProd.Location = new Point(11, 3);
            pbxProd.Name = "pbxProd";
            pbxProd.Size = new Size(131, 107);
            pbxProd.SizeMode = PictureBoxSizeMode.Zoom;
            pbxProd.TabIndex = 0;
            pbxProd.TabStop = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCantidad.Enabled = false;
            txtCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(46, 152);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(51, 29);
            txtCantidad.TabIndex = 2;
            txtCantidad.Text = "0";
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.BackColor = Color.Lime;
            btnAgregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.WindowText;
            btnAgregar.Location = new Point(103, 153);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(34, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.MouseClick += btnAgregar_MouseClick;
            // 
            // txtNombreProd
            // 
            txtNombreProd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreProd.Location = new Point(0, 112);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(151, 15);
            txtNombreProd.TabIndex = 6;
            txtNombreProd.Text = "nombre";
            txtNombreProd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 182);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 7;
            label1.Text = "Precio comprando mas\r\nde 10 unidades: \r\n";
            // 
            // txtPrecioX10
            // 
            txtPrecioX10.Anchor = AnchorStyles.Left;
            txtPrecioX10.Location = new Point(91, 197);
            txtPrecioX10.Name = "txtPrecioX10";
            txtPrecioX10.Size = new Size(62, 19);
            txtPrecioX10.TabIndex = 8;
            txtPrecioX10.Text = "precioX10";
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(57, 129);
            txtId.Name = "txtId";
            txtId.Size = new Size(54, 15);
            txtId.TabIndex = 9;
            txtId.Text = "*** ID ***";
            txtId.Visible = false;
            // 
            // txtPrecio
            // 
            txtPrecio.AutoSize = true;
            txtPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecio.Location = new Point(46, 129);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(51, 20);
            txtPrecio.TabIndex = 10;
            txtPrecio.Text = "label2";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(6, 152);
            button1.Name = "button1";
            button1.Size = new Size(34, 29);
            button1.TabIndex = 11;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += button1_MouseClick;
            // 
            // Prod_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(txtPrecioX10);
            Controls.Add(label1);
            Controls.Add(txtNombreProd);
            Controls.Add(btnAgregar);
            Controls.Add(txtCantidad);
            Controls.Add(pbxProd);
            Controls.Add(txtId);
            Name = "Prod_Control";
            Size = new Size(151, 216);
            ((System.ComponentModel.ISupportInitialize)pbxProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pbxProd;
        public TextBox txtCantidad;
        public Button btnAgregar;
        public Label txtNombreProd;
        private Label label1;
        public Label txtPrecioX10;
        public Label txtId;
        public Label txtPrecio;
        public Button button1;
    }
}
