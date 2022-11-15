namespace SISTEMA_NOMINA
{
    partial class Form_CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CrearUsuario));
            this.lbl_nomUsuario = new System.Windows.Forms.Label();
            this.lbl_Contrseña = new System.Windows.Forms.Label();
            this.lbl_ConfirmContrseña = new System.Windows.Forms.Label();
            this.txt_nomUsuario = new System.Windows.Forms.TextBox();
            this.txt_Contrseña = new System.Windows.Forms.TextBox();
            this.txt_confirmContraseña = new System.Windows.Forms.TextBox();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.link_Regresar = new System.Windows.Forms.LinkLabel();
            this.pictureBox_RegUsuariosC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RegUsuariosC)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nomUsuario
            // 
            this.lbl_nomUsuario.AutoSize = true;
            this.lbl_nomUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomUsuario.Location = new System.Drawing.Point(62, 117);
            this.lbl_nomUsuario.Name = "lbl_nomUsuario";
            this.lbl_nomUsuario.Size = new System.Drawing.Size(153, 20);
            this.lbl_nomUsuario.TabIndex = 0;
            this.lbl_nomUsuario.Text = "Nombre del Usuario";
            this.lbl_nomUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Contrseña
            // 
            this.lbl_Contrseña.AutoSize = true;
            this.lbl_Contrseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contrseña.Location = new System.Drawing.Point(114, 157);
            this.lbl_Contrseña.Name = "lbl_Contrseña";
            this.lbl_Contrseña.Size = new System.Drawing.Size(101, 20);
            this.lbl_Contrseña.TabIndex = 1;
            this.lbl_Contrseña.Text = "Constraseña";
            this.lbl_Contrseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ConfirmContrseña
            // 
            this.lbl_ConfirmContrseña.AutoSize = true;
            this.lbl_ConfirmContrseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmContrseña.Location = new System.Drawing.Point(38, 198);
            this.lbl_ConfirmContrseña.Name = "lbl_ConfirmContrseña";
            this.lbl_ConfirmContrseña.Size = new System.Drawing.Size(177, 20);
            this.lbl_ConfirmContrseña.TabIndex = 2;
            this.lbl_ConfirmContrseña.Text = "Confirmar Constraseña";
            this.lbl_ConfirmContrseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nomUsuario
            // 
            this.txt_nomUsuario.Location = new System.Drawing.Point(240, 119);
            this.txt_nomUsuario.Name = "txt_nomUsuario";
            this.txt_nomUsuario.Size = new System.Drawing.Size(188, 20);
            this.txt_nomUsuario.TabIndex = 3;
            // 
            // txt_Contrseña
            // 
            this.txt_Contrseña.Location = new System.Drawing.Point(240, 159);
            this.txt_Contrseña.Name = "txt_Contrseña";
            this.txt_Contrseña.PasswordChar = '*';
            this.txt_Contrseña.Size = new System.Drawing.Size(188, 20);
            this.txt_Contrseña.TabIndex = 4;
            // 
            // txt_confirmContraseña
            // 
            this.txt_confirmContraseña.Location = new System.Drawing.Point(240, 200);
            this.txt_confirmContraseña.Name = "txt_confirmContraseña";
            this.txt_confirmContraseña.PasswordChar = '*';
            this.txt_confirmContraseña.Size = new System.Drawing.Size(188, 20);
            this.txt_confirmContraseña.TabIndex = 5;
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.btn_CrearUsuario.FlatAppearance.BorderSize = 0;
            this.btn_CrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CrearUsuario.Location = new System.Drawing.Point(42, 250);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(386, 35);
            this.btn_CrearUsuario.TabIndex = 6;
            this.btn_CrearUsuario.Text = "Crear usuario";
            this.btn_CrearUsuario.UseVisualStyleBackColor = false;
            this.btn_CrearUsuario.Click += new System.EventHandler(this.btn_CrearUsuario_Click);
            // 
            // link_Regresar
            // 
            this.link_Regresar.AutoSize = true;
            this.link_Regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Regresar.Location = new System.Drawing.Point(48, 59);
            this.link_Regresar.Name = "link_Regresar";
            this.link_Regresar.Size = new System.Drawing.Size(92, 21);
            this.link_Regresar.TabIndex = 7;
            this.link_Regresar.TabStop = true;
            this.link_Regresar.Text = "< Regresar";
            this.link_Regresar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.link_Regresar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Regresar_LinkClicked);
            // 
            // pictureBox_RegUsuariosC
            // 
            this.pictureBox_RegUsuariosC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_RegUsuariosC.Image")));
            this.pictureBox_RegUsuariosC.Location = new System.Drawing.Point(398, 36);
            this.pictureBox_RegUsuariosC.Name = "pictureBox_RegUsuariosC";
            this.pictureBox_RegUsuariosC.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_RegUsuariosC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_RegUsuariosC.TabIndex = 8;
            this.pictureBox_RegUsuariosC.TabStop = false;
            this.pictureBox_RegUsuariosC.Click += new System.EventHandler(this.pictureBox_RegUsuariosC_Click);
            // 
            // Form_CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 359);
            this.Controls.Add(this.pictureBox_RegUsuariosC);
            this.Controls.Add(this.link_Regresar);
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.txt_confirmContraseña);
            this.Controls.Add(this.txt_Contrseña);
            this.Controls.Add(this.txt_nomUsuario);
            this.Controls.Add(this.lbl_ConfirmContrseña);
            this.Controls.Add(this.lbl_Contrseña);
            this.Controls.Add(this.lbl_nomUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CrearUsuario";
            this.Text = "Form_CrearUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RegUsuariosC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomUsuario;
        private System.Windows.Forms.Label lbl_Contrseña;
        private System.Windows.Forms.Label lbl_ConfirmContrseña;
        private System.Windows.Forms.TextBox txt_nomUsuario;
        private System.Windows.Forms.TextBox txt_Contrseña;
        private System.Windows.Forms.TextBox txt_confirmContraseña;
        private System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.LinkLabel link_Regresar;
        private System.Windows.Forms.PictureBox pictureBox_RegUsuariosC;
    }
}