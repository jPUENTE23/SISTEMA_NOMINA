﻿namespace SISTEMA_NOMINA
{
    partial class Form_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_conexion = new System.Windows.Forms.Button();
            this.btn_CrearEmpr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(57, 33);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(60, 73);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(240, 20);
            this.txt_Usuario.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.AutoSize = true;
            this.txt_Contraseña.Location = new System.Drawing.Point(57, 123);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.txt_Contraseña.TabIndex = 2;
            this.txt_Contraseña.Text = "Contraseña";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(60, 216);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(240, 36);
            this.btn_Ingresar.TabIndex = 4;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_conexion
            // 
            this.btn_conexion.Location = new System.Drawing.Point(60, 412);
            this.btn_conexion.Name = "btn_conexion";
            this.btn_conexion.Size = new System.Drawing.Size(240, 36);
            this.btn_conexion.TabIndex = 5;
            this.btn_conexion.Text = "Conectar";
            this.btn_conexion.UseVisualStyleBackColor = true;
            this.btn_conexion.Click += new System.EventHandler(this.btn_conexion_Click);
            // 
            // btn_CrearEmpr
            // 
            this.btn_CrearEmpr.Location = new System.Drawing.Point(60, 258);
            this.btn_CrearEmpr.Name = "btn_CrearEmpr";
            this.btn_CrearEmpr.Size = new System.Drawing.Size(240, 36);
            this.btn_CrearEmpr.TabIndex = 6;
            this.btn_CrearEmpr.Text = "Craear una nueva empresa";
            this.btn_CrearEmpr.UseVisualStyleBackColor = true;
            this.btn_CrearEmpr.Click += new System.EventHandler(this.btn_CrearEmpr_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 540);
            this.Controls.Add(this.btn_CrearEmpr);
            this.Controls.Add(this.btn_conexion);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "Form_Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txt_Contraseña;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_conexion;
        private System.Windows.Forms.Button btn_CrearEmpr;
    }
}

