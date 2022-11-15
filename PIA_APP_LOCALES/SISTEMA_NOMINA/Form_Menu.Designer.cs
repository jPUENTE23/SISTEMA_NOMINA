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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panael_LeftMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SalirDeEmpresa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_MenuOpciones = new System.Windows.Forms.Panel();
            this.btn_ExplorarRec = new System.Windows.Forms.Button();
            this.btn_Timbra = new System.Windows.Forms.Button();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.Panel_Logo = new System.Windows.Forms.Panel();
            this.lbl_NomEmpresa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.dataGV_RecibosMenu = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RFCEmpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NomEmpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FecEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Panael_LeftMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Panel_MenuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_RecibosMenu)).BeginInit();
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
            this.Panael_LeftMenu.Size = new System.Drawing.Size(200, 549);
            this.Panael_LeftMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_SalirDeEmpresa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 56);
            this.panel2.TabIndex = 3;
            // 
            // btn_SalirDeEmpresa
            // 
            this.btn_SalirDeEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(126)))), ((int)(((byte)(228)))));
            this.btn_SalirDeEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SalirDeEmpresa.FlatAppearance.BorderSize = 0;
            this.btn_SalirDeEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirDeEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirDeEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SalirDeEmpresa.Location = new System.Drawing.Point(0, 0);
            this.btn_SalirDeEmpresa.Name = "btn_SalirDeEmpresa";
            this.btn_SalirDeEmpresa.Size = new System.Drawing.Size(200, 56);
            this.btn_SalirDeEmpresa.TabIndex = 0;
            this.btn_SalirDeEmpresa.Text = "Salir de la Empresa";
            this.btn_SalirDeEmpresa.UseVisualStyleBackColor = false;
            this.btn_SalirDeEmpresa.Click += new System.EventHandler(this.btn_SalirDeEmpresa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 163);
            this.panel1.TabIndex = 2;
            // 
            // Panel_MenuOpciones
            // 
            this.Panel_MenuOpciones.Controls.Add(this.btn_ExplorarRec);
            this.Panel_MenuOpciones.Controls.Add(this.btn_Timbra);
            this.Panel_MenuOpciones.Controls.Add(this.btn_Inicio);
            this.Panel_MenuOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_MenuOpciones.Location = new System.Drawing.Point(0, 158);
            this.Panel_MenuOpciones.Name = "Panel_MenuOpciones";
            this.Panel_MenuOpciones.Size = new System.Drawing.Size(200, 177);
            this.Panel_MenuOpciones.TabIndex = 1;
            // 
            // btn_ExplorarRec
            // 
            this.btn_ExplorarRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.btn_ExplorarRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ExplorarRec.FlatAppearance.BorderSize = 0;
            this.btn_ExplorarRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExplorarRec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExplorarRec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ExplorarRec.Location = new System.Drawing.Point(0, 120);
            this.btn_ExplorarRec.Name = "btn_ExplorarRec";
            this.btn_ExplorarRec.Size = new System.Drawing.Size(200, 63);
            this.btn_ExplorarRec.TabIndex = 2;
            this.btn_ExplorarRec.Text = "Explorar Recibos";
            this.btn_ExplorarRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExplorarRec.UseVisualStyleBackColor = false;
            this.btn_ExplorarRec.Click += new System.EventHandler(this.btn_ExplorarRec_Click);
            // 
            // btn_Timbra
            // 
            this.btn_Timbra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.btn_Timbra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Timbra.FlatAppearance.BorderSize = 0;
            this.btn_Timbra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timbra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timbra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Timbra.Location = new System.Drawing.Point(0, 57);
            this.btn_Timbra.Name = "btn_Timbra";
            this.btn_Timbra.Size = new System.Drawing.Size(200, 63);
            this.btn_Timbra.TabIndex = 1;
            this.btn_Timbra.Text = "Timbra";
            this.btn_Timbra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Timbra.UseVisualStyleBackColor = false;
            this.btn_Timbra.Click += new System.EventHandler(this.btn_Timbra_Click);
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.btn_Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inicio.FlatAppearance.BorderSize = 0;
            this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Inicio.Location = new System.Drawing.Point(0, 0);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(200, 57);
            this.btn_Inicio.TabIndex = 0;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inicio.UseVisualStyleBackColor = false;
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(200, 158);
            this.Panel_Logo.TabIndex = 0;
            // 
            // lbl_NomEmpresa
            // 
            this.lbl_NomEmpresa.AutoSize = true;
            this.lbl_NomEmpresa.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomEmpresa.Location = new System.Drawing.Point(232, 70);
            this.lbl_NomEmpresa.Name = "lbl_NomEmpresa";
            this.lbl_NomEmpresa.Size = new System.Drawing.Size(339, 32);
            this.lbl_NomEmpresa.TabIndex = 3;
            this.lbl_NomEmpresa.Text = "(Nombre de la empresa)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_User.Location = new System.Drawing.Point(264, 38);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(176, 21);
            this.lbl_User.TabIndex = 6;
            this.lbl_User.Text = "(Nombre dell Usuario)";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGV_RecibosMenu
            // 
            this.dataGV_RecibosMenu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGV_RecibosMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGV_RecibosMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_RecibosMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV_RecibosMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_RecibosMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_RFCEmpl,
            this.col_NomEmpl,
            this.col_FecEmision});
            this.dataGV_RecibosMenu.GridColor = System.Drawing.SystemColors.Window;
            this.dataGV_RecibosMenu.Location = new System.Drawing.Point(238, 215);
            this.dataGV_RecibosMenu.Name = "dataGV_RecibosMenu";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_RecibosMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV_RecibosMenu.Size = new System.Drawing.Size(690, 306);
            this.dataGV_RecibosMenu.TabIndex = 7;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_RFCEmpl
            // 
            this.col_RFCEmpl.HeaderText = "RFC ";
            this.col_RFCEmpl.Name = "col_RFCEmpl";
            this.col_RFCEmpl.Width = 150;
            // 
            // col_NomEmpl
            // 
            this.col_NomEmpl.HeaderText = "NOMBRE DEL EMPLEADO";
            this.col_NomEmpl.Name = "col_NomEmpl";
            this.col_NomEmpl.Width = 200;
            // 
            // col_FecEmision
            // 
            this.col_FecEmision.HeaderText = "FECHA EMISION";
            this.col_FecEmision.Name = "col_FecEmision";
            this.col_FecEmision.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(232, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ultimos Recibos Emitidos";
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGV_RecibosMenu);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_NomEmpresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Panael_LeftMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Menu";
            this.Text = "Form_Menu";
            this.Panael_LeftMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Panel_MenuOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_RecibosMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        public System.Windows.Forms.Label lbl_NomEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.DataGridView dataGV_RecibosMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RFCEmpl;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NomEmpl;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FecEmision;
        public System.Windows.Forms.Label label1;
    }
}