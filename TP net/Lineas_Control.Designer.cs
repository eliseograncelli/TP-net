namespace TP_net
{
    partial class Lineas_Control
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
            btnEliminar = new Button();
            txtNLinea = new TextBox();
            txtNomProd = new TextBox();
            txtCantidad = new TextBox();
            txtPrecioUni = new TextBox();
            txtSubTotal = new TextBox();
            txtMarca = new TextBox();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(899, 5);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 45);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNLinea
            // 
            txtNLinea.Enabled = false;
            txtNLinea.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNLinea.Location = new Point(4, 5);
            txtNLinea.Margin = new Padding(4, 5, 4, 5);
            txtNLinea.Multiline = true;
            txtNLinea.Name = "txtNLinea";
            txtNLinea.ReadOnly = true;
            txtNLinea.Size = new Size(70, 45);
            txtNLinea.TabIndex = 4;
            txtNLinea.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomProd
            // 
            txtNomProd.BackColor = SystemColors.Control;
            txtNomProd.Enabled = false;
            txtNomProd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNomProd.Location = new Point(84, 5);
            txtNomProd.Margin = new Padding(4, 5, 4, 5);
            txtNomProd.Multiline = true;
            txtNomProd.Name = "txtNomProd";
            txtNomProd.ReadOnly = true;
            txtNomProd.Size = new Size(213, 45);
            txtNomProd.TabIndex = 5;
            txtNomProd.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantidad.Location = new Point(525, 5);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(70, 45);
            txtCantidad.TabIndex = 6;
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrecioUni
            // 
            txtPrecioUni.Enabled = false;
            txtPrecioUni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecioUni.Location = new Point(603, 5);
            txtPrecioUni.Margin = new Padding(4, 5, 4, 5);
            txtPrecioUni.Multiline = true;
            txtPrecioUni.Name = "txtPrecioUni";
            txtPrecioUni.ReadOnly = true;
            txtPrecioUni.Size = new Size(135, 45);
            txtPrecioUni.TabIndex = 7;
            txtPrecioUni.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Enabled = false;
            txtSubTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubTotal.Location = new Point(746, 5);
            txtSubTotal.Margin = new Padding(4, 5, 4, 5);
            txtSubTotal.Multiline = true;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(135, 45);
            txtSubTotal.TabIndex = 8;
            txtSubTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMarca
            // 
            txtMarca.Enabled = false;
            txtMarca.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMarca.Location = new Point(304, 5);
            txtMarca.Margin = new Padding(4, 5, 4, 5);
            txtMarca.Multiline = true;
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.Size = new Size(213, 45);
            txtMarca.TabIndex = 9;
            txtMarca.TextAlign = HorizontalAlignment.Center;
            // 
            // Lineas_Control
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(txtMarca);
            Controls.Add(txtSubTotal);
            Controls.Add(txtPrecioUni);
            Controls.Add(txtCantidad);
            Controls.Add(txtNomProd);
            Controls.Add(txtNLinea);
            Controls.Add(btnEliminar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Lineas_Control";
            Size = new Size(1036, 55);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        public TextBox txtNLinea;
        public TextBox txtNomProd;
        public TextBox txtCantidad;
        public TextBox txtPrecioUni;
        public TextBox txtSubTotal;
        public TextBox txtMarca;
    }
}
