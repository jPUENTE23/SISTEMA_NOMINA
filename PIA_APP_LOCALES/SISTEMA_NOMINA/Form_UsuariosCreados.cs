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
    public partial class Form_UsuariosCreados : Form
    {
        public Form_UsuariosCreados()
        {
            InitializeComponent();

            BD.ConexionSQL.Usuarios UsuarioConn = new BD.ConexionSQL.Usuarios();
            BD.ConexionSQL.Conexion CloseUsuario = new BD.ConexionSQL.Conexion();
            SqlDataReader ListaEmpresas = UsuarioConn.ListarUsuarios();

            while (ListaEmpresas.Read())
            {
                lb_UsuariosCreados.Items.Add(ListaEmpresas["Nom_Usuario"].ToString());
            }

            CloseUsuario.CerrarConexionnBD();
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

        private void btn_AdminUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AdministrarUsuario FormAdminUsuario = new Form_AdministrarUsuario();
            FormAdminUsuario.Show();
        }

        private void lbl_UsuariosCreados_Click(object sender, EventArgs e)
        {

        }

        private void lb_UsuariosCreados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_RegLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login FormLogin = new Form_Login();
            FormLogin.Show();
        }

        //public dynamic UsuarioSlecionado()
        //{
        //    if (lb_UsuariosCreados.SelectedIndex != -1)
        //    {
        //        dynamic UsuarioSelect = (string)lb_UsuariosCreados.Items[lb_UsuariosCreados.SelectedIndex];
        //        return UsuarioSelect;
        //    }

        //}
    }
}
