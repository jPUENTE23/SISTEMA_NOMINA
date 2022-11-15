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
    public partial class Form_CrearUsuario : Form
    {
        public Form_CrearUsuario()
        {
            InitializeComponent();
        }

        private void link_Regresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_UsuariosCreados FormUsuarioCreados = new Form_UsuariosCreados();
            FormUsuarioCreados.Show();
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            /* Guardamos loa datos ingresados por el usuario dentro de las siguientes variables */
            dynamic NombreUsuario = txt_nomUsuario.Text;
            dynamic Contraseña = txt_Contrseña.Text;
            dynamic ConfirmContraseña = txt_confirmContraseña.Text;

            /* Validamos que los dos campos donde se solicita la contraseña sean iguales */
            if (Contraseña == ConfirmContraseña)
            {
                /* Creamos una instancia con las Clase usuario que conecta al servidor de base de datos */
                BD.ConexionSQL.Usuarios UserConn = new BD.ConexionSQL.Usuarios();


                /* Mandamos a llamr el metodo Crear_Usuario y pasamos como parametos el 
                 nombre del usuario y contrsela ingresada por el usuario */
                UserConn.Crear_Usuario(NombreUsuario, Contraseña);

                MessageBox.Show("El usuario se creo con exito");


                txt_nomUsuario.Clear();
                txt_Contrseña.Clear();
                txt_confirmContraseña.Clear();
            }
            else
            {
                /* Si las contrselas ingresadas no son iguales, se le informara al usuario que lo
                 verifique y lo intente de nuevo */
                MessageBox.Show("Las contrseñas ingresadas no coinciden. Favor de verificar");
            }
        }

        private void pictureBox_RegUsuariosC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_UsuariosCreados FormUsuarioCreados = new Form_UsuariosCreados();
            FormUsuarioCreados.Show();
        }
    }
}
