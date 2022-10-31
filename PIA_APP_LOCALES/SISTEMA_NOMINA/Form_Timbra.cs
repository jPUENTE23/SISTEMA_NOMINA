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
        public Form_Timbra()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menu FormMenu = new Form_Menu();
            FormMenu.Show();
        }

        private void btn_AgregarPer_Click(object sender, EventArgs e)
        {
            List<ConceptosPercepciones> ConPercepciones = new List<ConceptosPercepciones>()
            {
                new ConceptosPercepciones()
                {
                    ConceptoPercepcion = txt_Percepcion.Text,
                    Clave = Convert.ToInt32(txt_ClavePer.Text),
                    DescPercecepcion = txt_DescPer.Text,
                    Importe = Convert.ToDouble(txt_ImportePer.Text)
                }
            };

            int n = dataGV_Percepciones.Rows.Add();

            foreach (dynamic dato in ConPercepciones)
            {
                dataGV_Percepciones.Rows[n].Cells[0].Value = dato.ConceptoPercepcion;
                dataGV_Percepciones.Rows[n].Cells[1].Value = dato.Clave;
                dataGV_Percepciones.Rows[n].Cells[2].Value = dato.DescPercecepcion;
                dataGV_Percepciones.Rows[n].Cells[3].Value = dato.Importe;
            }


        }


        class ConceptosPercepciones
        {
            public string ConceptoPercepcion { get; set; }
            public int Clave { get; set; }
            public dynamic DescPercecepcion { get; set; }
            public double Importe { get; set; }
        }

    }
}
