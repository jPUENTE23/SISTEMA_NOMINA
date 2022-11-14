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
        public Form_ExplorarRecibos(dynamic NomUsuario, dynamic NomEmpresa)
        {
            InitializeComponent();
            this.Usuario = NomUsuario;
            this.Empresa = NomEmpresa;

            BD.ConexionSQL.Empresa ConnEmpresas = new BD.ConexionSQL.Empresa();
            BD.ConexionSQL.Recibos ConnRecibos = new BD.ConexionSQL.Recibos();

            SqlDataReader idEmpresa = ConnEmpresas.ID_Empresa(this.Empresa);

            int idEmpr = 0;
            if (idEmpresa.Read())
            {
                idEmpr = Convert.ToInt16(idEmpresa["ID_Empresa"]);
                SqlDataReader Recibos = ConnRecibos.ExplorarRecibos(idEmpr);
                

                if (Recibos.Read())
                {
                    List<Recibos> ListRecibos = new List<Recibos>();
                    foreach (dynamic Recibo in Recibos)
                    {
                        ListRecibos.Add(new Recibos()
                        {
                            idRecibo = Recibo["ID_Recibo"],
                            RFCEmpleado = Recibo["RFC_Empl"],
                            NomEmpleado = Recibo["Nom_Empl"],
                            FechaPago = Recibo["Fecha_Pago"],
                            FechaEmision = Recibo["Fecha_Emision"],
                            FechaInicial = Recibo["Fecha_Inicial"],
                            FechaFinal = Recibo["Fecha_Final"],
                            DiasPagados = Recibo["Dias_Pagados"],
                            Percepciones = Convert.ToDouble(Recibo["Percepciones"]),
                            Deducciones = Convert.ToDouble(Recibo["Deducciones"]),
                            OtrosPagos = Convert.ToDouble(Recibo["Otros_Pagos"]),
                            Neto = Convert.ToDouble(Recibo["Neto"]),
                            RFCEmpresa = Recibo["RFC_Empresa"],
                        });
                    }

                    int indexRecibos;

                    foreach (dynamic dato in ListRecibos)
                    {
                        indexRecibos = dataGV_ExplorearRec.Rows.Add();
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[0].Value = dato.idRecibo;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[1].Value = dato.RFCEmpleado;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[2].Value = dato.NomEmpleado;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[3].Value = dato.FechaPago;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[4].Value = dato.FechaEmision;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[5].Value = dato.FechaInicial;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[6].Value = dato.FechaFinal;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[7].Value = dato.DiasPagados;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[8].Value = dato.Percepciones;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[9].Value = dato.Deducciones;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[10].Value = dato.OtrosPagos;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[11].Value = dato.Neto;
                        dataGV_ExplorearRec.Rows[indexRecibos].Cells[12].Value = dato.RFCEmpresa;
                    }
                }
            }

                //SqlDataReader Recibos = ConnRecibos.ExplorarRecibos(idEmpr);
                //int indexRecibos = dataGV_ExplorearRec.Rows.Add();

                //while (Recibos.Read())
                //{
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[0].Value = Recibos["ID_Recibo"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[1].Value = Recibos["RFC_Empl"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[2].Value = Recibos["Nom_Empl"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[3].Value = Recibos["Fecha_Pago"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[4].Value = Recibos["Fecha_Emision"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[5].Value = Recibos["Fecha_Inicial"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[6].Value = Recibos["Fecha_Final"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[7].Value = Recibos["Dias_Pagados"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[8].Value = Recibos["Percepciones"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[9].Value = Recibos["Deducciones"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[10].Value = Recibos["Otros_Pagos"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[11].Value = Recibos["Neto"];
                //    dataGV_ExplorearRec.Rows[indexRecibos].Cells[12].Value = Recibos["RFC_Empresa"];
                //}
            }

        private void dataGV_ExplorearRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menu FormMenu = new Form_Menu(this.Usuario, this.Empresa);
            FormMenu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menu FormMenu = new Form_Menu(this.Usuario, this.Empresa);
            FormMenu.Show();
        }

        class Recibos
        {
            public int idRecibo { get; set; }
            public dynamic RFCEmpleado { get; set; }
            public string NomEmpleado { get; set; }
            public DateTime FechaPago { get; set; }
            public DateTime FechaEmision { get; set; }
            public DateTime FechaInicial { get; set; }
            public DateTime FechaFinal { get; set; }
            public int DiasPagados { get; set; }
            public double Percepciones { get; set; }
            public double Deducciones { get; set; }
            public double OtrosPagos { get; set; }
            public double Neto { get; set; }
            public dynamic RFCEmpresa { get; set; }
        }
    }
    
}
