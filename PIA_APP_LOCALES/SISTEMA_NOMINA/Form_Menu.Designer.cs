namespace SISTEMA_NOMINA
{
    partial class Form_Menu
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
            this.Panael_LeftMenu = new System.Windows.Forms.Panel();
            this.Panel_Logo = new System.Windows.Forms.Panel();
            this.Panel_MenuOpciones = new System.Windows.Forms.Panel();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.btn_Timbra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ExplorarRec = new System.Windows.Forms.Button();
            this.btn_SalirDeEmpresa = new System.Windows.Forms.Button();
            this.Panael_LeftMenu.SuspendLayout();
            this.Panel_MenuOpciones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panael_LeftMenu
            // 
            this.Panael_LeftMenu.Controls.Add(this.panel2);
            this.Panael_LeftMenu.Controls.Add(this.panel1);
            this.Panael_LeftMenu.Controls.Add(this.Panel_MenuOpciones);
            this.Panael_LeftMenu.Controls.Add(this.Panel_Logo);
            this.Panael_LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panael_LeftMenu.Location = new System.Drawing.Point(0, 0);
            this.Panael_LeftMenu.Name = "Panael_LeftMenu";
            this.Panael_LeftMenu.Size = new System.Drawing.Size(200, 582);
            this.Panael_LeftMenu.TabIndex = 0;
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(200, 186);
            this.Panel_Logo.TabIndex = 0;
            // 
            // Panel_MenuOpciones
            // 
            this.Panel_MenuOpciones.Controls.Add(this.btn_ExplorarRec);
            this.Panel_MenuOpciones.Controls.Add(this.btn_Timbra);
            this.Panel_MenuOpciones.Controls.Add(this.btn_Inicio);
            this.Panel_MenuOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_MenuOpciones.Location = new System.Drawing.Point(0, 186);
            this.Panel_MenuOpciones.Name = "Panel_MenuOpciones";
            this.Panel_MenuOpciones.Size = new System.Drawing.Size(200, 177);
            this.Panel_MenuOpciones.TabIndex = 1;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inicio.Location = new System.Drawing.Point(0, 0);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(200, 57);
            this.btn_Inicio.TabIndex = 0;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            // 
            // btn_Timbra
            // 
            this.btn_Timbra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Timbra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timbra.Location = new System.Drawing.Point(0, 57);
            this.btn_Timbra.Name = "btn_Timbra";
            this.btn_Timbra.Size = new System.Drawing.Size(200, 63);
            this.btn_Timbra.TabIndex = 1;
            this.btn_Timbra.Text = "Timbra";
            this.btn_Timbra.UseVisualStyleBackColor = true;
            this.btn_Timbra.Click += new System.EventHandler(this.btn_Timbra_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 160);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_SalirDeEmpresa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 56);
            this.panel2.TabIndex = 3;
            // 
            // btn_ExplorarRec
            // 
            this.btn_ExplorarRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ExplorarRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExplorarRec.Location = new System.Drawing.Point(0, 120);
            this.btn_ExplorarRec.Name = "btn_ExplorarRec";
            this.btn_ExplorarRec.Size = new System.Drawing.Size(200, 63);
            this.btn_ExplorarRec.TabIndex = 2;
            this.btn_ExplorarRec.Text = "Explorar Recibos";
            this.btn_ExplorarRec.UseVisualStyleBackColor = true;
            // 
            // btn_SalirDeEmpresa
            // 
            this.btn_SalirDeEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SalirDeEmpresa.Location = new System.Drawing.Point(0, 0);
            this.btn_SalirDeEmpresa.Name = "btn_SalirDeEmpresa";
            this.btn_SalirDeEmpresa.Size = new System.Drawing.Size(200, 56);
            this.btn_SalirDeEmpresa.TabIndex = 0;
            this.btn_SalirDeEmpresa.Text = "Salir de la Empresa";
            this.btn_SalirDeEmpresa.UseVisualStyleBackColor = true;
            this.btn_SalirDeEmpresa.Click += new System.EventHandler(this.btn_SalirDeEmpresa_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 582);
            this.Controls.Add(this.Panael_LeftMenu);
            this.Name = "Form_Menu";
            this.Text = "Form_Menu";
            this.Panael_LeftMenu.ResumeLayout(false);
            this.Panel_MenuOpciones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panael_LeftMenu;
        private System.Windows.Forms.Panel Panel_MenuOpciones;
        private System.Windows.Forms.Button btn_Timbra;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Panel Panel_Logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SalirDeEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ExplorarRec;
    }
}