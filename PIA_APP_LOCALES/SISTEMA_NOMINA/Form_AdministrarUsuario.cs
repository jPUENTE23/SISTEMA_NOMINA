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

        }

        private void link_Regresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_UsuariosCreados FormUsuarioCreados = new Form_UsuariosCreados();
            FormUsuarioCreados.Show();
        }

        private void btn_AgrEmpresa_Click(object sender, EventArgs e)
        {

            /* Creamos las instacias necesarias para acceder a las clases fuera del archivo */
            BD.ConexionSQL.Empresa ConnEmpresas = new BD.ConexionSQL.Empresa();
            BD.ConexionSQL.Usuarios ConnUsuarios = new BD.ConexionSQL.Usuarios();
            BD.ConexionSQL.Detalle_Usuario ConnDU = new BD.ConexionSQL.Detalle_Usuario();

            BD.ConexionSQL.Conexion ClsoeConn = new BD.ConexionSQL.Conexion();

            /* Obetenr el indice el usuario y empresa selecccionado en el combo box*/
            int indexUsuario = cb_Usuarios.SelectedIndex;
            int indexEmpresa = cb_Empresas.SelectedIndex;

            /* Utilizadon el indece campurado anteriormente, lo utilizamos para obtener el
             nombre del usuatrio y de la empresa, posteriomente guardarlos en una variable */
            string nomUsuario = cb_Usuarios.Items[indexUsuario].ToString();
            string nomEmpresa = cb_Empresas.Items[indexEmpresa].ToString();

            /* Mandoamos a llamer el los metodos para obetener el id de ambos desde la base de datos */
            SqlDataReader getIdUsuario = ConnUsuarios.ID_USUARIO(nomUsuario);
            SqlDataReader getIdEmpresa = ConnEmpresas.ID_Empresa(nomEmpresa);


            /* Verificamos si getIdUsuario y getIdEmpresa contienen registrosa */
            if (getIdUsuario.Read() & getIdEmpresa.Read())
            {
                /* Si tiene registros, almacenamos los id obtenidos a una nueva variable */
                int DU_Usuario = Convert.ToInt16(getIdUsuario["ID_Usuario"]);
                int DU_Empresa = Convert.ToInt16(getIdEmpresa["ID_Empresa"]);


                /* Llamamos el metodo Insertar_DU para incertar los datos */
                ConnDU.Insertar_DU(DU_Usuario, DU_Empresa);

                MessageBox.Show("La emrpesa se agrego correctamente");

            }

            ClsoeConn.CerrarConexionnBD();
        }

        private void btn_ConsultarUsuario_Click(object sender, EventArgs e)
        {
            //MOSTRARA LAS EMPRESAS ASIGNADAS DE ACUERDO AL USUARIO SELECCIONADO
            //-----------------------------------------------------------------------------------------
            BD.ConexionSQL.Usuarios ConnUsuarios = new BD.ConexionSQL.Usuarios();
            BD.ConexionSQL.Conexion ClsoeConn = new BD.ConexionSQL.Conexion();
            int indexDuUsuario = cb_Usuarios.SelectedIndex;
            string nomDuUsuario = cb_Usuarios.Items[indexDuUsuario].ToString();
            SqlDataReader DU_Id_Usuario = ConnUsuarios.ID_USUARIO(nomDuUsuario);

            if (DU_Id_Usuario.Read())
            {
                int DU_IdUsuario = Convert.ToInt16(DU_Id_Usuario["ID_Usuario"]);

                BD.ConexionSQL.Detalle_Usuario Class_DetalleUsuari = new BD.ConexionSQL.Detalle_Usuario();
                SqlDataReader EmpresaUsuarios = Class_DetalleUsuari.Empresas_Usuarios(DU_IdUsuario);

                lb_EmprAsignadas.Items.Clear();
                while (EmpresaUsuarios.Read())
                {
                    lb_EmprAsignadas.Items.Add(EmpresaUsuarios["Nom_Empresa"].ToString());
                }
                
            }
            ClsoeConn.CerrarConexionnBD();
        }

        private void Form_AdministrarUsuario_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }
    }
}
