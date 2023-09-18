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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            lnkOlvidaPass = new LinkLabel();
            btnIniciarSesion = new Button();
            lnkCrearCuenta = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(76, 36);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(54, 64);
            label2.Name = "label2";
            label2.Size = new Size(181, 15);
            label2.TabIndex = 1;
            label2.Text = "A continuación ingrese sus datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(54, 120);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(54, 173);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(54, 191);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(181, 23);
            txtContraseña.TabIndex = 5;
            // 
            // lnkOlvidaPass
            // 
            lnkOlvidaPass.AutoSize = true;
            lnkOlvidaPass.Location = new Point(116, 217);
            lnkOlvidaPass.Name = "lnkOlvidaPass";
            lnkOlvidaPass.Size = new Size(119, 15);
            lnkOlvidaPass.TabIndex = 6;
            lnkOlvidaPass.TabStop = true;
            lnkOlvidaPass.Text = "Olvidé mi contraseña";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(88, 246);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(110, 44);
            btnIniciarSesion.TabIndex = 7;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lnkCrearCuenta
            // 
            lnkCrearCuenta.AutoSize = true;
            lnkCrearCuenta.Location = new Point(12, 305);
            lnkCrearCuenta.Name = "lnkCrearCuenta";
            lnkCrearCuenta.Size = new Size(96, 15);
            lnkCrearCuenta.TabIndex = 8;
            lnkCrearCuenta.TabStop = true;
            lnkCrearCuenta.Text = "No tengo cuenta";
            lnkCrearCuenta.LinkClicked += lnkCrearCuenta_LinkClicked;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(294, 329);
            Controls.Add(lnkCrearCuenta);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lnkOlvidaPass);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}