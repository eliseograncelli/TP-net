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
            dgvCarrito = new DataGridView();
            btnConfirmar = new Button();
            label1 = new Label();
            txtNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // dgvCarrito
            // 
            dgvCarrito.BackgroundColor = SystemColors.MenuText;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.GridColor = SystemColors.WindowText;
            dgvCarrito.Location = new Point(12, 42);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new Size(609, 305);
            dgvCarrito.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Lime;
            btnConfirmar.ForeColor = SystemColors.ControlLightLight;
            btnConfirmar.Location = new Point(505, 334);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(105, 48);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar compra";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 2;
            label1.Text = "Carrito";
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(12, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(38, 15);
            txtNombre.TabIndex = 3;
            txtNombre.Text = "label2";
            // 
            // frmCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(633, 394);
            Controls.Add(txtNombre);
            Controls.Add(btnConfirmar);
            Controls.Add(label1);
            Controls.Add(dgvCarrito);
            ForeColor = SystemColors.Window;
            Name = "frmCarrito";
            Text = "frmCarrito";
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvCarrito;
        private Button btnConfirmar;
        private Label label1;
        public Label txtNombre;
    }
}