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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UsuariosCreados));
            this.lb_UsuariosCreados = new System.Windows.Forms.ListBox();
            this.lbl_UsuariosCreados = new System.Windows.Forms.Label();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.btn_AdminUsuario = new System.Windows.Forms.Button();
            this.pictureBox_RegLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RegLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_UsuariosCreados
            // 
            this.lb_UsuariosCreados.FormattingEnabled = true;
            this.lb_UsuariosCreados.Location = new System.Drawing.Point(66, 101);
            this.lb_UsuariosCreados.Name = "lb_UsuariosCreados";
            this.lb_UsuariosCreados.Size = new System.Drawing.Size(274, 199);
            this.lb_UsuariosCreados.TabIndex = 0;
            this.lb_UsuariosCreados.SelectedIndexChanged += new System.EventHandler(this.lb_UsuariosCreados_SelectedIndexChanged);
            // 
            // lbl_UsuariosCreados
            // 
            this.lbl_UsuariosCreados.AutoSize = true;
            this.lbl_UsuariosCreados.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsuariosCreados.Location = new System.Drawing.Point(61, 64);
            this.lbl_UsuariosCreados.Name = "lbl_UsuariosCreados";
            this.lbl_UsuariosCreados.Size = new System.Drawing.Size(188, 25);
            this.lbl_UsuariosCreados.TabIndex = 4;
            this.lbl_UsuariosCreados.Text = "Usuarios Creados";
            this.lbl_UsuariosCreados.Click += new System.EventHandler(this.lbl_UsuariosCreados_Click);
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearUsuario.Location = new System.Drawing.Point(66, 321);
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
            this.btn_AdminUsuario.Location = new System.Drawing.Point(66, 362);
            this.btn_AdminUsuario.Name = "btn_AdminUsuario";
            this.btn_AdminUsuario.Size = new System.Drawing.Size(274, 35);
            this.btn_AdminUsuario.TabIndex = 7;
            this.btn_AdminUsuario.Text = "Administrar Usuario";
            this.btn_AdminUsuario.UseVisualStyleBackColor = true;
            this.btn_AdminUsuario.Click += new System.EventHandler(this.btn_AdminUsuario_Click);
            // 
            // pictureBox_RegLogin
            // 
            this.pictureBox_RegLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_RegLogin.Image")));
            this.pictureBox_RegLogin.Location = new System.Drawing.Point(177, 430);
            this.pictureBox_RegLogin.Name = "pictureBox_RegLogin";
            this.pictureBox_RegLogin.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_RegLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_RegLogin.TabIndex = 9;
            this.pictureBox_RegLogin.TabStop = false;
            this.pictureBox_RegLogin.Click += new System.EventHandler(this.pictureBox_RegLogin_Click);
            // 
            // Form_UsuariosCreados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 544);
            this.Controls.Add(this.pictureBox_RegLogin);
            this.Controls.Add(this.btn_AdminUsuario);
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.lbl_UsuariosCreados);
            this.Controls.Add(this.lb_UsuariosCreados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_UsuariosCreados";
            this.Text = "Form_UsuariosCreados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RegLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_UsuariosCreados;
        private System.Windows.Forms.Label lbl_UsuariosCreados;
        private System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.Button btn_AdminUsuario;
        private System.Windows.Forms.PictureBox pictureBox_RegLogin;
    }
}