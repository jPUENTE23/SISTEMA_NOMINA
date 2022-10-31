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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void btn_Timbra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Timbra FormTimba = new Form_Timbra();
            FormTimba.Show();
        }

        private void btn_SalirDeEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SeleccionarEmpr FormSeleccionarEmpr = new Form_SeleccionarEmpr();
            FormSeleccionarEmpr.Show();
        }
    }
}
