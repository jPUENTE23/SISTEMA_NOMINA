namespace SISTEMA_NOMINA
{
    partial class Form_EmpresasCreadas
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
            this.lbl_EmpresasCreadas = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_NuevaEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_EmpresasCreadas
            // 
            this.lbl_EmpresasCreadas.AutoSize = true;
            this.lbl_EmpresasCreadas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmpresasCreadas.Location = new System.Drawing.Point(66, 118);
            this.lbl_EmpresasCreadas.Name = "lbl_EmpresasCreadas";
            this.lbl_EmpresasCreadas.Size = new System.Drawing.Size(202, 25);
            this.lbl_EmpresasCreadas.TabIndex = 0;
            this.lbl_EmpresasCreadas.Text = "Empresas Creadas";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(71, 173);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 160);
            this.listBox1.TabIndex = 1;
            // 
            // btn_NuevaEmpresa
            // 
            this.btn_NuevaEmpresa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaEmpresa.Location = new System.Drawing.Point(71, 371);
            this.btn_NuevaEmpresa.Name = "btn_NuevaEmpresa";
            this.btn_NuevaEmpresa.Size = new System.Drawing.Size(314, 31);
            this.btn_NuevaEmpresa.TabIndex = 2;
            this.btn_NuevaEmpresa.Text = "Nueva Empresa";
            this.btn_NuevaEmpresa.UseVisualStyleBackColor = true;
            this.btn_NuevaEmpresa.Click += new System.EventHandler(this.btn_NuevaEmpresa_Click);
            // 
            // Form_EmpresasCreadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 591);
            this.Controls.Add(this.btn_NuevaEmpresa);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_EmpresasCreadas);
            this.Name = "Form_EmpresasCreadas";
            this.Text = "Form_EmpresasCreadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EmpresasCreadas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_NuevaEmpresa;
    }
}