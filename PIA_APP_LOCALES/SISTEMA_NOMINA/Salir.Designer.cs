﻿namespace SISTEMA_NOMINA
{
    partial class Salir
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Si = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Estas seguro que quieres salir del sistema?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Si
            // 
            this.btn_Si.Location = new System.Drawing.Point(89, 79);
            this.btn_Si.Name = "btn_Si";
            this.btn_Si.Size = new System.Drawing.Size(138, 24);
            this.btn_Si.TabIndex = 1;
            this.btn_Si.Text = "Si";
            this.btn_Si.UseVisualStyleBackColor = true;
            this.btn_Si.Click += new System.EventHandler(this.btn_Si_Click);
            // 
            // btn_No
            // 
            this.btn_No.Location = new System.Drawing.Point(247, 79);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(138, 24);
            this.btn_No.TabIndex = 2;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // Salir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 134);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Si);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salir";
            this.Text = "Salir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Si;
        private System.Windows.Forms.Button btn_No;
    }
}