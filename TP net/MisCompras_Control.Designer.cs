namespace TP_net
{
    partial class MisCompras_Control
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
            txtId = new TextBox();
            txtFecha = new TextBox();
            txtMonto = new TextBox();
            txtEstado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnDetalles = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(7, 28);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 1;
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(70, 28);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 2;
            // 
            // txtMonto
            // 
            txtMonto.Enabled = false;
            txtMonto.Location = new Point(191, 28);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 3;
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(313, 28);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 10);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 10);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Monto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 10);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Estado:";
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(443, 10);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(102, 52);
            btnDetalles.TabIndex = 8;
            btnDetalles.Text = "DETALLES";
            btnDetalles.UseVisualStyleBackColor = true;
            // 
            // MisCompras_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDetalles);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEstado);
            Controls.Add(txtMonto);
            Controls.Add(txtFecha);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "MisCompras_Control";
            Size = new Size(551, 73);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtId;
        public TextBox txtFecha;
        public TextBox txtMonto;
        public TextBox txtEstado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDetalles;
    }
}
