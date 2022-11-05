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
    public partial class Form_EmpresasCreadas : Form
    {
        public Form_EmpresasCreadas()
        {
            InitializeComponent();

            /* Creamoas una istancia para poder acceder a la calse Empresa */
            BD.ConexionSQL.Empresa LstreEmpresas = new BD.ConexionSQL.Empresa();

            /* Creamos otra instancia para cerrar la conexion a las base de datos una vez que
             terminemos de listar las empresas */
            BD.ConexionSQL.Conexion closeConn = new BD.ConexionSQL.Conexion();

            /* Almacenamos los resultados obetenido de la bese de datos en la varibale Empresa */
            SqlDataReader Empresas = LstreEmpresas.ListarEmpresas();

            /* Si la variable Empresas contiene registros, entonces procedemos a listarlos dentro 
             de nuestro listbox */
            while (Empresas.Read())
            {
                /* Creamos un item dentro del listbox por cadd nombre de empresa */
                lb_EmprCreadas.Items.Add(Empresas["Nom_Empresa"].ToString());
            }

            /* Cearramos la conexion de nuestra base de datos */
            closeConn.CerrarConexionnBD();
        }

        private void btn_NuevaEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CrearEmpresa FormCrearEmpresa = new Form_CrearEmpresa();
            FormCrearEmpresa.Show();
        }

        private void link_regresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Login FormLogin = new Form_Login();
            FormLogin.Show();
        }
    }
}
