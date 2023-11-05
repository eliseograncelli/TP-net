namespace TP_net
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            lnkOlvidaPass = new LinkLabel();
            btnIniciarSesion = new Button();
            lnkCrearCuenta = new LinkLabel();
            ckbMostrarPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(109, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 41);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(77, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(273, 25);
            label2.TabIndex = 1;
            label2.Text = "A continuación ingrese sus datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(77, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(77, 288);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(77, 230);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 31);
            txtEmail.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(77, 318);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(257, 31);
            txtContraseña.TabIndex = 5;
            // 
            // lnkOlvidaPass
            // 
            lnkOlvidaPass.AutoSize = true;
            lnkOlvidaPass.Location = new Point(166, 362);
            lnkOlvidaPass.Margin = new Padding(4, 0, 4, 0);
            lnkOlvidaPass.Name = "lnkOlvidaPass";
            lnkOlvidaPass.Size = new Size(179, 25);
            lnkOlvidaPass.TabIndex = 6;
            lnkOlvidaPass.TabStop = true;
            lnkOlvidaPass.Text = "Olvidé mi contraseña";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(126, 410);
            btnIniciarSesion.Margin = new Padding(4, 5, 4, 5);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(157, 73);
            btnIniciarSesion.TabIndex = 7;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lnkCrearCuenta
            // 
            lnkCrearCuenta.AutoSize = true;
            lnkCrearCuenta.Location = new Point(17, 508);
            lnkCrearCuenta.Margin = new Padding(4, 0, 4, 0);
            lnkCrearCuenta.Name = "lnkCrearCuenta";
            lnkCrearCuenta.Size = new Size(145, 25);
            lnkCrearCuenta.TabIndex = 8;
            lnkCrearCuenta.TabStop = true;
            lnkCrearCuenta.Text = "No tengo cuenta";
            lnkCrearCuenta.LinkClicked += lnkCrearCuenta_LinkClicked;
            // 
            // ckbMostrarPass
            // 
            ckbMostrarPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckbMostrarPass.ForeColor = SystemColors.Window;
            ckbMostrarPass.Image = (Image)resources.GetObject("ckbMostrarPass.Image");
            ckbMostrarPass.Location = new Point(344, 318);
            ckbMostrarPass.Margin = new Padding(4, 5, 4, 5);
            ckbMostrarPass.Name = "ckbMostrarPass";
            ckbMostrarPass.Size = new Size(53, 40);
            ckbMostrarPass.TabIndex = 9;
            ckbMostrarPass.CheckedChanged += ckbMostrarPass_CheckedChanged;
            // 
            // frmInicioSesion
            // 
            AcceptButton = btnIniciarSesion;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(430, 548);
            Controls.Add(ckbMostrarPass);
            Controls.Add(lnkCrearCuenta);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lnkOlvidaPass);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmInicioSesion";
            Text = "frmInicioSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private LinkLabel lnkOlvidaPass;
        private Button btnIniciarSesion;
        private LinkLabel lnkCrearCuenta;
        private CheckBox ckbMostrarPass;
    }
}