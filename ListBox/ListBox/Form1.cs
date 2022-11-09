using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_opciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbl_opciones.SelectedItem != null)
            {
                string opcion = lbl_opciones.SelectedItem.ToString();

                Form2 form2 = new Form2();
                form2.lbl_form2.Text = opcion;

                form2.Show();
            }
        }
    }
}
