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
    public partial class Form_SeleccionarEmpr : Form
    {
        public Form_SeleccionarEmpr()
        {
            InitializeComponent();
        }

        private void link_CambiarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Login FormLogin = new Form_Login();
            FormLogin.Show();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menu FormMenu = new Form_Menu();
            FormMenu.Show();
        }
    }
}
