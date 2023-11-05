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
            txtStock = new Label();
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
            txtCantidad.Location = new Point(46, 161);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(64, 29);
            txtCantidad.TabIndex = 2;
            txtCantidad.Text = "0";
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // btnMas
            // 
            btnMas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMas.BackColor = Color.DarkGreen;
            btnMas.FlatStyle = FlatStyle.Popup;
            btnMas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMas.ForeColor = SystemColors.WindowText;
            btnMas.Location = new Point(113, 161);
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
            txtNombreProd.Font = new Font("Segoe Fluent Icons", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreProd.ForeColor = SystemColors.ButtonHighlight;
            txtNombreProd.Location = new Point(3, 113);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(153, 26);
            txtNombreProd.TabIndex = 6;
            txtNombreProd.Text = "nombre";
            txtNombreProd.TextAlign = ContentAlignment.TopCenter;
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
            txtPrecio.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecio.ForeColor = SystemColors.ButtonShadow;
            txtPrecio.Location = new Point(-1, 139);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(153, 19);
            txtPrecio.TabIndex = 10;
            txtPrecio.Text = "label2";
            txtPrecio.TextAlign = ContentAlignment.MiddleCenter;
            txtPrecio.Click += txtPrecio_Click;
            // 
            // btnMenos
            // 
            btnMenos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMenos.BackColor = Color.DarkRed;
            btnMenos.FlatStyle = FlatStyle.Popup;
            btnMenos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenos.ForeColor = SystemColors.WindowText;
            btnMenos.Location = new Point(11, 161);
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
            btnAgregar.Location = new Point(11, 197);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 29);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 5.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.ForeColor = SystemColors.Window;
            txtStock.Location = new Point(57, 169);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(37, 13);
            txtStock.TabIndex = 13;
            txtStock.Text = "label";
            txtStock.TextAlign = ContentAlignment.TopCenter;
            // 
            // Prod_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnAgregar);
            Controls.Add(btnMenos);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombreProd);
            Controls.Add(btnMas);
            Controls.Add(txtCantidad);
            Controls.Add(pbxProd);
            Controls.Add(txtId);
            Controls.Add(txtStock);
            Name = "Prod_Control";
            Size = new Size(151, 241);
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
        public Label txtStock;
    }
}
