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
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.link_CambiarUsuario = new System.Windows.Forms.LinkLabel();
            this.cb_EmpresasUsuarios = new System.Windows.Forms.ComboBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_usuarioSleccionado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.Location = new System.Drawing.Point(76, 185);
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
            this.link_CambiarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_CambiarUsuario.Location = new System.Drawing.Point(72, 81);
            this.link_CambiarUsuario.Name = "link_CambiarUsuario";
            this.link_CambiarUsuario.Size = new System.Drawing.Size(178, 21);
            this.link_CambiarUsuario.TabIndex = 3;
            this.link_CambiarUsuario.TabStop = true;
            this.link_CambiarUsuario.Text = "< Cambiar de Usuario";
            this.link_CambiarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_CambiarUsuario_LinkClicked);
            // 
            // cb_EmpresasUsuarios
            // 
            this.cb_EmpresasUsuarios.FormattingEnabled = true;
            this.cb_EmpresasUsuarios.Location = new System.Drawing.Point(76, 144);
            this.cb_EmpresasUsuarios.Name = "cb_EmpresasUsuarios";
            this.cb_EmpresasUsuarios.Size = new System.Drawing.Size(262, 21);
            this.cb_EmpresasUsuarios.TabIndex = 4;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(73, 48);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(63, 16);
            this.lbl_Usuario.TabIndex = 5;
            this.lbl_Usuario.Text = "Usuario: ";
            // 
            // lbl_usuarioSleccionado
            // 
            this.lbl_usuarioSleccionado.AutoSize = true;
            this.lbl_usuarioSleccionado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarioSleccionado.Location = new System.Drawing.Point(133, 48);
            this.lbl_usuarioSleccionado.Name = "lbl_usuarioSleccionado";
            this.lbl_usuarioSleccionado.Size = new System.Drawing.Size(152, 17);
            this.lbl_usuarioSleccionado.TabIndex = 6;
            this.lbl_usuarioSleccionado.Text = "(Nombre del usuario): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecciona la empresa a trabajar";
            // 
            // Form_SeleccionarEmpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_usuarioSleccionado);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.cb_EmpresasUsuarios);
            this.Controls.Add(this.link_CambiarUsuario);
            this.Controls.Add(this.btn_Ingresar);
            this.Name = "Form_SeleccionarEmpr";
            this.Text = "Form_SeleccionarEmpr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.LinkLabel link_CambiarUsuario;
        private System.Windows.Forms.ComboBox cb_EmpresasUsuarios;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_usuarioSleccionado;
    }
}