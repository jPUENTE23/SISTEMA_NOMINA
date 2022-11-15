namespace SISTEMA_NOMINA
{
    partial class Form_CrearEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CrearEmpresa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RFCEmpr = new System.Windows.Forms.TextBox();
            this.txt_NomEmpresa = new System.Windows.Forms.TextBox();
            this.btn_GenerarEmpr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la Empresa";
            // 
            // txt_RFCEmpr
            // 
            this.txt_RFCEmpr.Location = new System.Drawing.Point(63, 60);
            this.txt_RFCEmpr.Name = "txt_RFCEmpr";
            this.txt_RFCEmpr.Size = new System.Drawing.Size(254, 20);
            this.txt_RFCEmpr.TabIndex = 2;
            // 
            // txt_NomEmpresa
            // 
            this.txt_NomEmpresa.Location = new System.Drawing.Point(63, 124);
            this.txt_NomEmpresa.Name = "txt_NomEmpresa";
            this.txt_NomEmpresa.Size = new System.Drawing.Size(254, 20);
            this.txt_NomEmpresa.TabIndex = 3;
            // 
            // btn_GenerarEmpr
            // 
            this.btn_GenerarEmpr.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerarEmpr.Location = new System.Drawing.Point(63, 168);
            this.btn_GenerarEmpr.Name = "btn_GenerarEmpr";
            this.btn_GenerarEmpr.Size = new System.Drawing.Size(254, 23);
            this.btn_GenerarEmpr.TabIndex = 4;
            this.btn_GenerarEmpr.Text = "Crear Empresa";
            this.btn_GenerarEmpr.UseVisualStyleBackColor = true;
            this.btn_GenerarEmpr.Click += new System.EventHandler(this.btn_GenerarEmpr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_CrearEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_GenerarEmpr);
            this.Controls.Add(this.txt_NomEmpresa);
            this.Controls.Add(this.txt_RFCEmpr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CrearEmpresa";
            this.Text = "Form_CrearEmpresa";
            this.Click += new System.EventHandler(this.Form_CrearEmpresa_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RFCEmpr;
        private System.Windows.Forms.TextBox txt_NomEmpresa;
        private System.Windows.Forms.Button btn_GenerarEmpr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}