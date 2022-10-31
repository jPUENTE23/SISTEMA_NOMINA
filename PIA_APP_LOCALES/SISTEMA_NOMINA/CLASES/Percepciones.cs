using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_NOMINA.CLASES
{
    internal class Percepciones
    {
        class ConceptosPercepciones
        {
            public string ConceptoPercepcion { get; set; }
            public int Clave { get; set; }
            public dynamic DescPercecepcion { get; set; }
            public double Importe { get; set; }
        }

        public void addPercecpiones(string ConceptoPer, int ClavePer, dynamic DescPer, double ImportePer)
        {
            List<ConceptosPercepciones> ConPercepciones = new List<ConceptosPercepciones>()
            {
                new ConceptosPercepciones() 
                {
                    ConceptoPercepcion = ConceptoPer,
                    Clave = ClavePer,
                    DescPercecepcion = DescPer,
                    Importe = ImportePer
                }
            };
        }
    }
}
