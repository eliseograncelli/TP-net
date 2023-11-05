namespace TP_net
{
    partial class frmCarrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirmar = new Button();
            label1 = new Label();
            txtNombre = new Label();
            flwCarrito = new FlowLayoutPanel();
            fecha = new Label();
            label2 = new Label();
            txtMonto = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.DarkGreen;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.ForeColor = SystemColors.ControlLightLight;
            btnConfirmar.Location = new Point(912, 563);
            btnConfirmar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(150, 80);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar compra";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 45);
            label1.TabIndex = 2;
            label1.Text = "Carrito";
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(17, 60);
            txtNombre.Margin = new Padding(4, 0, 4, 0);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(59, 25);
            txtNombre.TabIndex = 3;
            txtNombre.Text = "label2";
            // 
            // flwCarrito
            // 
            flwCarrito.Location = new Point(17, 90);
            flwCarrito.Margin = new Padding(4, 5, 4, 5);
            flwCarrito.Name = "flwCarrito";
            flwCarrito.Size = new Size(1040, 528);
            flwCarrito.TabIndex = 4;
            flwCarrito.MouseUp += flwCarrito_MouseUp;
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Location = new Point(793, 9);
            fecha.Name = "fecha";
            fecha.Size = new Size(59, 25);
            fecha.TabIndex = 5;
            fecha.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 623);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 6;
            label2.Text = "Total:";
            // 
            // txtMonto
            // 
            txtMonto.AutoSize = true;
            txtMonto.Location = new Point(80, 623);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(0, 25);
            txtMonto.TabIndex = 7;
            // 
            // frmCarrito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(1074, 657);
            Controls.Add(txtMonto);
            Controls.Add(label2);
            Controls.Add(fecha);
            Controls.Add(btnConfirmar);
            Controls.Add(flwCarrito);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            ForeColor = SystemColors.Window;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCarrito";
            Text = "frmCarrito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConfirmar;
        private Label label1;
        public Label txtNombre;
        private FlowLayoutPanel flwCarrito;
        private Label fecha;
        private Label label2;
        private Label txtMonto;
    }
}