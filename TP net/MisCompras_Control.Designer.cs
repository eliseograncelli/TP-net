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
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(10, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(10, 47);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 31);
            txtId.TabIndex = 1;
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(100, 47);
            txtFecha.Margin = new Padding(4, 5, 4, 5);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(141, 31);
            txtFecha.TabIndex = 2;
            // 
            // txtMonto
            // 
            txtMonto.Enabled = false;
            txtMonto.Location = new Point(273, 47);
            txtMonto.Margin = new Padding(4, 5, 4, 5);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(141, 31);
            txtMonto.TabIndex = 3;
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(447, 47);
            txtEstado.Margin = new Padding(4, 5, 4, 5);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(141, 31);
            txtEstado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(100, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 5;
            label2.Text = "Fecha:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(273, 17);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 6;
            label3.Text = "Monto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(447, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 7;
            label4.Text = "Estado:";
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.Silver;
            btnDetalles.FlatStyle = FlatStyle.Popup;
            btnDetalles.ForeColor = SystemColors.ActiveCaptionText;
            btnDetalles.Location = new Point(596, 47);
            btnDetalles.Margin = new Padding(4, 5, 4, 5);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(150, 31);
            btnDetalles.TabIndex = 8;
            btnDetalles.Text = "DETALLES";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // MisCompras_Control
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnDetalles);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEstado);
            Controls.Add(txtMonto);
            Controls.Add(txtFecha);
            Controls.Add(txtId);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MisCompras_Control";
            Size = new Size(758, 89);
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
