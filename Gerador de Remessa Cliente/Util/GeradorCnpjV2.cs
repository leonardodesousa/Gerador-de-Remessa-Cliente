using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Util
{
    internal class GeradorCnpjV2
    {
        private static Random random = new Random();

        public string GerarCNPJ(bool formatar)
        {
            // Gera os 12 primeiros dígitos (8 números base + 0001 para filial)
            string cnpj = GerarNumerosBase();

            // Calcula o primeiro dígito verificador
            cnpj += CalcularDigitoVerificador(cnpj, new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 });

            // Calcula o segundo dígito verificador
            cnpj += CalcularDigitoVerificador(cnpj, new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 });

            if (formatar)
            {
                return Formatarcnpj(cnpj);
            }
            else 
            {
                return cnpj;
            }            
        }

        private static string GerarNumerosBase()
        {
            // Gera 8 dígitos aleatórios + 0001 (padrão para matriz)
            string baseNum = "";
            for (int i = 0; i < 8; i++)
            {
                baseNum += random.Next(0, 10).ToString();
            }
            return baseNum + "0001";
        }

        private static char CalcularDigitoVerificador(string numero, int[] pesos)
        {
            int soma = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                soma += int.Parse(numero[i].ToString()) * pesos[i];
            }

            int resto = soma % 11;
            return (resto < 2) ? '0' : ((11 - resto).ToString()[0]);
        }

        private static string Formatarcnpj(string cnpj)
        {
            // Formata o CNPJ no padrão XX.XXX.XXX/XXXX-XX
            return $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";
        }

        public static bool ValidarCNPJ(string cnpj)
        {
            // Remove formatação
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            if (cnpj.Length != 14 || cnpj.All(c => c == cnpj[0]))
                return false;

            string baseCnpj = cnpj.Substring(0, 12);
            string digitosOriginais = cnpj.Substring(12, 2);

            string digito1 = CalcularDigitoVerificador(baseCnpj, new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 }).ToString();
            string tempCnpj = baseCnpj + digito1;
            string digito2 = CalcularDigitoVerificador(tempCnpj, new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 }).ToString();

            return digitosOriginais == (digito1 + digito2);
        }
    }
}
