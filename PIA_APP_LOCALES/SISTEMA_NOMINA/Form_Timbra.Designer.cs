namespace SISTEMA_NOMINA
{
    partial class Form_Timbra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.Panel_DatosEmpl = new System.Windows.Forms.Panel();
            this.lbl_DatosEmpl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_NomEmpleado = new System.Windows.Forms.TextBox();
            this.lbl_RazonSocial = new System.Windows.Forms.Label();
            this.txt_RFC_Empleado = new System.Windows.Forms.TextBox();
            this.lbl_RFC = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Nomina = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_DiasPagados = new System.Windows.Forms.TextBox();
            this.lbl_DiasPag = new System.Windows.Forms.Label();
            this.dt_FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaFinal = new System.Windows.Forms.Label();
            this.dt_FechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaInicial = new System.Windows.Forms.Label();
            this.dt_FechaPag = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaPag = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cb_Percepciones = new System.Windows.Forms.ComboBox();
            this.dataGV_Percepciones = new System.Windows.Forms.DataGridView();
            this.col_Percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ClavePer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DescripcionPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ImportePer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AgregarPer = new System.Windows.Forms.Button();
            this.txt_ImportePer = new System.Windows.Forms.TextBox();
            this.txt_DescPer = new System.Windows.Forms.TextBox();
            this.txt_ClavePer = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.lbl_motno = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGV_Deducciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Deducciones = new System.Windows.Forms.ComboBox();
            this.btn_AgregarDed = new System.Windows.Forms.Button();
            this.txt_ClaveDed = new System.Windows.Forms.TextBox();
            this.txt_importeDed = new System.Windows.Forms.TextBox();
            this.txt_DescDed = new System.Windows.Forms.TextBox();
            this.lb_Montos = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.Panel_DatosEmpl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Percepciones)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Deducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Regresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 67);
            this.panel1.TabIndex = 0;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(30, 21);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(174, 23);
            this.btn_Regresar.TabIndex = 0;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // Panel_DatosEmpl
            // 
            this.Panel_DatosEmpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.Panel_DatosEmpl.Controls.Add(this.lbl_DatosEmpl);
            this.Panel_DatosEmpl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_DatosEmpl.Location = new System.Drawing.Point(0, 67);
            this.Panel_DatosEmpl.Name = "Panel_DatosEmpl";
            this.Panel_DatosEmpl.Size = new System.Drawing.Size(1082, 45);
            this.Panel_DatosEmpl.TabIndex = 1;
            // 
            // lbl_DatosEmpl
            // 
            this.lbl_DatosEmpl.AutoSize = true;
            this.lbl_DatosEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DatosEmpl.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_DatosEmpl.Location = new System.Drawing.Point(41, 17);
            this.lbl_DatosEmpl.Name = "lbl_DatosEmpl";
            this.lbl_DatosEmpl.Size = new System.Drawing.Size(186, 20);
            this.lbl_DatosEmpl.TabIndex = 0;
            this.lbl_DatosEmpl.Text = "Datos de el Empleado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txt_NomEmpleado);
            this.panel2.Controls.Add(this.lbl_RazonSocial);
            this.panel2.Controls.Add(this.txt_RFC_Empleado);
            this.panel2.Controls.Add(this.lbl_RFC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 33);
            this.panel2.TabIndex = 2;
            // 
            // txt_NomEmpleado
            // 
            this.txt_NomEmpleado.Location = new System.Drawing.Point(370, 6);
            this.txt_NomEmpleado.Name = "txt_NomEmpleado";
            this.txt_NomEmpleado.Size = new System.Drawing.Size(167, 20);
            this.txt_NomEmpleado.TabIndex = 3;
            // 
            // lbl_RazonSocial
            // 
            this.lbl_RazonSocial.AutoSize = true;
            this.lbl_RazonSocial.Location = new System.Drawing.Point(285, 9);
            this.lbl_RazonSocial.Name = "lbl_RazonSocial";
            this.lbl_RazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lbl_RazonSocial.TabIndex = 2;
            this.lbl_RazonSocial.Text = "Razon Social";
            // 
            // txt_RFC_Empleado
            // 
            this.txt_RFC_Empleado.Location = new System.Drawing.Point(87, 6);
            this.txt_RFC_Empleado.Name = "txt_RFC_Empleado";
            this.txt_RFC_Empleado.Size = new System.Drawing.Size(167, 20);
            this.txt_RFC_Empleado.TabIndex = 1;
            // 
            // lbl_RFC
            // 
            this.lbl_RFC.AutoSize = true;
            this.lbl_RFC.Location = new System.Drawing.Point(44, 9);
            this.lbl_RFC.Name = "lbl_RFC";
            this.lbl_RFC.Size = new System.Drawing.Size(28, 13);
            this.lbl_RFC.TabIndex = 0;
            this.lbl_RFC.Text = "RFC";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.lbl_Nomina);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 54);
            this.panel3.TabIndex = 3;
            // 
            // lbl_Nomina
            // 
            this.lbl_Nomina.AutoSize = true;
            this.lbl_Nomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nomina.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Nomina.Location = new System.Drawing.Point(44, 23);
            this.lbl_Nomina.Name = "lbl_Nomina";
            this.lbl_Nomina.Size = new System.Drawing.Size(59, 20);
            this.lbl_Nomina.TabIndex = 0;
            this.lbl_Nomina.Text = "Nomia";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.txt_DiasPagados);
            this.panel4.Controls.Add(this.lbl_DiasPag);
            this.panel4.Controls.Add(this.dt_FechaFinal);
            this.panel4.Controls.Add(this.lbl_FechaFinal);
            this.panel4.Controls.Add(this.dt_FechaInicial);
            this.panel4.Controls.Add(this.lbl_FechaInicial);
            this.panel4.Controls.Add(this.dt_FechaPag);
            this.panel4.Controls.Add(this.lbl_FechaPag);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 56);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txt_DiasPagados
            // 
            this.txt_DiasPagados.Location = new System.Drawing.Point(850, 17);
            this.txt_DiasPagados.Name = "txt_DiasPagados";
            this.txt_DiasPagados.Size = new System.Drawing.Size(200, 20);
            this.txt_DiasPagados.TabIndex = 7;
            // 
            // lbl_DiasPag
            // 
            this.lbl_DiasPag.AutoSize = true;
            this.lbl_DiasPag.Location = new System.Drawing.Point(763, 24);
            this.lbl_DiasPag.Name = "lbl_DiasPag";
            this.lbl_DiasPag.Size = new System.Drawing.Size(73, 13);
            this.lbl_DiasPag.TabIndex = 6;
            this.lbl_DiasPag.Text = "Dias Pagados";
            // 
            // dt_FechaFinal
            // 
            this.dt_FechaFinal.Location = new System.Drawing.Point(598, 17);
            this.dt_FechaFinal.Name = "dt_FechaFinal";
            this.dt_FechaFinal.Size = new System.Drawing.Size(121, 20);
            this.dt_FechaFinal.TabIndex = 5;
            // 
            // lbl_FechaFinal
            // 
            this.lbl_FechaFinal.AutoSize = true;
            this.lbl_FechaFinal.Location = new System.Drawing.Point(518, 23);
            this.lbl_FechaFinal.Name = "lbl_FechaFinal";
            this.lbl_FechaFinal.Size = new System.Drawing.Size(62, 13);
            this.lbl_FechaFinal.TabIndex = 4;
            this.lbl_FechaFinal.Text = "Fecha Final";
            // 
            // dt_FechaInicial
            // 
            this.dt_FechaInicial.Location = new System.Drawing.Point(359, 16);
            this.dt_FechaInicial.Name = "dt_FechaInicial";
            this.dt_FechaInicial.Size = new System.Drawing.Size(125, 20);
            this.dt_FechaInicial.TabIndex = 3;
            // 
            // lbl_FechaInicial
            // 
            this.lbl_FechaInicial.AutoSize = true;
            this.lbl_FechaInicial.Location = new System.Drawing.Point(279, 22);
            this.lbl_FechaInicial.Name = "lbl_FechaInicial";
            this.lbl_FechaInicial.Size = new System.Drawing.Size(67, 13);
            this.lbl_FechaInicial.TabIndex = 2;
            this.lbl_FechaInicial.Text = "Fecha Inicial";
            // 
            // dt_FechaPag
            // 
            this.dt_FechaPag.Location = new System.Drawing.Point(132, 15);
            this.dt_FechaPag.Name = "dt_FechaPag";
            this.dt_FechaPag.Size = new System.Drawing.Size(123, 20);
            this.dt_FechaPag.TabIndex = 1;
            // 
            // lbl_FechaPag
            // 
            this.lbl_FechaPag.AutoSize = true;
            this.lbl_FechaPag.Location = new System.Drawing.Point(45, 22);
            this.lbl_FechaPag.Name = "lbl_FechaPag";
            this.lbl_FechaPag.Size = new System.Drawing.Size(65, 13);
            this.lbl_FechaPag.TabIndex = 0;
            this.lbl_FechaPag.Text = "Fecha Pago";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 255);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1082, 47);
            this.panel5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(782, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Importe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(366, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(239, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(44, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Percepcion";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.cb_Percepciones);
            this.panel6.Controls.Add(this.dataGV_Percepciones);
            this.panel6.Controls.Add(this.btn_AgregarPer);
            this.panel6.Controls.Add(this.txt_ImportePer);
            this.panel6.Controls.Add(this.txt_DescPer);
            this.panel6.Controls.Add(this.txt_ClavePer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 302);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1082, 143);
            this.panel6.TabIndex = 6;
            // 
            // cb_Percepciones
            // 
            this.cb_Percepciones.FormattingEnabled = true;
            this.cb_Percepciones.Items.AddRange(new object[] {
            "Sueldos y salarios",
            "Glatificacion Anual",
            "Fondo de Ahorro",
            "Caja de Ahorro"});
            this.cb_Percepciones.Location = new System.Drawing.Point(47, 8);
            this.cb_Percepciones.Name = "cb_Percepciones";
            this.cb_Percepciones.Size = new System.Drawing.Size(171, 21);
            this.cb_Percepciones.TabIndex = 6;
            // 
            // dataGV_Percepciones
            // 
            this.dataGV_Percepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Percepciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Percepcion,
            this.col_ClavePer,
            this.col_DescripcionPer,
            this.col_ImportePer});
            this.dataGV_Percepciones.Location = new System.Drawing.Point(47, 46);
            this.dataGV_Percepciones.Name = "dataGV_Percepciones";
            this.dataGV_Percepciones.Size = new System.Drawing.Size(994, 75);
            this.dataGV_Percepciones.TabIndex = 5;
            // 
            // col_Percepcion
            // 
            this.col_Percepcion.HeaderText = "Percepcion";
            this.col_Percepcion.Name = "col_Percepcion";
            // 
            // col_ClavePer
            // 
            this.col_ClavePer.HeaderText = "Clave";
            this.col_ClavePer.Name = "col_ClavePer";
            // 
            // col_DescripcionPer
            // 
            this.col_DescripcionPer.HeaderText = "Descripcion";
            this.col_DescripcionPer.Name = "col_DescripcionPer";
            // 
            // col_ImportePer
            // 
            this.col_ImportePer.HeaderText = "Importe";
            this.col_ImportePer.Name = "col_ImportePer";
            // 
            // btn_AgregarPer
            // 
            this.btn_AgregarPer.Location = new System.Drawing.Point(948, 4);
            this.btn_AgregarPer.Name = "btn_AgregarPer";
            this.btn_AgregarPer.Size = new System.Drawing.Size(93, 23);
            this.btn_AgregarPer.TabIndex = 4;
            this.btn_AgregarPer.Text = "Agregar";
            this.btn_AgregarPer.UseVisualStyleBackColor = true;
            this.btn_AgregarPer.Click += new System.EventHandler(this.btn_AgregarPer_Click);
            // 
            // txt_ImportePer
            // 
            this.txt_ImportePer.Location = new System.Drawing.Point(786, 8);
            this.txt_ImportePer.Name = "txt_ImportePer";
            this.txt_ImportePer.Size = new System.Drawing.Size(120, 20);
            this.txt_ImportePer.TabIndex = 3;
            // 
            // txt_DescPer
            // 
            this.txt_DescPer.Location = new System.Drawing.Point(370, 8);
            this.txt_DescPer.Name = "txt_DescPer";
            this.txt_DescPer.Size = new System.Drawing.Size(378, 20);
            this.txt_DescPer.TabIndex = 2;
            // 
            // txt_ClavePer
            // 
            this.txt_ClavePer.Location = new System.Drawing.Point(243, 8);
            this.txt_ClavePer.Name = "txt_ClavePer";
            this.txt_ClavePer.Size = new System.Drawing.Size(105, 20);
            this.txt_ClavePer.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 445);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1082, 48);
            this.panel7.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(785, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Importe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(242, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(369, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(44, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Deduccion";
            // 
            // btn_agregar
            // 
            this.btn_agregar.AllowDrop = true;
            this.btn_agregar.Location = new System.Drawing.Point(644, 661);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.Location = new System.Drawing.Point(376, 671);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(35, 13);
            this.lbl_concepto.TabIndex = 9;
            this.lbl_concepto.Text = "label9";
            // 
            // lbl_motno
            // 
            this.lbl_motno.AutoSize = true;
            this.lbl_motno.Location = new System.Drawing.Point(458, 671);
            this.lbl_motno.Name = "lbl_motno";
            this.lbl_motno.Size = new System.Drawing.Size(41, 13);
            this.lbl_motno.TabIndex = 13;
            this.lbl_motno.Text = "label12";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Controls.Add(this.dataGV_Deducciones);
            this.panel8.Controls.Add(this.cb_Deducciones);
            this.panel8.Controls.Add(this.btn_AgregarDed);
            this.panel8.Controls.Add(this.txt_ClaveDed);
            this.panel8.Controls.Add(this.txt_importeDed);
            this.panel8.Controls.Add(this.txt_DescDed);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 493);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1082, 152);
            this.panel8.TabIndex = 14;
            // 
            // dataGV_Deducciones
            // 
            this.dataGV_Deducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Deducciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGV_Deducciones.Location = new System.Drawing.Point(48, 49);
            this.dataGV_Deducciones.Name = "dataGV_Deducciones";
            this.dataGV_Deducciones.Size = new System.Drawing.Size(992, 75);
            this.dataGV_Deducciones.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Percepcion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // cb_Deducciones
            // 
            this.cb_Deducciones.FormattingEnabled = true;
            this.cb_Deducciones.Items.AddRange(new object[] {
            "ISR",
            "Faltas"});
            this.cb_Deducciones.Location = new System.Drawing.Point(48, 6);
            this.cb_Deducciones.Name = "cb_Deducciones";
            this.cb_Deducciones.Size = new System.Drawing.Size(171, 21);
            this.cb_Deducciones.TabIndex = 17;
            // 
            // btn_AgregarDed
            // 
            this.btn_AgregarDed.Location = new System.Drawing.Point(947, 4);
            this.btn_AgregarDed.Name = "btn_AgregarDed";
            this.btn_AgregarDed.Size = new System.Drawing.Size(93, 23);
            this.btn_AgregarDed.TabIndex = 16;
            this.btn_AgregarDed.Text = "Agregar";
            this.btn_AgregarDed.UseVisualStyleBackColor = true;
            this.btn_AgregarDed.Click += new System.EventHandler(this.btn_AgregarDed_Click);
            // 
            // txt_ClaveDed
            // 
            this.txt_ClaveDed.Location = new System.Drawing.Point(243, 7);
            this.txt_ClaveDed.Name = "txt_ClaveDed";
            this.txt_ClaveDed.Size = new System.Drawing.Size(105, 20);
            this.txt_ClaveDed.TabIndex = 13;
            // 
            // txt_importeDed
            // 
            this.txt_importeDed.Location = new System.Drawing.Point(788, 6);
            this.txt_importeDed.Name = "txt_importeDed";
            this.txt_importeDed.Size = new System.Drawing.Size(120, 20);
            this.txt_importeDed.TabIndex = 15;
            // 
            // txt_DescDed
            // 
            this.txt_DescDed.Location = new System.Drawing.Point(370, 6);
            this.txt_DescDed.Name = "txt_DescDed";
            this.txt_DescDed.Size = new System.Drawing.Size(378, 20);
            this.txt_DescDed.TabIndex = 14;
            // 
            // lb_Montos
            // 
            this.lb_Montos.FormattingEnabled = true;
            this.lb_Montos.Location = new System.Drawing.Point(159, 680);
            this.lb_Montos.Name = "lb_Montos";
            this.lb_Montos.Size = new System.Drawing.Size(120, 95);
            this.lb_Montos.TabIndex = 15;
            // 
            // Form_Timbra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1099, 693);
            this.Controls.Add(this.lb_Montos);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lbl_motno);
            this.Controls.Add(this.lbl_concepto);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_DatosEmpl);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Timbra";
            this.Text = "Form_Timbra";
            this.panel1.ResumeLayout(false);
            this.Panel_DatosEmpl.ResumeLayout(false);
            this.Panel_DatosEmpl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Percepciones)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Deducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_DatosEmpl;
        private System.Windows.Forms.Label lbl_DatosEmpl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_NomEmpleado;
        private System.Windows.Forms.Label lbl_RazonSocial;
        private System.Windows.Forms.TextBox txt_RFC_Empleado;
        private System.Windows.Forms.Label lbl_RFC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Nomina;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dt_FechaInicial;
        private System.Windows.Forms.Label lbl_FechaInicial;
        private System.Windows.Forms.DateTimePicker dt_FechaPag;
        private System.Windows.Forms.Label lbl_FechaPag;
        private System.Windows.Forms.Label lbl_DiasPag;
        private System.Windows.Forms.DateTimePicker dt_FechaFinal;
        private System.Windows.Forms.Label lbl_FechaFinal;
        private System.Windows.Forms.TextBox txt_DiasPagados;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGV_Percepciones;
        private System.Windows.Forms.Button btn_AgregarPer;
        private System.Windows.Forms.TextBox txt_ImportePer;
        private System.Windows.Forms.TextBox txt_DescPer;
        private System.Windows.Forms.TextBox txt_ClavePer;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ClavePer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DescripcionPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ImportePer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Percepciones;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.Label lbl_motno;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cb_Deducciones;
        private System.Windows.Forms.Button btn_AgregarDed;
        private System.Windows.Forms.TextBox txt_ClaveDed;
        private System.Windows.Forms.TextBox txt_importeDed;
        private System.Windows.Forms.TextBox txt_DescDed;
        private System.Windows.Forms.DataGridView dataGV_Deducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ListBox lb_Montos;
    }
}