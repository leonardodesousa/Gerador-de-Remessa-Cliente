using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Model
{
    internal class Encargo
    {
        public string identificadorDiasAte30Dias { get; set; }
        public float taxaPermanenciaAte30Dias { get; set; }
        public string identificadorFormaAte30Dias { get; set; }
        public string identificadorDiasMais30Dias { get; set; }
        public float taxaPermanenciaMais30Dias { get; set; }
        public string identificadorformaMais30Dias { get; set; }
        public float percentualMulta { get; set; }
        public int quantidadeDiasMulta { get; set; }

        public Encargo()
        {

        }

        public Encargo(string identificadorDiasAte30Dias, float taxaPermanenciaAte30Dias, string identificadorFormaAte30Dias, string identificadorDiasMais30Dias, float taxaPermanenciaMais30Dias, string identificadorformaMais30Dias, float percentualMulta, int quantidadeDiasMulta)
        {
            this.identificadorDiasAte30Dias = identificadorDiasAte30Dias;
            this.taxaPermanenciaAte30Dias = taxaPermanenciaAte30Dias;
            this.identificadorFormaAte30Dias = identificadorFormaAte30Dias;
            this.identificadorDiasMais30Dias = identificadorDiasMais30Dias;
            this.taxaPermanenciaMais30Dias = taxaPermanenciaMais30Dias;
            this.identificadorformaMais30Dias = identificadorformaMais30Dias;
            this.percentualMulta = percentualMulta;
            this.quantidadeDiasMulta = quantidadeDiasMulta;
        }
    }
}
