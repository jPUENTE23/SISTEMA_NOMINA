namespace SISTEMA_NOMINA
{
    partial class Form_UsuariosCreados
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
            this.lb_UsuariosCreados = new System.Windows.Forms.ListBox();
            this.link_regresar = new System.Windows.Forms.LinkLabel();
            this.lbl_UsuariosCreados = new System.Windows.Forms.Label();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.btn_AdminUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_UsuariosCreados
            // 
            this.lb_UsuariosCreados.FormattingEnabled = true;
            this.lb_UsuariosCreados.Location = new System.Drawing.Point(68, 143);
            this.lb_UsuariosCreados.Name = "lb_UsuariosCreados";
            this.lb_UsuariosCreados.Size = new System.Drawing.Size(274, 199);
            this.lb_UsuariosCreados.TabIndex = 0;
            // 
            // link_regresar
            // 
            this.link_regresar.AutoSize = true;
            this.link_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_regresar.Location = new System.Drawing.Point(64, 50);
            this.link_regresar.Name = "link_regresar";
            this.link_regresar.Size = new System.Drawing.Size(78, 21);
            this.link_regresar.TabIndex = 5;
            this.link_regresar.TabStop = true;
            this.link_regresar.Text = "Regresar";
            this.link_regresar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_regresar_LinkClicked);
            // 
            // lbl_UsuariosCreados
            // 
            this.lbl_UsuariosCreados.AutoSize = true;
            this.lbl_UsuariosCreados.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsuariosCreados.Location = new System.Drawing.Point(63, 93);
            this.lbl_UsuariosCreados.Name = "lbl_UsuariosCreados";
            this.lbl_UsuariosCreados.Size = new System.Drawing.Size(188, 25);
            this.lbl_UsuariosCreados.TabIndex = 4;
            this.lbl_UsuariosCreados.Text = "Usuarios Creados";
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearUsuario.Location = new System.Drawing.Point(68, 363);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(274, 35);
            this.btn_CrearUsuario.TabIndex = 6;
            this.btn_CrearUsuario.Text = "Crear Usuario";
            this.btn_CrearUsuario.UseVisualStyleBackColor = true;
            this.btn_CrearUsuario.Click += new System.EventHandler(this.btn_CrearUsuario_Click);
            // 
            // btn_AdminUsuario
            // 
            this.btn_AdminUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminUsuario.Location = new System.Drawing.Point(68, 404);
            this.btn_AdminUsuario.Name = "btn_AdminUsuario";
            this.btn_AdminUsuario.Size = new System.Drawing.Size(274, 35);
            this.btn_AdminUsuario.TabIndex = 7;
            this.btn_AdminUsuario.Text = "Administrar Usuario";
            this.btn_AdminUsuario.UseVisualStyleBackColor = true;
            this.btn_AdminUsuario.Click += new System.EventHandler(this.btn_AdminUsuario_Click);
            // 
            // Form_UsuariosCreados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 544);
            this.Controls.Add(this.btn_AdminUsuario);
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.link_regresar);
            this.Controls.Add(this.lbl_UsuariosCreados);
            this.Controls.Add(this.lb_UsuariosCreados);
            this.Name = "Form_UsuariosCreados";
            this.Text = "Form_UsuariosCreados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_UsuariosCreados;
        private System.Windows.Forms.LinkLabel link_regresar;
        private System.Windows.Forms.Label lbl_UsuariosCreados;
        private System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.Button btn_AdminUsuario;
    }
}