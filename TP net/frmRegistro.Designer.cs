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
            label1.Location = new Point(169, 15);
            label1.Name = "label1";
            label1.Size = new Size(188, 28);
            label1.TabIndex = 0;
            label1.Text = "Registro de usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(52, 94);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(52, 147);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(52, 200);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(52, 308);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(114, 43);
            label7.Name = "label7";
            label7.Size = new Size(297, 28);
            label7.TabIndex = 6;
            label7.Text = "A continuacion ingrese sus datos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(52, 254);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 7;
            label8.Text = "Email:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(52, 112);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(178, 23);
            txtDni.TabIndex = 2;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(52, 165);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 23);
            txtNombre.TabIndex = 3;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(52, 218);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(178, 23);
            txtApellido.TabIndex = 4;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(52, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 5;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(52, 326);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(178, 23);
            txtContraseña.TabIndex = 6;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.ForeColor = SystemColors.WindowText;
            btnCrearCuenta.Location = new Point(354, 355);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(155, 52);
            btnCrearCuenta.TabIndex = 10;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // ckbVendedor
            // 
            ckbVendedor.AutoSize = true;
            ckbVendedor.ForeColor = SystemColors.ControlLightLight;
            ckbVendedor.Location = new Point(326, 297);
            ckbVendedor.Name = "ckbVendedor";
            ckbVendedor.Size = new Size(76, 19);
            ckbVendedor.TabIndex = 9;
            ckbVendedor.Text = "Vendedor";
            ckbVendedor.UseVisualStyleBackColor = true;
            ckbVendedor.CheckedChanged += ckbVendedor_CheckedChanged;
            // 
            // imgFoto
            // 
            imgFoto.Location = new Point(328, 112);
            imgFoto.Name = "imgFoto";
            imgFoto.Size = new Size(116, 103);
            imgFoto.TabIndex = 18;
            imgFoto.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.ForeColor = SystemColors.WindowText;
            btnExaminar.Location = new Point(348, 221);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(75, 23);
            btnExaminar.TabIndex = 7;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 94);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 20;
            label6.Text = "Cargue una imagen:";
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(521, 419);
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
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
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