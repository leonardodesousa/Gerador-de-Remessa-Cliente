using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Model
{
    internal class TipoTitulo
    {
        public string siglaTitpoTitulo {  get; set; }
        public string descricaoTitulo { get; set; }

        public TipoTitulo() { }

        public TipoTitulo(string siglaTitpoTitulo, string descricaoTitulo)
        {
            this.siglaTitpoTitulo = siglaTitpoTitulo;
            this.descricaoTitulo = descricaoTitulo;
        }
    }
}
