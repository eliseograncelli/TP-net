namespace TP_net
{
    partial class frmVendedor
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
            splitContainer1 = new SplitContainer();
            IDVendedorlabel = new Label();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label13 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label12 = new Label();
            button8 = new Button();
            textBox7 = new TextBox();
            idProducto = new Label();
            IdTxt = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            label11 = new Label();
            textBox6 = new TextBox();
            button4 = new Button();
            label10 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ActiveCaptionText;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.WindowFrame;
            splitContainer1.Panel1.Controls.Add(IDVendedorlabel);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtTotal);
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(button8);
            splitContainer1.Panel2.Controls.Add(textBox7);
            splitContainer1.Panel2.Controls.Add(idProducto);
            splitContainer1.Panel2.Controls.Add(IdTxt);
            splitContainer1.Panel2.Controls.Add(button7);
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Panel2.Controls.Add(textBox6);
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(textBox5);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(textBox4);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(textBox3);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2MinSize = 950;
            splitContainer1.Size = new Size(1197, 705);
            splitContainer1.SplitterDistance = 243;
            splitContainer1.TabIndex = 0;
            // 
            // IDVendedorlabel
            // 
            IDVendedorlabel.AutoSize = true;
            IDVendedorlabel.Location = new Point(137, 551);
            IDVendedorlabel.Name = "IDVendedorlabel";
            IDVendedorlabel.Size = new Size(0, 25);
            IDVendedorlabel.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 551);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 4;
            label5.Text = "Id Vendedor: ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 576);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 3;
            label4.Text = "Nombre Vendedor";
            // 
            // button3
            // 
            button3.Location = new Point(21, 286);
            button3.Name = "button3";
            button3.Size = new Size(200, 54);
            button3.TabIndex = 2;
            button3.Text = "VENTAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 217);
            button2.Name = "button2";
            button2.Size = new Size(200, 54);
            button2.TabIndex = 1;
            button2.Text = "Reportes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 356);
            button1.Name = "button1";
            button1.Size = new Size(200, 54);
            button1.TabIndex = 0;
            button1.Text = "PRODUCTOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(652, 671);
            label13.Name = "label13";
            label13.Size = new Size(134, 25);
            label13.TabIndex = 6;
            label13.Text = "Total de ventas:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = SystemColors.AppWorkspace;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Modern No. 20", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 18);
            label3.Name = "label3";
            label3.Size = new Size(920, 56);
            label3.TabIndex = 2;
            label3.Text = "VENTAS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(18, 97);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(920, 560);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaptionText;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(31, 376);
            label12.Name = "label12";
            label12.Size = new Size(55, 25);
            label12.TabIndex = 25;
            label12.Text = "Stock";
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveBorder;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(183, 404);
            button8.Name = "button8";
            button8.Size = new Size(40, 40);
            button8.TabIndex = 24;
            button8.Text = "+";
            button8.TextAlign = ContentAlignment.TopCenter;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(31, 404);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(146, 40);
            textBox7.TabIndex = 0;
            textBox7.Text = "0";
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // idProducto
            // 
            idProducto.AutoSize = true;
            idProducto.BackColor = SystemColors.ActiveCaptionText;
            idProducto.ForeColor = SystemColors.ButtonHighlight;
            idProducto.Location = new Point(242, 98);
            idProducto.Name = "idProducto";
            idProducto.Size = new Size(0, 25);
            idProducto.TabIndex = 22;
            // 
            // IdTxt
            // 
            IdTxt.AutoSize = true;
            IdTxt.BackColor = SystemColors.ActiveCaptionText;
            IdTxt.ForeColor = SystemColors.ButtonHighlight;
            IdTxt.Location = new Point(196, 98);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(32, 25);
            IdTxt.TabIndex = 21;
            IdTxt.Text = "Id:";
            // 
            // button7
            // 
            button7.BackColor = Color.RosyBrown;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(792, 403);
            button7.Name = "button7";
            button7.Size = new Size(146, 73);
            button7.TabIndex = 20;
            button7.Text = "Eliminar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(640, 403);
            button6.Name = "button6";
            button6.Size = new Size(146, 73);
            button6.TabIndex = 19;
            button6.Text = "Modificar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSeaGreen;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(488, 403);
            button5.Name = "button5";
            button5.Size = new Size(146, 73);
            button5.TabIndex = 18;
            button5.Text = "Agregar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaptionText;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(516, 98);
            label11.Name = "label11";
            label11.Size = new Size(104, 25);
            label11.TabIndex = 17;
            label11.Text = "Descripcion";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(488, 126);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(450, 150);
            textBox6.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(31, 306);
            button4.Name = "button4";
            button4.Size = new Size(148, 34);
            button4.TabIndex = 15;
            button4.Text = "Examinar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ActiveCaptionText;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(792, 296);
            label10.Name = "label10";
            label10.Size = new Size(143, 25);
            label10.TabIndex = 14;
            label10.Text = "Precio Mayorista";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(488, 324);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(146, 31);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(640, 296);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 12;
            label9.Text = "Precio X10";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(792, 324);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 31);
            textBox4.TabIndex = 11;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(488, 296);
            label8.Name = "label8";
            label8.Size = new Size(146, 25);
            label8.TabIndex = 10;
            label8.Text = "Precio Unitario";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(640, 324);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 31);
            textBox3.TabIndex = 9;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(196, 217);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 8;
            label7.Text = "Marca";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 245);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 31);
            textBox2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(196, 155);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 6;
            label6.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 31);
            textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(18, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(6, 482);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 11;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 200;
            dataGridView1.Size = new Size(932, 211);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(18, 18);
            label2.Name = "label2";
            label2.Size = new Size(920, 56);
            label2.TabIndex = 1;
            label2.Text = "REPORTES";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(920, 56);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.BackColor = Color.Transparent;
            txtTotal.ForeColor = SystemColors.ControlLightLight;
            txtTotal.Location = new Point(792, 671);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(134, 25);
            txtTotal.TabIndex = 27;
            txtTotal.Text = "Total de ventas:";
            // 
            // frmVendedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 705);
            Controls.Add(splitContainer1);
            Name = "frmVendedor";
            Text = "frmVendedor";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Button button7;
        private Button button6;
        private Button button5;
        private Label label11;
        private TextBox textBox6;
        private Button button4;
        private Label label10;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label IDVendedorlabel;
        private Label IdTxt;
        private Label idProducto;
        private Button button8;
        private TextBox textBox7;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label13;
        private Label txtTotal;
    }
}