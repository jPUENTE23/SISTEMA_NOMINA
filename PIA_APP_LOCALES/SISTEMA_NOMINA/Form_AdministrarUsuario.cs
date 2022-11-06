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
    public partial class Form_AdministrarUsuario : Form
    {
        public Form_AdministrarUsuario()
        {
            InitializeComponent();
            BD.ConexionSQL.Empresa ConnEmpresas = new BD.ConexionSQL.Empresa();
            BD.ConexionSQL.Conexion CloseConn = new BD.ConexionSQL.Conexion();
            SqlDataReader listaEmpresas = ConnEmpresas.ListarEmpresas();

            while (listaEmpresas.Read())
            {
                cb_Empresas.Items.Add(listaEmpresas["Nom_Empresa"].ToString());
            }
            CloseConn.CerrarConexionnBD();
        }

        private void link_Regresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_UsuariosCreados FormUsuarioCreados = new Form_UsuariosCreados();
            FormUsuarioCreados.Show();
        }
    }
}
