using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Util
{
    internal class Utilitarios
    {
        public string GetUntilOrEmpty(string texto)
        {
            string stopAt = "-";
            if (!String.IsNullOrWhiteSpace(texto))
            {
                
                int charLocation = texto.IndexOf(stopAt, StringComparison.Ordinal);

                if (charLocation > 0)
                {
                    return texto.Substring(0, charLocation).Trim();
                }
            }

            return String.Empty;
        }
    }
}
