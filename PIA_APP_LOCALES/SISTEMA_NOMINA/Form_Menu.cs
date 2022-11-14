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
        private dynamic ConectEmpresa;
        public Form_Menu(dynamic userConect, dynamic Empresa)
        {
            InitializeComponent();
            this.ConectUser = userConect;
            this.ConectEmpresa = Empresa;
        }

        private void btn_Timbra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Timbra FormTimba = new Form_Timbra(this.ConectUser, this.ConectEmpresa);
            Form_SeleccionarEmpr FormSelectEmpre = new Form_SeleccionarEmpr(this.ConectUser);
            FormSelectEmpre.lbl_usuarioSleccionado.Text = this.ConectUser;
            FormTimba.Show();
        }

        private void btn_SalirDeEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SeleccionarEmpr FormSeleccionarEmpr = new Form_SeleccionarEmpr(this.ConectUser);
            FormSeleccionarEmpr.lbl_usuarioSleccionado.Text = this.ConectUser;
            FormSeleccionarEmpr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExplorarRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ExplorarRecibos FormExplorarRecibos = new Form_ExplorarRecibos(this.ConectUser, this.ConectEmpresa);
            FormExplorarRecibos.Show();
        }
    }
}
