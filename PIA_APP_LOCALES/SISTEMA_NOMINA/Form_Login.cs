using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SISTEMA_NOMINA
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SeleccionarEmpr FormSeleccionarEmpr = new Form_SeleccionarEmpr();
            FormSeleccionarEmpr.Show();

        }

        private void btn_conexion_Click(object sender, EventArgs e)
        {
            BD.ConexionSQL.Conexion myConn = new BD.ConexionSQL.Conexion();
            myConn.AbrirConexioBD();
            
        }

        private void btn_CrearEmpr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EmpresasCreadas FormEmpresasCraedas = new Form_EmpresasCreadas();
            FormEmpresasCraedas.Show();
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_UsuariosCreados FormUsuarioCreados = new Form_UsuariosCreados();
            FormUsuarioCreados.Show();
        }
    }
}
