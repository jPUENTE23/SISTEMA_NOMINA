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
            // EVENTO LOGIN
            /* Creamos las instancias para llamar las clases Login y Conexion */
            BD.ConexionSQL.Login ConnLogin = new BD.ConexionSQL.Login();
            BD.ConexionSQL.Conexion CloseLogin = new BD.ConexionSQL.Conexion();

            /* Almacenamos los datos ingresados por el usuario en variables */
            dynamic Usuario = txt_Usuario.Text;
            dynamic Contraseña = txt_Contraseña.Text;

            /* Llamamos el metodo para validar si los datos ingresados se encuentrab dentro de la
             base de datos */
            SqlDataReader ResultadoLogin = ConnLogin.LoginValidar(Usuario, Contraseña);


            /* Verificamos si ResultadoLogin contiene datos */
            if (ResultadoLogin.Read())
            {
                /* Si contiene datos, significa que el usuario y contrseña ingresados son valida
                 y podemos proceder a pasar a la siguiente pantalla */
                this.Hide();
                Form_SeleccionarEmpr FormSeleccionarEmpr = new Form_SeleccionarEmpr();
                FormSeleccionarEmpr.Show();

                txt_Usuario.Clear();

            }
            else
            {
                /* Si no cotien datos, le avisaremos al usuario que desea ingresar que los datos proporcinados
                 no son corretos o no existen */
                MessageBox.Show("Las creedenciales ingresadss no se encontraron. \nFavor de verificar que los datos ingreesados sean validos. ");
            }

            /* Cerramos la conexion */
            CloseLogin.CerrarConexionnBD();

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

        private void btn_salirApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
