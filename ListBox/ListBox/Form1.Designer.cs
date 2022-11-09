namespace ListBox
{
    partial class Form1
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
            this.lbl_opciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_opciones
            // 
            this.lbl_opciones.FormattingEnabled = true;
            this.lbl_opciones.Items.AddRange(new object[] {
            "Opcion1",
            "Opcion2",
            "Opcion3"});
            this.lbl_opciones.Location = new System.Drawing.Point(283, 74);
            this.lbl_opciones.Name = "lbl_opciones";
            this.lbl_opciones.Size = new System.Drawing.Size(120, 95);
            this.lbl_opciones.TabIndex = 0;
            this.lbl_opciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbl_opciones_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_opciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbl_opciones;
    }
}

