﻿namespace TP_net
{
    partial class frmMisCompras
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
            flwMisCompras = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowText;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 37);
            label1.TabIndex = 0;
            label1.Text = "MIS COMPRAS";
            // 
            // flwMisCompras
            // 
            flwMisCompras.Location = new Point(12, 106);
            flwMisCompras.Name = "flwMisCompras";
            flwMisCompras.Size = new Size(776, 305);
            flwMisCompras.TabIndex = 1;
            // 
            // frmMisCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(800, 450);
            Controls.Add(flwMisCompras);
            Controls.Add(label1);
            ForeColor = SystemColors.Window;
            Name = "frmMisCompras";
            Text = "frmMisCompras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flwMisCompras;
    }
}