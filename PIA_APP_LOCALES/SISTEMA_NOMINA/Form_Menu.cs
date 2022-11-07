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
        private dynamic ConectUser;
        public Form_Menu(dynamic userConect)
        {
            InitializeComponent();
            this.ConectUser = userConect;
        }

        private void btn_Timbra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Timbra FormTimba = new Form_Timbra(this.ConectUser);
            FormTimba.Show();
        }

        private void btn_SalirDeEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SeleccionarEmpr FormSeleccionarEmpr = new Form_SeleccionarEmpr(this.ConectUser);
            FormSeleccionarEmpr.Show();
        }

    }
}
