using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Model
{
    internal class Historico
    {
        public int codigoHistorico { get; set; }
        public string descricaoHistorico { get; set; }
        public string natureza {  get; set; }

        public Historico( int codigoHistorico, string descricaoHistorico, string natureza)
        {
            this.codigoHistorico = codigoHistorico;
            this.descricaoHistorico = descricaoHistorico;
            this.natureza = natureza;
        }

        public Historico() { }
    }
}
