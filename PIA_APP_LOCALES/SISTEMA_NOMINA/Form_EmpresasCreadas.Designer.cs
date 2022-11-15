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
            this.lb_EmprCreadas = new System.Windows.Forms.ListBox();
            this.btn_NuevaEmpresa = new System.Windows.Forms.Button();
            this.link_regresar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_EmpresasCreadas
            // 
            this.lbl_EmpresasCreadas.AutoSize = true;
            this.lbl_EmpresasCreadas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmpresasCreadas.Location = new System.Drawing.Point(65, 100);
            this.lbl_EmpresasCreadas.Name = "lbl_EmpresasCreadas";
            this.lbl_EmpresasCreadas.Size = new System.Drawing.Size(202, 25);
            this.lbl_EmpresasCreadas.TabIndex = 0;
            this.lbl_EmpresasCreadas.Text = "Empresas Creadas";
            // 
            // lb_EmprCreadas
            // 
            this.lb_EmprCreadas.FormattingEnabled = true;
            this.lb_EmprCreadas.Location = new System.Drawing.Point(70, 155);
            this.lb_EmprCreadas.Name = "lb_EmprCreadas";
            this.lb_EmprCreadas.Size = new System.Drawing.Size(314, 160);
            this.lb_EmprCreadas.TabIndex = 1;
            // 
            // btn_NuevaEmpresa
            // 
            this.btn_NuevaEmpresa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaEmpresa.Location = new System.Drawing.Point(70, 353);
            this.btn_NuevaEmpresa.Name = "btn_NuevaEmpresa";
            this.btn_NuevaEmpresa.Size = new System.Drawing.Size(314, 31);
            this.btn_NuevaEmpresa.TabIndex = 2;
            this.btn_NuevaEmpresa.Text = "Nueva Empresa";
            this.btn_NuevaEmpresa.UseVisualStyleBackColor = true;
            this.btn_NuevaEmpresa.Click += new System.EventHandler(this.btn_NuevaEmpresa_Click);
            // 
            // link_regresar
            // 
            this.link_regresar.AutoSize = true;
            this.link_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_regresar.Location = new System.Drawing.Point(66, 57);
            this.link_regresar.Name = "link_regresar";
            this.link_regresar.Size = new System.Drawing.Size(78, 21);
            this.link_regresar.TabIndex = 3;
            this.link_regresar.TabStop = true;
            this.link_regresar.Text = "Regresar";
            this.link_regresar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_regresar_LinkClicked);
            // 
            // Form_EmpresasCreadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 447);
            this.Controls.Add(this.link_regresar);
            this.Controls.Add(this.btn_NuevaEmpresa);
            this.Controls.Add(this.lb_EmprCreadas);
            this.Controls.Add(this.lbl_EmpresasCreadas);
            this.Name = "Form_EmpresasCreadas";
            this.Text = "Form_EmpresasCreadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EmpresasCreadas;
        private System.Windows.Forms.ListBox lb_EmprCreadas;
        private System.Windows.Forms.Button btn_NuevaEmpresa;
        private System.Windows.Forms.LinkLabel link_regresar;
    }
}