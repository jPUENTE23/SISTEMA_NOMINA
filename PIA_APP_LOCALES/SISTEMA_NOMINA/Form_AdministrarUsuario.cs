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
            BD.ConexionSQL.Usuarios ConnUsuarios = new BD.ConexionSQL.Usuarios();
            BD.ConexionSQL.Conexion CloseConn = new BD.ConexionSQL.Conexion();
            SqlDataReader listaEmpresas = ConnEmpresas.ListarEmpresas();
            SqlDataReader listaUsuarios = ConnUsuarios.ListarUsuarios();


            /* Listado de empresas */
            while (listaEmpresas.Read())
            {
                cb_Empresas.Items.Add(listaEmpresas["Nom_Empresa"].ToString());
            }


            /* Listado de usuarios */
            while (listaUsuarios.Read())
            {
                cb_Usuarios.Items.Add(listaUsuarios["Nom_Usuario"].ToString());
            }


            CloseConn.CerrarConexionnBD();



            //Form_UsuariosCreados UsuarioSelect = new Form_UsuariosCreados();
            //dynamic UserSelect = UsuarioSelect.UsuarioSlecionado();

            //lbl_UsuarioSeleccionado.Text = UserSelect;
        }

        private void link_Regresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_UsuariosCreados FormUsuarioCreados = new Form_UsuariosCreados();
            FormUsuarioCreados.Show();
        }

        private void btn_AgrEmpresa_Click(object sender, EventArgs e)
        {
            BD.ConexionSQL.Empresa ConnEmpresas = new BD.ConexionSQL.Empresa();
            BD.ConexionSQL.Usuarios ConnUsuarios = new BD.ConexionSQL.Usuarios();

            int indexUsuario = cb_Usuarios.SelectedIndex;
            int indexEmpresa = cb_Empresas.SelectedIndex;

            string nomUsuario = cb_Usuarios.Items[indexUsuario].ToString();
            string nomEmpresa = cb_Empresas.Items[indexEmpresa].ToString();

            SqlDataReader getIdUsuario = ConnUsuarios.ID_USUARIO(nomUsuario);
            SqlDataReader getIdEmpresa = ConnEmpresas.ID_Empresa(nomEmpresa);

            MessageBox.Show("Usuario: " + getIdUsuario["ID_Usuario"].ToString() + "Empresa: " + getIdEmpresa["ID_Empresa"].ToString());
        }
    }
}
