namespace SISTEMA_NOMINA
{
    partial class Form_AdministrarUsuario
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
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_AgrEmpresa = new System.Windows.Forms.Label();
            this.lbl_NomEmpresa = new System.Windows.Forms.Label();
            this.cb_Empresas = new System.Windows.Forms.ComboBox();
            this.lb_EmprAsignadas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.link_Regresar = new System.Windows.Forms.LinkLabel();
            this.btn_AgrEmpresa = new System.Windows.Forms.Button();
            this.cb_Usuarios = new System.Windows.Forms.ComboBox();
            this.btn_ConsultarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(47, 98);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(70, 21);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario:";
            this.lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_AgrEmpresa
            // 
            this.lbl_AgrEmpresa.AutoSize = true;
            this.lbl_AgrEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AgrEmpresa.Location = new System.Drawing.Point(47, 207);
            this.lbl_AgrEmpresa.Name = "lbl_AgrEmpresa";
            this.lbl_AgrEmpresa.Size = new System.Drawing.Size(174, 19);
            this.lbl_AgrEmpresa.TabIndex = 4;
            this.lbl_AgrEmpresa.Text = "Asignar una Empresa";
            // 
            // lbl_NomEmpresa
            // 
            this.lbl_NomEmpresa.AutoSize = true;
            this.lbl_NomEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomEmpresa.Location = new System.Drawing.Point(47, 235);
            this.lbl_NomEmpresa.Name = "lbl_NomEmpresa";
            this.lbl_NomEmpresa.Size = new System.Drawing.Size(81, 21);
            this.lbl_NomEmpresa.TabIndex = 5;
            this.lbl_NomEmpresa.Text = "Empresa:";
            this.lbl_NomEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_Empresas
            // 
            this.cb_Empresas.FormattingEnabled = true;
            this.cb_Empresas.Location = new System.Drawing.Point(249, 235);
            this.cb_Empresas.Name = "cb_Empresas";
            this.cb_Empresas.Size = new System.Drawing.Size(180, 21);
            this.cb_Empresas.TabIndex = 6;
            // 
            // lb_EmprAsignadas
            // 
            this.lb_EmprAsignadas.FormattingEnabled = true;
            this.lb_EmprAsignadas.Location = new System.Drawing.Point(51, 385);
            this.lb_EmprAsignadas.Name = "lb_EmprAsignadas";
            this.lb_EmprAsignadas.Size = new System.Drawing.Size(378, 212);
            this.lb_EmprAsignadas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(47, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Empresas Asigandas";
            // 
            // link_Regresar
            // 
            this.link_Regresar.AutoSize = true;
            this.link_Regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Regresar.Location = new System.Drawing.Point(44, 45);
            this.link_Regresar.Name = "link_Regresar";
            this.link_Regresar.Size = new System.Drawing.Size(92, 21);
            this.link_Regresar.TabIndex = 9;
            this.link_Regresar.TabStop = true;
            this.link_Regresar.Text = "< Regresar";
            this.link_Regresar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Regresar_LinkClicked);
            // 
            // btn_AgrEmpresa
            // 
            this.btn_AgrEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgrEmpresa.Location = new System.Drawing.Point(51, 285);
            this.btn_AgrEmpresa.Name = "btn_AgrEmpresa";
            this.btn_AgrEmpresa.Size = new System.Drawing.Size(378, 33);
            this.btn_AgrEmpresa.TabIndex = 11;
            this.btn_AgrEmpresa.Text = "Agregar Empresa";
            this.btn_AgrEmpresa.UseVisualStyleBackColor = true;
            this.btn_AgrEmpresa.Click += new System.EventHandler(this.btn_AgrEmpresa_Click);
            // 
            // cb_Usuarios
            // 
            this.cb_Usuarios.FormattingEnabled = true;
            this.cb_Usuarios.Location = new System.Drawing.Point(249, 98);
            this.cb_Usuarios.Name = "cb_Usuarios";
            this.cb_Usuarios.Size = new System.Drawing.Size(180, 21);
            this.cb_Usuarios.TabIndex = 12;
            // 
            // btn_ConsultarUsuario
            // 
            this.btn_ConsultarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarUsuario.Location = new System.Drawing.Point(51, 141);
            this.btn_ConsultarUsuario.Name = "btn_ConsultarUsuario";
            this.btn_ConsultarUsuario.Size = new System.Drawing.Size(378, 33);
            this.btn_ConsultarUsuario.TabIndex = 13;
            this.btn_ConsultarUsuario.Text = "Consultar Usuario";
            this.btn_ConsultarUsuario.UseVisualStyleBackColor = true;
            this.btn_ConsultarUsuario.Click += new System.EventHandler(this.btn_ConsultarUsuario_Click);
            // 
            // Form_AdministrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 654);
            this.Controls.Add(this.btn_ConsultarUsuario);
            this.Controls.Add(this.cb_Usuarios);
            this.Controls.Add(this.btn_AgrEmpresa);
            this.Controls.Add(this.link_Regresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_EmprAsignadas);
            this.Controls.Add(this.cb_Empresas);
            this.Controls.Add(this.lbl_NomEmpresa);
            this.Controls.Add(this.lbl_AgrEmpresa);
            this.Controls.Add(this.lbl_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form_AdministrarUsuario";
            this.Text = "Form_AdministrarUsuario";
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.Form_AdministrarUsuario_BackgroundImageLayoutChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_AgrEmpresa;
        private System.Windows.Forms.Label lbl_NomEmpresa;
        private System.Windows.Forms.ComboBox cb_Empresas;
        private System.Windows.Forms.ListBox lb_EmprAsignadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_Regresar;
        private System.Windows.Forms.Button btn_AgrEmpresa;
        private System.Windows.Forms.ComboBox cb_Usuarios;
        private System.Windows.Forms.Button btn_ConsultarUsuario;
    }
}