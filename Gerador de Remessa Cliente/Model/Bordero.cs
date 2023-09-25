using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Model
{
    internal class Bordero
    {
        int numeroLote { get; set; }
        int numeroContrato { get ; set; }

        public Bordero(int numeroLote, int numeroContrato)
        {
            this.numeroLote = numeroLote;
            this.numeroContrato = numeroContrato;
        }
    }

   
}
