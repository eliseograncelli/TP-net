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
            pbxProd.Location = new Point(16, 5);
            pbxProd.Margin = new Padding(4, 5, 4, 5);
            pbxProd.Name = "pbxProd";
            pbxProd.Size = new Size(187, 178);
            pbxProd.SizeMode = PictureBoxSizeMode.Zoom;
            pbxProd.TabIndex = 0;
            pbxProd.TabStop = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCantidad.Enabled = false;
            txtCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(65, 269);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(89, 39);
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
            btnMas.Location = new Point(162, 269);
            btnMas.Margin = new Padding(4, 5, 4, 5);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(41, 39);
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
            txtNombreProd.Location = new Point(4, 188);
            txtNombreProd.Margin = new Padding(4, 0, 4, 0);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(218, 44);
            txtNombreProd.TabIndex = 6;
            txtNombreProd.Text = "nombre";
            txtNombreProd.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(81, 215);
            txtId.Margin = new Padding(4, 0, 4, 0);
            txtId.Name = "txtId";
            txtId.Size = new Size(88, 25);
            txtId.TabIndex = 9;
            txtId.Text = "*** ID ***";
            txtId.Visible = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecio.ForeColor = SystemColors.ButtonShadow;
            txtPrecio.Location = new Point(-1, 232);
            txtPrecio.Margin = new Padding(4, 0, 4, 0);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(218, 32);
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
            btnMenos.Location = new Point(16, 269);
            btnMenos.Margin = new Padding(4, 5, 4, 5);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(41, 39);
            btnMenos.TabIndex = 11;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.MouseClick += button1_MouseClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Control;
            btnAgregar.ForeColor = SystemColors.WindowText;
            btnAgregar.Location = new Point(16, 318);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(187, 48);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Prod_Control
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Prod_Control";
            Size = new Size(216, 401);
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
