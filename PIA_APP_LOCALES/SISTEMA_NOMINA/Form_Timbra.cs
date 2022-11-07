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
    public partial class Form_Timbra : Form
    {
        dynamic Usuario_;
        public Form_Timbra(dynamic usuario)
        {
            InitializeComponent();
            this.Usuario_ = usuario;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menu FormMenu = new Form_Menu(this.Usuario_);
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
            List<ConceptosPercepciones> ConPercepciones = new List<ConceptosPercepciones>()
            {
                new ConceptosPercepciones()
                {
                    ConceptoPercepcion = cb_Percepciones.Items[indicePer].ToString(),
                    Clave = Convert.ToInt32(txt_ClavePer.Text),
                    DescPercecepcion = txt_DescPer.Text,
                    Importe = Convert.ToDouble(txt_ImportePer.Text)
                }
            };

            int indexPercepciones = dataGV_Percepciones.Rows.Add();

            foreach (dynamic dato in ConPercepciones)
            {
                dataGV_Percepciones.Rows[indexPercepciones].Cells[0].Value = dato.ConceptoPercepcion;
                dataGV_Percepciones.Rows[indexPercepciones].Cells[1].Value = dato.Clave;
                dataGV_Percepciones.Rows[indexPercepciones].Cells[2].Value = dato.DescPercecepcion;
                dataGV_Percepciones.Rows[indexPercepciones].Cells[3].Value = dato.Importe;
            }

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

        private void btn_AgregarDed_Click(object sender, EventArgs e)
        {
            int indicePer = cb_Deducciones.SelectedIndex;
            List<ConceptosDeducciones> ConPercepciones = new List<ConceptosDeducciones>()
            {
                new ConceptosDeducciones()
                {
                    ConceptoDeduccion = cb_Deducciones.Items[indicePer].ToString(),
                    Clave = Convert.ToInt32(txt_ClaveDed.Text),
                    DescDeduccion = txt_DescDed.Text,
                    Importe = Convert.ToDouble(txt_importeDed.Text)
                }
            };

            int indexDeducciones = dataGV_Deducciones.Rows.Add();

            foreach (dynamic dato in ConPercepciones)
            {
                dataGV_Deducciones.Rows[indexDeducciones].Cells[0].Value = dato.ConceptoDeduccion;
                dataGV_Deducciones.Rows[indexDeducciones].Cells[1].Value = dato.Clave;
                dataGV_Deducciones.Rows[indexDeducciones].Cells[2].Value = dato.DescDeduccion;
                dataGV_Deducciones.Rows[indexDeducciones].Cells[3].Value = dato.Importe;
            }

            txt_ClaveDed.Text = "";
            txt_DescDed.Text = "";
            txt_importeDed.Text = "";

        }
    }
}
