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
    public partial class Form_EmpresasCreadas : Form
    {
        public Form_EmpresasCreadas()
        {
            InitializeComponent();
        }

        private void btn_NuevaEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CrearEmpresa FormCrearEmpresa = new Form_CrearEmpresa();
            FormCrearEmpresa.Show();
        }
    }
}
