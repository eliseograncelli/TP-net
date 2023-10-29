using BusinessEntities;

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
            btnMas = new Button();
            txtNombreProd = new Label();
            txtId = new Label();
            txtPrecio = new Label();
            btnMenos = new Button();
            btnAgregar = new Button();
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
            // btnMas
            // 
            btnMas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMas.BackColor = Color.Lime;
            btnMas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMas.ForeColor = SystemColors.WindowText;
            btnMas.Location = new Point(103, 153);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(29, 29);
            btnMas.TabIndex = 4;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = false;
            btnMas.MouseClick += btnAgregar_MouseClick;
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
            // btnMenos
            // 
            btnMenos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMenos.BackColor = Color.Red;
            btnMenos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenos.ForeColor = SystemColors.WindowText;
            btnMenos.Location = new Point(11, 152);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(29, 29);
            btnMenos.TabIndex = 11;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.MouseClick += button1_MouseClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Control;
            btnAgregar.ForeColor = SystemColors.WindowText;
            btnAgregar.Location = new Point(36, 184);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 29);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Prod_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnAgregar);
            Controls.Add(btnMenos);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombreProd);
            Controls.Add(btnMas);
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
        public Button btnMas;
        public Label txtNombreProd;
        public Label txtId;
        public Label txtPrecio;
        public Button btnMenos;
        private Button btnAgregar;
    }
}
