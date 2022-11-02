namespace SISTEMA_NOMINA
{
    partial class Form_CrearEmpresa
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RFCEmpr = new System.Windows.Forms.TextBox();
            this.txt_NomEmpresa = new System.Windows.Forms.TextBox();
            this.btn_GenerarEmpr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Empresa";
            // 
            // txt_RFCEmpr
            // 
            this.txt_RFCEmpr.Location = new System.Drawing.Point(63, 109);
            this.txt_RFCEmpr.Name = "txt_RFCEmpr";
            this.txt_RFCEmpr.Size = new System.Drawing.Size(254, 20);
            this.txt_RFCEmpr.TabIndex = 2;
            // 
            // txt_NomEmpresa
            // 
            this.txt_NomEmpresa.Location = new System.Drawing.Point(63, 173);
            this.txt_NomEmpresa.Name = "txt_NomEmpresa";
            this.txt_NomEmpresa.Size = new System.Drawing.Size(254, 20);
            this.txt_NomEmpresa.TabIndex = 3;
            // 
            // btn_GenerarEmpr
            // 
            this.btn_GenerarEmpr.Location = new System.Drawing.Point(63, 231);
            this.btn_GenerarEmpr.Name = "btn_GenerarEmpr";
            this.btn_GenerarEmpr.Size = new System.Drawing.Size(254, 23);
            this.btn_GenerarEmpr.TabIndex = 4;
            this.btn_GenerarEmpr.Text = "CrearEmpresa";
            this.btn_GenerarEmpr.UseVisualStyleBackColor = true;
            this.btn_GenerarEmpr.Click += new System.EventHandler(this.btn_GenerarEmpr_Click);
            // 
            // Form_CrearEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 410);
            this.Controls.Add(this.btn_GenerarEmpr);
            this.Controls.Add(this.txt_NomEmpresa);
            this.Controls.Add(this.txt_RFCEmpr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_CrearEmpresa";
            this.Text = "Form_CrearEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RFCEmpr;
        private System.Windows.Forms.TextBox txt_NomEmpresa;
        private System.Windows.Forms.Button btn_GenerarEmpr;
    }
}