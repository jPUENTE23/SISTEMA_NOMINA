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
    public partial class Form_UsuariosCreados : Form
    {
        public Form_UsuariosCreados()
        {
            InitializeComponent();
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CrearUsuario FormCrearUsuario = new Form_CrearUsuario();
            FormCrearUsuario.Show();
        }

        private void link_regresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Login FormLogin = new Form_Login();
            FormLogin.Show();
        }
    }
}
