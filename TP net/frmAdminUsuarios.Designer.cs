namespace TP_net
{
    partial class frmAdminUsuarios
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
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            label3 = new Label();
            picFoto = new PictureBox();
            btnExaminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnCancelar = new Button();
            dgvUsuarios = new DataGridView();
            txtDNI = new TextBox();
            label4 = new Label();
            cbxTipo = new ComboBox();
            label5 = new Label();
            cbxEstado = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtApellido = new TextBox();
            label8 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(127, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(127, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 43);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 94);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(127, 190);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(191, 23);
            txtContraseña.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(127, 173);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(15, 16);
            picFoto.Margin = new Padding(2);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(99, 92);
            picFoto.TabIndex = 6;
            picFoto.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(15, 114);
            btnExaminar.Margin = new Padding(2);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(99, 26);
            btnExaminar.TabIndex = 7;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(421, 231);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(68, 26);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(350, 231);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(67, 26);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(280, 231);
            btnBorrar.Margin = new Padding(2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(66, 26);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(127, 231);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 26);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeight = 34;
            dgvUsuarios.Location = new Point(16, 278);
            dgvUsuarios.Margin = new Padding(2);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(675, 189);
            dgvUsuarios.TabIndex = 0;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(333, 94);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(156, 23);
            txtDNI.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(333, 77);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 14;
            label4.Text = "DNI:";
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Cliente", "Mayorista", "Vendedor", "Administrador" });
            cbxTipo.Location = new Point(127, 143);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(191, 23);
            cbxTipo.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(127, 125);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 16;
            label5.Text = "Tipo:";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Inactivo", "Activo" });
            cbxEstado.Location = new Point(333, 143);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(156, 23);
            cbxEstado.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(333, 125);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 18;
            label6.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(333, 26);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 19;
            label7.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(333, 43);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(156, 23);
            txtApellido.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(333, 173);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 21;
            label8.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(333, 190);
            txtId.Name = "txtId";
            txtId.Size = new Size(156, 23);
            txtId.TabIndex = 22;
            // 
            // frmAdminUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(709, 478);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(txtApellido);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbxEstado);
            Controls.Add(label5);
            Controls.Add(cbxTipo);
            Controls.Add(label4);
            Controls.Add(txtDNI);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnExaminar);
            Controls.Add(picFoto);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmAdminUsuarios";
            Text = "frmAdministradorUsuarios";
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private Label label3;
        private PictureBox picFoto;
        private Button btnExaminar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnCancelar;
        private DataGridView dgvUsuarios;
        private TextBox txtDNI;
        private Label label4;
        private ComboBox cbxTipo;
        private Label label5;
        private ComboBox cbxEstado;
        private Label label6;
        private Label label7;
        private TextBox txtApellido;
        private Label label8;
        private TextBox txtId;
    }
}