using System.Runtime.CompilerServices;

namespace TP_net
{
    partial class frmRegistro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            ckbMayorista = new CheckBox();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            btnCrearCuenta = new Button();
            ckbVendedor = new CheckBox();
            imgFoto = new PictureBox();
            btnExaminar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(241, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 41);
            label1.TabIndex = 0;
            label1.Text = "Registro de usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(74, 157);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(74, 245);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(74, 333);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 3;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(74, 513);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 4;
            label5.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(163, 72);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(454, 41);
            label7.TabIndex = 6;
            label7.Text = "A continuacion ingrese sus datos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(74, 423);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 7;
            label8.Text = "Email:";
            // 
            // ckbMayorista
            // 
            ckbMayorista.AutoSize = true;
            ckbMayorista.ForeColor = Color.White;
            ckbMayorista.Location = new Point(466, 453);
            ckbMayorista.Margin = new Padding(4, 5, 4, 5);
            ckbMayorista.Name = "ckbMayorista";
            ckbMayorista.Size = new Size(174, 29);
            ckbMayorista.TabIndex = 8;
            ckbMayorista.Text = "Cliente mayorista";
            ckbMayorista.UseVisualStyleBackColor = true;
            ckbMayorista.CheckedChanged += ckbMayorista_CheckedChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(74, 187);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(253, 31);
            txtDni.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 275);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(74, 363);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 31);
            txtApellido.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 453);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 31);
            txtEmail.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(74, 543);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(253, 31);
            txtContraseña.TabIndex = 6;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.ForeColor = SystemColors.WindowText;
            btnCrearCuenta.Location = new Point(506, 592);
            btnCrearCuenta.Margin = new Padding(4, 5, 4, 5);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(221, 87);
            btnCrearCuenta.TabIndex = 10;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // ckbVendedor
            // 
            ckbVendedor.AutoSize = true;
            ckbVendedor.ForeColor = SystemColors.ControlLightLight;
            ckbVendedor.Location = new Point(466, 495);
            ckbVendedor.Margin = new Padding(4, 5, 4, 5);
            ckbVendedor.Name = "ckbVendedor";
            ckbVendedor.Size = new Size(115, 29);
            ckbVendedor.TabIndex = 9;
            ckbVendedor.Text = "Vendedor";
            ckbVendedor.UseVisualStyleBackColor = true;
            ckbVendedor.CheckedChanged += ckbVendedor_CheckedChanged;
            // 
            // imgFoto
            // 
            imgFoto.Location = new Point(469, 187);
            imgFoto.Margin = new Padding(4, 5, 4, 5);
            imgFoto.Name = "imgFoto";
            imgFoto.Size = new Size(166, 172);
            imgFoto.TabIndex = 18;
            imgFoto.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.ForeColor = SystemColors.WindowText;
            btnExaminar.Location = new Point(497, 368);
            btnExaminar.Margin = new Padding(4, 5, 4, 5);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(107, 38);
            btnExaminar.TabIndex = 7;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 157);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(170, 25);
            label6.TabIndex = 20;
            label6.Text = "Cargue una imagen:";
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(744, 698);
            Controls.Add(label6);
            Controls.Add(btnExaminar);
            Controls.Add(imgFoto);
            Controls.Add(ckbVendedor);
            Controls.Add(btnCrearCuenta);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(ckbMayorista);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRegistro";
            Text = "frmRegistro";
            ((System.ComponentModel.ISupportInitialize)imgFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private CheckBox ckbMayorista;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private Button btnCrearCuenta;
        private CheckBox ckbVendedor;
        private PictureBox imgFoto;
        private Button btnExaminar;
        private Label label6;
    }
}