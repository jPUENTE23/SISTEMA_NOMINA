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
    public partial class Form_SeleccionarEmpr : Form
    {

        /* Creamos una variable nivel de clase para posteriomente usarla en el constructor */
        private dynamic _Usuario;

        /*  Agregamos una parametro en el contructor que recibira cada vez que se mande 
            a llamer el formulario.
            
            El obejtivo de esto es que cuando se ingrese con cualquier usuario, este almacene 
            el nombre del usuario, para luego buscar que que empresas se le tiene asignado a ese 
            usuario y nos las muestre en el listado del combo box */
        public Form_SeleccionarEmpr(dynamic NomUsuario)
        {
            InitializeComponent();

            /* Guardamos el parametro recibo en la variable que se creo a nivel de clase */
            this._Usuario = NomUsuario;

            /* Guardamos el valor de this._Usuario en una nueva variable */
            dynamic UserSelect = this._Usuario;


            /* Creamos las instancias para accede a las clases que utlizaremos */
            BD.ConexionSQL.Detalle_Usuario DU_Conn = new BD.ConexionSQL.Detalle_Usuario();
            BD.ConexionSQL.Usuarios Usuario_Conn = new BD.ConexionSQL.Usuarios();
            BD.ConexionSQL.Conexion CloseConn = new BD.ConexionSQL.Conexion();

            /* Obtenemos el id del usuario con el que se ingreso */
            SqlDataReader Id_Usuario = Usuario_Conn.ID_USUARIO(UserSelect);


            /* Verificamos si se encontraron registros */
            if (Id_Usuario.Read())
            {
                /*  Si se encontraron, procedemos a buscar las empreesa a las que el usuarip
                    tiene asignadas */
                int userId = Convert.ToInt16(Id_Usuario["ID_Usuario"]);
                SqlDataReader List_DU = DU_Conn.Empresas_Usuarios(userId);


                while (List_DU.Read())
                {
                    /* Vaciamos todas las empreces que el usuario tiene asignado dentro 
                     de nuestro listbox*/
                    cb_EmpresasUsuarios.Items.Add(List_DU["Nom_Empresa"]);
                }
            }
            CloseConn.CerrarConexionnBD();
        }


        private void link_CambiarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Login FormLogin = new Form_Login();
            FormLogin.Show();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

            int indexEmpresa = cb_EmpresasUsuarios.SelectedIndex;
            dynamic EmpresaSelect = cb_EmpresasUsuarios.Items[indexEmpresa].ToString();

            BD.ConexionSQL.Empresa ConnEmpresa = new BD.ConexionSQL.Empresa();

            SqlDataReader idEmpresa = ConnEmpresa.ID_Empresa(EmpresaSelect);

            if (idEmpresa.Read())
            {
                int empresaId = Convert.ToInt16(idEmpresa["ID_Empresa"]);
                this.Hide();
                Form_Menu FormMenu = new Form_Menu(this._Usuario, EmpresaSelect, empresaId);
                FormMenu.lbl_NomEmpresa.Text = EmpresaSelect;
                FormMenu.lbl_User.Text = this._Usuario;
                FormMenu.Show();
            }
            
            
        }

        private void pictureBox_RegLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login FormLogin = new Form_Login();
            FormLogin.Show();
        }
    }
}
