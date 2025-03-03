using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Model
{
    internal class Configuracao
    {
        public bool SalvaConfiguracaoModalidade(string modalidade, string siglaTipoTitulo )
        {
            bool resultado = false;            

            String path = @"C:\TotalBanco\Crediblaster\GeraRem\modalidade.dll";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("modalidade=" + modalidade.ToString());
                sw.WriteLine("siglaTipoTitulo=" + siglaTipoTitulo.ToString());
                resultado = true;
            }

            return resultado;

        }
    }
}
