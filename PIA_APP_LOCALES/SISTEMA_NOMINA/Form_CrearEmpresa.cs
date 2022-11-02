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
    public partial class Form_CrearEmpresa : Form
    {
        public Form_CrearEmpresa()
        {
            InitializeComponent();
        }

        private void btn_GenerarEmpr_Click(object sender, EventArgs e)
        {
            BD.ConexionSQL.Empresa CrearEmpresa = new BD.ConexionSQL.Empresa();

            dynamic NombreEmpresa = txt_NomEmpresa.Text;
            dynamic RFC_Empresa = txt_RFCEmpr.Text;

            try
            {
                CrearEmpresa.InsertarEmopresa(NombreEmpresa, RFC_Empresa);
                MessageBox.Show("La Empresa se a creado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la empresa " + ex.ToString());
            }

            txt_NomEmpresa.Text = "";
            txt_RFCEmpr.Text = "";
            NombreEmpresa = "";
            RFC_Empresa = "";
        }
    }
}
