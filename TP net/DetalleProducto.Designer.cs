using BusinessEntities;
using BusinessLogic;

namespace TP_net
{
    partial class frmDetalleProducto
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
            txtNombreProd = new Label();
            txtMarca = new Label();
            pbxFoto = new PictureBox();
            txtDescripcion = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrecioUnitario = new Label();
            txtPrecioX10 = new Label();
            txtStock = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxFoto).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProd
            // 
            txtNombreProd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreProd.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombreProd.ForeColor = SystemColors.ControlLightLight;
            txtNombreProd.Location = new Point(291, 20);
            txtNombreProd.Margin = new Padding(4, 0, 4, 0);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(349, 53);
            txtNombreProd.TabIndex = 0;
            txtNombreProd.Text = "Nombre de producto";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(291, 73);
            txtMarca.Margin = new Padding(4, 0, 4, 0);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(581, 55);
            txtMarca.TabIndex = 1;
            txtMarca.Text = "Marca";
            // 
            // pbxFoto
            // 
            pbxFoto.Location = new Point(17, 20);
            pbxFoto.Margin = new Padding(4, 5, 4, 5);
            pbxFoto.Name = "pbxFoto";
            pbxFoto.Size = new Size(266, 347);
            pbxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFoto.TabIndex = 2;
            pbxFoto.TabStop = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(17, 432);
            txtDescripcion.Margin = new Padding(4, 0, 4, 0);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(623, 197);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.Text = "Descripcion producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 392);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 40);
            label1.TabIndex = 4;
            label1.Text = "Descripcion del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(291, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 7;
            label2.Text = "Precio unitario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(291, 212);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(241, 25);
            label3.TabIndex = 8;
            label3.Text = "Precio comprando 10 o más:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(291, 300);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 9;
            label4.Text = "Stock disponible:";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.AutoSize = true;
            txtPrecioUnitario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioUnitario.Location = new Point(291, 158);
            txtPrecioUnitario.Margin = new Padding(4, 0, 4, 0);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(140, 32);
            txtPrecioUnitario.TabIndex = 10;
            txtPrecioUnitario.Text = "pcio unitaio";
            // 
            // txtPrecioX10
            // 
            txtPrecioX10.AutoSize = true;
            txtPrecioX10.BackColor = SystemColors.WindowText;
            txtPrecioX10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioX10.Location = new Point(291, 237);
            txtPrecioX10.Margin = new Padding(4, 0, 4, 0);
            txtPrecioX10.Name = "txtPrecioX10";
            txtPrecioX10.Size = new Size(106, 32);
            txtPrecioX10.TabIndex = 11;
            txtPrecioX10.Text = "pcio X10";
            // 
            // txtStock
            // 
            txtStock.AutoSize = true;
            txtStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(291, 325);
            txtStock.Margin = new Padding(4, 0, 4, 0);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(69, 32);
            txtStock.TabIndex = 12;
            txtStock.Text = "stock";
            // 
            // frmDetalleProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(657, 665);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioX10);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(pbxFoto);
            Controls.Add(txtMarca);
            Controls.Add(txtNombreProd);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmDetalleProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleProducto";
            ((System.ComponentModel.ISupportInitialize)pbxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label txtNombreProd;
        public Label txtMarca;
        public PictureBox pbxFoto;
        public Label txtDescripcion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public Label txtPrecioUnitario;
        public Label txtPrecioX10;
        public Label txtStock;


        public void MuestraProd(ProductoBE p)
        {
            //ProductoBL prod = new ProductoBL();
            //ProductoBE productoABuscar = prod.MostrarProducto(p);
            //txtNombreProd.Text = productoABuscar.Nombre;
            txtNombreProd.Text = p.Nombre;
            txtMarca.Text = p.Marca;
            txtPrecioUnitario.Text = p.PrecioUnitario.ToString();
            txtPrecioX10.Text = p.PrecioX10.ToString();
            txtStock.Text = p.stock.ToString();
            txtDescripcion.Text = p.Descripcion;
            if (p.imagen != null)
            {
                MemoryStream ms = new MemoryStream(p.imagen);
                pbxFoto.Image = Image.FromStream(ms);
            }
            Show();
        }
    }
}