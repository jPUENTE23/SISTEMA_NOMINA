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
    public partial class Form_Timbra : Form
    {


        dynamic Usuario_;
        dynamic Empresa_;
        List<ConceptosPercepciones> ListaPercepciones = new List<ConceptosPercepciones>();
        List<ConceptosDeducciones> ListaDeducciones = new List<ConceptosDeducciones>();
        List<ConceptosOtrosPagos> ListaOtrosPagos = new List<ConceptosOtrosPagos>();
        public Form_Timbra(dynamic usuario, dynamic empresa)
        {
            InitializeComponent();
            this.Usuario_ = usuario;
            this.Empresa_ = empresa;

            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menu FormMenu = new Form_Menu(this.Usuario_, this.Empresa_);
            FormMenu.lbl_User.Text = this.Usuario_;
            FormMenu.lbl_NomEmpresa.Text = this.Empresa_;
            FormMenu.Show();
        }


        //PERCEPCIONES

        class ConceptosPercepciones
        {
            public string ConceptoPercepcion { get; set; }
            public int Clave { get; set; }
            public dynamic DescPercecepcion { get; set; }
            public double Importe { get; set; }
        }

        private void btn_AgregarPer_Click(object sender, EventArgs e)
        {
            int indicePer = cb_Percepciones.SelectedIndex;
            ListaPercepciones.Add(new ConceptosPercepciones()
            {
                ConceptoPercepcion = cb_Percepciones.Items[indicePer].ToString(),
                Clave = Convert.ToInt32(txt_ClavePer.Text),
                DescPercecepcion = txt_DescPer.Text,
                Importe = Convert.ToDouble(txt_ImportePer.Text)

            });

            int indexPercepciones = dataGV_Percepciones.Rows.Add();

            double calPer = 0;
            foreach (dynamic dato in ListaPercepciones)
            {
                indexPercepciones = dataGV_Percepciones.Rows.Add();
                dataGV_Percepciones.Rows[indexPercepciones].Cells[0].Value = dato.ConceptoPercepcion;
                dataGV_Percepciones.Rows[indexPercepciones].Cells[1].Value = dato.Clave;
                dataGV_Percepciones.Rows[indexPercepciones].Cells[2].Value = dato.DescPercecepcion;
                dataGV_Percepciones.Rows[indexPercepciones].Cells[3].Value = dato.Importe;
                calPer += dato.Importe;
            }
            lbl_TotalPer.Text = "$" + Convert.ToString(calPer);

            txt_ClavePer.Text = "";
            txt_DescPer.Text = "";
            txt_ImportePer.Text = "";

        }

        
        // DEDUCCIONES

        class ConceptosDeducciones
        {
            public string ConceptoDeduccion { get; set; }
            public int Clave { get; set; }
            public dynamic DescDeduccion { get; set; }
            public double Importe { get; set; }
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            /* instancias de conexion */
            BD.ConexionSQL.Timbra ConnTimbra = new BD.ConexionSQL.Timbra();
            BD.ConexionSQL.Empresa ConnEmpresa = new BD.ConexionSQL.Empresa();
            BD.ConexionSQL.Conexion CloseConn = new BD.ConexionSQL.Conexion();
            /* Obetemos las percepciones y deducciones ingresadas */
            List<ConceptosPercepciones> datosPercepciones = ListaPercepciones;
            List<ConceptosDeducciones> datosDeducciones = ListaDeducciones;
            List<ConceptosOtrosPagos> datosOtrosPagos = ListaOtrosPagos;


            /* Guardamos los datos ingreasdos por el usuario */
            dynamic RFC_Empleado = txt_RFC_Empleado.Text;
            dynamic Nom_Empleado = txt_NomEmpleado.Text;
            DateTime FechaEmisiion = DateTime.Now;
            DateTime FechaPago = dt_FechaPag.Value;
            DateTime FechaInicial = dt_FechaInicial.Value;
            DateTime FechaFinal = dt_FechaFinal.Value;
            int DiasPagados = int.Parse(txt_DiasPagados.Text);
            double sumPerceppciones = 0;
            double sumDeduccion = 0;
            double sumOtrosPagos = 0;
            
            /* Calculo de las perciones*/
            foreach (dynamic percepcion in datosPercepciones)
            {
                sumPerceppciones += percepcion.Importe;
            }
            double TotalPercepciones = sumPerceppciones;

            /* Calculo de las deudciones */
            foreach (dynamic dedcuccion in datosDeducciones)
            {
                sumDeduccion += dedcuccion.Importe;
            }
            double TotalDeduccion = sumDeduccion;

            /* Calcular otros pagos */
            foreach (dynamic OtrosP in datosOtrosPagos)
            {
                sumOtrosPagos += OtrosP.ImporteOtrosPagos;
            }
            double TotalOtrosP = sumOtrosPagos;
            int idEmpresa = 0;

            /* obtenemos el ID de la empresa emisara del recibo */
            SqlDataReader getIdEmpresa = ConnEmpresa.ID_Empresa(this.Empresa_);

            if (getIdEmpresa.Read())
            {
                idEmpresa = Convert.ToInt16(getIdEmpresa["ID_Empresa"]);
            }
            CloseConn.CerrarConexionnBD();

            double ImporteNeto = TotalPercepciones - TotalDeduccion + TotalOtrosP;

            /* Guardamos los datos del recibo */
            SqlDataReader id_recibo = ConnTimbra.Gen_Recibo(
                Nom_Empleado,
                RFC_Empleado,
                FechaEmisiion,
                FechaPago,
                FechaInicial,
                FechaFinal,
                DiasPagados,
                TotalPercepciones,
                TotalDeduccion,
                TotalOtrosP,
                ImporteNeto,
                idEmpresa);

            int idRecibo = 0;

            if (id_recibo.Read())
            {
                /* Extraemos el ID del redcibo emitido para relacionalo con sus coceptos */
                idRecibo = Convert.ToInt16(id_recibo[0]);
                CloseConn.CerrarConexionnBD();

            }

            foreach (dynamic Per in datosPercepciones)
            {
                ConnTimbra.RelacionarConcepto(
                    "Percepcion",
                    Per.ConceptoPercepcion,
                    Per.Clave,
                    Per.DescPercecepcion,
                    Per.Importe,
                    idRecibo);
            }

            //foreach (dynamic Per in datosDeducciones)
            //{
            //    ConnTimbra.RelacionarConcepto(
            //        TipoConDed,
            //        Per.ConceptoDeduccion,
            //        Per.Clave,
            //        Per.DescDeduccion,
            //        Per.Importe,
            //        idRecibo);
            //}

            //foreach (dynamic Per in datosOtrosPagos)
            //{
            //    ConnTimbra.RelacionarConcepto(
            //        TipoConOP,
            //        Per.ConceptoDtrosPagos,
            //        Per.ClaveOtrosPagos,
            //        Per.DescOtrosPagos,
            //        Per.ImporteOtrosPagos,
            //        idRecibo);
            //}

            MessageBox.Show("El recibo se a emitido correctamente");

            lbl_motno.Text = Convert.ToString(idRecibo);
        }

        private void btn_AgregarDed_Click(object sender, EventArgs e)
        {
            int indicePer = cb_Deducciones.SelectedIndex;
            ListaDeducciones.Add(new ConceptosDeducciones()
            {
                ConceptoDeduccion = cb_Deducciones.Items[indicePer].ToString(),
                Clave = Convert.ToInt32(txt_ClaveDed.Text),
                DescDeduccion = txt_DescDed.Text,
                Importe = Convert.ToDouble(txt_importeDed.Text)
            });
               
            int indexDeducciones = dataGV_Deducciones.Rows.Add();

            double calDed = 0;
            foreach (dynamic dato in ListaDeducciones)
            {
                dataGV_Deducciones.Rows[indexDeducciones].Cells[0].Value = dato.ConceptoDeduccion;
                dataGV_Deducciones.Rows[indexDeducciones].Cells[1].Value = dato.Clave;
                dataGV_Deducciones.Rows[indexDeducciones].Cells[2].Value = dato.DescDeduccion;
                dataGV_Deducciones.Rows[indexDeducciones].Cells[3].Value = dato.Importe;
                calDed += dato.Importe;

            }
            lbl_TotalDed.Text = "$" + Convert.ToString(calDed);


            txt_ClaveDed.Text = "";
            txt_DescDed.Text = "";
            txt_importeDed.Text = "";

        }


        class ConceptosOtrosPagos
        {
            public string ConceptoDtrosPagos { get; set; }
            public int ClaveOtrosPagos { get; set; }
            public dynamic DescOtrosPagos { get; set; }
            public double ImporteOtrosPagos { get; set; }
        }

        private void btn_AgregarOP_Click(object sender, EventArgs e)
        {
            int indexOP = cb_TipoOp.SelectedIndex;
            ListaOtrosPagos.Add(new ConceptosOtrosPagos()
            {
                ConceptoDtrosPagos = cb_TipoOp.Items[indexOP].ToString(),
                ClaveOtrosPagos = Convert.ToInt32(txt_ClaveOP.Text),
                DescOtrosPagos = txt_DescOP.Text,
                ImporteOtrosPagos = Convert.ToDouble(txt_ImporteOP.Text)
            });

            int idexOtrosPagos = dataGV_OtrosPagos.Rows.Add();
            double calOtrosP = 0;
            foreach (dynamic otrosP in ListaOtrosPagos)
            {
                dataGV_OtrosPagos.Rows[idexOtrosPagos].Cells[0].Value = otrosP.ConceptoDtrosPagos;
                dataGV_OtrosPagos.Rows[idexOtrosPagos].Cells[1].Value = otrosP.ClaveOtrosPagos;
                dataGV_OtrosPagos.Rows[idexOtrosPagos].Cells[2].Value = otrosP.DescOtrosPagos;
                dataGV_OtrosPagos.Rows[idexOtrosPagos].Cells[3].Value = otrosP.ImporteOtrosPagos;
                calOtrosP += otrosP.ImporteOtrosPagos;
            }
            lbl_TotalOP.Text = "$" + Convert.ToString(calOtrosP);

            txt_ClaveOP.Clear();
            txt_DescOP.Clear();
            txt_ImporteOP.Clear();
        }

        private void Form_Timbra_Load(object sender, EventArgs e)
        {

        }
    }
}
