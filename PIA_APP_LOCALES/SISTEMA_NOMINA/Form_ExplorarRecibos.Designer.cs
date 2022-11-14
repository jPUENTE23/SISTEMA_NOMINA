namespace SISTEMA_NOMINA
{
    partial class Form_ExplorarRecibos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ExplorarRecibos));
            this.dataGV_ExplorearRec = new System.Windows.Forms.DataGridView();
            this.col_id_ercibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RFC_Empl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NomEmpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FecEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FecPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FecInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FecFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiasPagados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Percepciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Deducciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_OtrosP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RFCEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Explorar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ExplorearRec)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_ExplorearRec
            // 
            this.dataGV_ExplorearRec.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGV_ExplorearRec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGV_ExplorearRec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGV_ExplorearRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_ExplorearRec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV_ExplorearRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_ExplorearRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id_ercibo,
            this.col_RFC_Empl,
            this.col_NomEmpl,
            this.col_FecEmision,
            this.col_FecPago,
            this.col_FecInicial,
            this.col_FecFinal,
            this.col_DiasPagados,
            this.col_Percepciones,
            this.col_Deducciones,
            this.COL_OtrosP,
            this.col_Neto,
            this.col_RFCEmpresa});
            this.dataGV_ExplorearRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_ExplorearRec.Location = new System.Drawing.Point(0, 0);
            this.dataGV_ExplorearRec.Name = "dataGV_ExplorearRec";
            this.dataGV_ExplorearRec.Size = new System.Drawing.Size(1151, 411);
            this.dataGV_ExplorearRec.TabIndex = 0;
            this.dataGV_ExplorearRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_ExplorearRec_CellContentClick);
            // 
            // col_id_ercibo
            // 
            this.col_id_ercibo.HeaderText = "ID RECIBO";
            this.col_id_ercibo.Name = "col_id_ercibo";
            // 
            // col_RFC_Empl
            // 
            this.col_RFC_Empl.HeaderText = "RFC EMPLADO";
            this.col_RFC_Empl.Name = "col_RFC_Empl";
            this.col_RFC_Empl.Width = 150;
            // 
            // col_NomEmpl
            // 
            this.col_NomEmpl.HeaderText = "NOMBRE EMPLEADO";
            this.col_NomEmpl.Name = "col_NomEmpl";
            this.col_NomEmpl.Width = 400;
            // 
            // col_FecEmision
            // 
            this.col_FecEmision.HeaderText = "FECHA EMISION";
            this.col_FecEmision.Name = "col_FecEmision";
            // 
            // col_FecPago
            // 
            this.col_FecPago.HeaderText = "FECHA PAGO";
            this.col_FecPago.Name = "col_FecPago";
            // 
            // col_FecInicial
            // 
            this.col_FecInicial.HeaderText = "FECHA INICIAL PAGO";
            this.col_FecInicial.Name = "col_FecInicial";
            // 
            // col_FecFinal
            // 
            this.col_FecFinal.HeaderText = "FECHA FINAL PAGO";
            this.col_FecFinal.Name = "col_FecFinal";
            // 
            // col_DiasPagados
            // 
            this.col_DiasPagados.HeaderText = "DIAS PAGADOS";
            this.col_DiasPagados.Name = "col_DiasPagados";
            // 
            // col_Percepciones
            // 
            this.col_Percepciones.HeaderText = "PERCEPCIONES";
            this.col_Percepciones.Name = "col_Percepciones";
            // 
            // col_Deducciones
            // 
            this.col_Deducciones.HeaderText = "DEDUCCIONES";
            this.col_Deducciones.Name = "col_Deducciones";
            // 
            // COL_OtrosP
            // 
            this.COL_OtrosP.HeaderText = "OTROS PAGOS";
            this.COL_OtrosP.Name = "COL_OtrosP";
            // 
            // col_Neto
            // 
            this.col_Neto.HeaderText = "NETO";
            this.col_Neto.Name = "col_Neto";
            // 
            // col_RFCEmpresa
            // 
            this.col_RFCEmpresa.HeaderText = "RFC EMPRESA";
            this.col_RFCEmpresa.Name = "col_RFCEmpresa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGV_ExplorearRec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 411);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Explorar
            // 
            this.lbl_Explorar.AutoSize = true;
            this.lbl_Explorar.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Explorar.Location = new System.Drawing.Point(115, 41);
            this.lbl_Explorar.Name = "lbl_Explorar";
            this.lbl_Explorar.Size = new System.Drawing.Size(515, 47);
            this.lbl_Explorar.TabIndex = 3;
            this.lbl_Explorar.Text = "Explorar Recibos Emitidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(119, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "RFC Empleado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(464, 101);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(156, 23);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1095, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form_ExplorarRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1151, 574);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Explorar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ExplorarRecibos";
            this.Text = "Form_ExplorarRecibos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ExplorearRec)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_ExplorearRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_ercibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RFC_Empl;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NomEmpl;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FecEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FecPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FecInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FecFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiasPagados;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Percepciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Deducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_OtrosP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RFCEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Explorar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}