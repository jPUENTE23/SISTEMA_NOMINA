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
    public partial class Form_ExplorarRecibos : Form
    {
        public dynamic Usuario;
        public dynamic Empresa;
        public int idEmpresa;
        public Form_ExplorarRecibos(dynamic NomUsuario, dynamic NomEmpresa, int IdEmpr)
        {
            InitializeComponent();
            this.Usuario = NomUsuario;
            this.Empresa = NomEmpresa;
            this.idEmpresa = IdEmpr;

            BD.ConexionSQL.Empresa ConnEmpresas = new BD.ConexionSQL.Empresa();
            BD.ConexionSQL.Recibos ConnRecibos = new BD.ConexionSQL.Recibos();

            SqlDataReader Recibos = ConnRecibos.ExplorarRecibos(this.idEmpresa);


            int indexRecibos;
            while (Recibos.Read())
            {
                indexRecibos = dataGV_ExplorearRec.Rows.Add();
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[0].Value = Recibos["ID_Recibo"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[1].Value = Recibos["RFC_Empl"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[2].Value = Recibos["Nom_Empl"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[3].Value = Recibos["Fecha_Pago"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[4].Value = Recibos["Fecha_Emision"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[5].Value = Recibos["Fecha_Inicial"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[6].Value = Recibos["Fecha_Final"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[7].Value = Recibos["Dias_Pagados"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[8].Value = Recibos["Percepciones"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[9].Value = Recibos["Deducciones"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[10].Value = Recibos["Otros_Pagos"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[11].Value = Recibos["Neto"];
                dataGV_ExplorearRec.Rows[indexRecibos].Cells[12].Value = Recibos["RFC_Empresa"];
            }

            //if (Recibos.Read())
            //{
                
            //}

            //SqlDataReader idEmpresa = ConnEmpresas.ID_Empresa(this.Empresa);

            //int idEmpr = 0;
            //if (idEmpresa.Read())
            //{
            //    //idEmpr = Convert.ToInt16(idEmpresa["ID_Empresa"]);
                
            //}

        }

        private void dataGV_ExplorearRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menu FormMenu = new Form_Menu(this.Usuario, this.Empresa, this.idEmpresa);
            FormMenu.lbl_NomEmpresa.Text = this.Empresa;
            FormMenu.lbl_User.Text = this.Usuario;
            FormMenu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menu FormMenu = new Form_Menu(this.Usuario, this.Empresa,this.idEmpresa);
            FormMenu.lbl_NomEmpresa.Text = this.Empresa;
            FormMenu.lbl_User.Text = this.Usuario;
            FormMenu.Show();
        }


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BD.ConexionSQL.Recibos ConnRecibos = new BD.ConexionSQL.Recibos();

            if (String.IsNullOrEmpty(txt_RFC.Text))
            {
                MessageBox.Show("Ingrese el RFC del empleado a buscar");
            }
            else
            {
                dynamic RFC = txt_RFC.Text;
                SqlDataReader RecRfc = ConnRecibos.BuscarReciboRFC(RFC);

                if (RecRfc.Read())
                {
                    int indexRecibos;
                    dataGV_ExplorearRec.Rows.Clear();
                    while (RecRfc.Read())
                    {
                        indexRecibos = dataGV_ExplorearRec.Rows.Add();
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[0].Value = RecRfc["ID_Recibo"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[1].Value = RecRfc["RFC_Empl"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[2].Value = RecRfc["Nom_Empl"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[3].Value = RecRfc["Fecha_Pago"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[4].Value = RecRfc["Fecha_Emision"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[5].Value = RecRfc["Fecha_Inicial"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[6].Value = RecRfc["Fecha_Final"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[7].Value = RecRfc["Dias_Pagados"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[8].Value = RecRfc["Percepciones"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[9].Value = RecRfc["Deducciones"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[10].Value = RecRfc["Otros_Pagos"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[11].Value = RecRfc["Neto"];
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[12].Value = RecRfc["RFC_Empresa"];
                    }
                }
                txt_RFC.Clear();
            }
        }
    }
}
