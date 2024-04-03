using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Model
{
    internal class Modalidade
    {
        public string siglaModalidade {  get; set; }
        public string descricaoModalidade { get; set; }
        public string siglaEncargo {  get; set; }

        public Modalidade() { }

        public Modalidade(string siglaModalidade, string descricaoModalidade, string siglaEncargo)
        {
            this.siglaModalidade = siglaModalidade;
            this.descricaoModalidade = descricaoModalidade;
            this.siglaEncargo = siglaEncargo;
        }
    }
}
