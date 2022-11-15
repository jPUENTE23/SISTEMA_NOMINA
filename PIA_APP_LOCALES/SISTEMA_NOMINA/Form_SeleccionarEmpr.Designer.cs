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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SeleccionarEmpr));
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.cb_EmpresasUsuarios = new System.Windows.Forms.ComboBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_usuarioSleccionado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_RegLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RegLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.Location = new System.Drawing.Point(43, 155);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(329, 34);
            this.btn_Ingresar.TabIndex = 2;
            this.btn_Ingresar.Text = "Ingresar a la Empresa";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // cb_EmpresasUsuarios
            // 
            this.cb_EmpresasUsuarios.FormattingEnabled = true;
            this.cb_EmpresasUsuarios.Location = new System.Drawing.Point(43, 114);
            this.cb_EmpresasUsuarios.Name = "cb_EmpresasUsuarios";
            this.cb_EmpresasUsuarios.Size = new System.Drawing.Size(329, 21);
            this.cb_EmpresasUsuarios.TabIndex = 4;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(68, 54);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(63, 16);
            this.lbl_Usuario.TabIndex = 5;
            this.lbl_Usuario.Text = "Usuario: ";
            // 
            // lbl_usuarioSleccionado
            // 
            this.lbl_usuarioSleccionado.AutoSize = true;
            this.lbl_usuarioSleccionado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarioSleccionado.Location = new System.Drawing.Point(128, 54);
            this.lbl_usuarioSleccionado.Name = "lbl_usuarioSleccionado";
            this.lbl_usuarioSleccionado.Size = new System.Drawing.Size(152, 17);
            this.lbl_usuarioSleccionado.TabIndex = 6;
            this.lbl_usuarioSleccionado.Text = "(Nombre del usuario): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecciona la empresa a trabajar";
            // 
            // pictureBox_RegLogin
            // 
            this.pictureBox_RegLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_RegLogin.Image")));
            this.pictureBox_RegLogin.Location = new System.Drawing.Point(43, 51);
            this.pictureBox_RegLogin.Name = "pictureBox_RegLogin";
            this.pictureBox_RegLogin.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_RegLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_RegLogin.TabIndex = 8;
            this.pictureBox_RegLogin.TabStop = false;
            this.pictureBox_RegLogin.Click += new System.EventHandler(this.pictureBox_RegLogin_Click);
            // 
            // Form_SeleccionarEmpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 249);
            this.Controls.Add(this.pictureBox_RegLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_usuarioSleccionado);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.cb_EmpresasUsuarios);
            this.Controls.Add(this.btn_Ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SeleccionarEmpr";
            this.Text = "Form_SeleccionarEmpr";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RegLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.ComboBox cb_EmpresasUsuarios;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_usuarioSleccionado;
        private System.Windows.Forms.PictureBox pictureBox_RegLogin;
    }
}