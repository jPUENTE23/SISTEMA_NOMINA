using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_NOMINA
{
    public partial class Salir : Form
    {
        public Salir()
        {
            InitializeComponent();
        }

        private void btn_Si_Click(object sender, EventArgs e)
        {
            Application.Exit();        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
