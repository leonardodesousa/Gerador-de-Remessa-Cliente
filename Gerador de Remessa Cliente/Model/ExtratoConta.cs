using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Model
{
    internal class ExtratoConta
    {        
        public DateTime dataLancamento { get; set; }
        public double valorLancado { get; set; }
        public double valorSaldo { get; set; }
        //public int codigoHistorico { get; set; }
        public string descricaoHistorico { get; set; }

        public ExtratoConta(DateTime dataLancamento, double valorLancado, double valorSaldo, /*int codigoHistorico,*/ string descricaoHistorico)
        {
            this.dataLancamento = dataLancamento;
            this.valorLancado = valorLancado;
            this.valorSaldo = valorSaldo;
            //this.codigoHistorico = codigoHistorico;
            this.descricaoHistorico = descricaoHistorico;
        }

        public ExtratoConta() { }
    }
}
