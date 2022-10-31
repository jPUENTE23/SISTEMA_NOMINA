namespace SISTEMA_NOMINA
{
    partial class Form_SeleccionarEmpr
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.link_CambiarUsuario = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(76, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 199);
            this.listBox1.TabIndex = 1;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(76, 337);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(262, 34);
            this.btn_Ingresar.TabIndex = 2;
            this.btn_Ingresar.Text = "Ingresar a la Empresa";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // link_CambiarUsuario
            // 
            this.link_CambiarUsuario.AutoSize = true;
            this.link_CambiarUsuario.Location = new System.Drawing.Point(76, 56);
            this.link_CambiarUsuario.Name = "link_CambiarUsuario";
            this.link_CambiarUsuario.Size = new System.Drawing.Size(99, 13);
            this.link_CambiarUsuario.TabIndex = 3;
            this.link_CambiarUsuario.TabStop = true;
            this.link_CambiarUsuario.Text = "Cambiar de Usuario";
            this.link_CambiarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_CambiarUsuario_LinkClicked);
            // 
            // Form_SeleccionarEmpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 464);
            this.Controls.Add(this.link_CambiarUsuario);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.listBox1);
            this.Name = "Form_SeleccionarEmpr";
            this.Text = "Form_SeleccionarEmpr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.LinkLabel link_CambiarUsuario;
    }
}