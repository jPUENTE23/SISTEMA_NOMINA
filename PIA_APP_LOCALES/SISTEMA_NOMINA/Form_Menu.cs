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
    public partial class Form_Menu : Form
    {
        private dynamic ConectUser;
        private dynamic ConectEmpresa;
        private int idEmpresa;
        public Form_Menu(dynamic userConect, dynamic Empresa, int id_empresa)
        {
            InitializeComponent();
            this.ConectUser = userConect;
            this.ConectEmpresa = Empresa;
            this.idEmpresa = id_empresa;

            BD.ConexionSQL.Recibos ConnRecibos = new BD.ConexionSQL.Recibos();
            BD.ConexionSQL.Empresa ConnEmpresa = new BD.ConexionSQL.Empresa();

            //SqlDataReader idEmpresa = ConnEmpresa.ID_Empresa(this.ConectEmpresa);
            //int EmpresaID = Convert.ToInt16(idEmpresa["ID_Empresa"]);
            SqlDataReader RecibosRec = ConnRecibos.ListarRecibosMenu(this.idEmpresa);
            if (RecibosRec.Read())
            {
                int indexRecibos;
                while (RecibosRec.Read())
                {
                    indexRecibos = dataGV_RecibosMenu.Rows.Add();
                    dataGV_RecibosMenu.Rows[indexRecibos].Cells[0].Value = RecibosRec["ID_Recibo"];
                    dataGV_RecibosMenu.Rows[indexRecibos].Cells[1].Value = RecibosRec["RFC_Empl"];
                    dataGV_RecibosMenu.Rows[indexRecibos].Cells[2].Value = RecibosRec["Nom_Empl"];
                    dataGV_RecibosMenu.Rows[indexRecibos].Cells[3].Value = RecibosRec["Fecha_Emision"];
                }
            }
            //if (idEmpresa.Read())
            //{
                
            //}

            
        }

        private void btn_Timbra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Timbra FormTimba = new Form_Timbra(this.ConectUser, this.ConectEmpresa, this.idEmpresa);
            Form_SeleccionarEmpr FormSelectEmpre = new Form_SeleccionarEmpr(this.ConectUser);
            FormSelectEmpre.lbl_usuarioSleccionado.Text = this.ConectUser;
            FormTimba.Show();
        }

        private void btn_SalirDeEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SeleccionarEmpr FormSeleccionarEmpr = new Form_SeleccionarEmpr(this.ConectUser);
            FormSeleccionarEmpr.lbl_usuarioSleccionado.Text = this.ConectUser;
            FormSeleccionarEmpr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExplorarRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ExplorarRecibos FormExplorarRecibos = new Form_ExplorarRecibos(this.ConectUser, this.ConectEmpresa, this.idEmpresa);
            FormExplorarRecibos.Show();
        }
    }
}
