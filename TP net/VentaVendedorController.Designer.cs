namespace TP_net
{
    partial class VentaVendedorController
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCliente = new Label();
            txtIDVenta = new Label();
            txtFechaVenta = new Label();
            txtProd = new Label();
            txtCantidad = new Label();
            txtTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "ID venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 38);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha venta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(625, 76);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 4;
            label4.Text = "Total: $";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 76);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 5;
            label5.Text = "Producto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 76);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 6;
            label6.Text = "Cantidad:";
            // 
            // txtCliente
            // 
            txtCliente.AutoSize = true;
            txtCliente.Location = new Point(75, 0);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(44, 25);
            txtCliente.TabIndex = 7;
            txtCliente.Text = "****";
            // 
            // txtIDVenta
            // 
            txtIDVenta.AutoSize = true;
            txtIDVenta.Location = new Point(91, 38);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.Size = new Size(44, 25);
            txtIDVenta.TabIndex = 8;
            txtIDVenta.Text = "****";
            // 
            // txtFechaVenta
            // 
            txtFechaVenta.AutoSize = true;
            txtFechaVenta.Location = new Point(345, 38);
            txtFechaVenta.Name = "txtFechaVenta";
            txtFechaVenta.Size = new Size(44, 25);
            txtFechaVenta.TabIndex = 9;
            txtFechaVenta.Text = "****";
            // 
            // txtProd
            // 
            txtProd.AutoSize = true;
            txtProd.Location = new Point(91, 76);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(44, 25);
            txtProd.TabIndex = 10;
            txtProd.Text = "****";
            // 
            // txtCantidad
            // 
            txtCantidad.AutoSize = true;
            txtCantidad.Location = new Point(501, 76);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(44, 25);
            txtCantidad.TabIndex = 11;
            txtCantidad.Text = "****";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(699, 76);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(44, 25);
            txtTotal.TabIndex = 12;
            txtTotal.Text = "****";
            // 
            // VentaVendedorController
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(txtTotal);
            Controls.Add(txtCantidad);
            Controls.Add(txtProd);
            Controls.Add(txtFechaVenta);
            Controls.Add(txtIDVenta);
            Controls.Add(txtCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentaVendedorController";
            Size = new Size(776, 102);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label txtCliente;
        public Label txtIDVenta;
        public Label txtFechaVenta;
        public Label txtProd;
        public Label txtCantidad;
        public Label txtTotal;
    }
}
