using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Util
{
    internal class GeradorCPF
    {
        private static Random random = new Random();

        public string GerarCPF(bool formatar)
        {
            // Gera os 9 primeiros dígitos aleatórios
            string cpf = GerarNumerosBase();

            // Calcula o primeiro dígito verificador
            cpf += CalcularDigitoVerificador(cpf, 10);

            // Calcula o segundo dígito verificador
            cpf += CalcularDigitoVerificador(cpf, 11);

            if (formatar == true) 
            {
                return Formatarcpf(cpf); 
            } 
            else 
            {  
                return cpf; 
            }
            
        }
        private static string GerarNumerosBase()
        {
            string baseNum = "";
            for (int i = 0; i < 9; i++)
            {
                baseNum += random.Next(0, 10).ToString();
            }
            return baseNum;
        }

        private static char CalcularDigitoVerificador(string numero, int pesoInicial)
        {
            int soma = 0;
            int peso = pesoInicial;

            for (int i = 0; i < numero.Length; i++)
            {
                soma += int.Parse(numero[i].ToString()) * peso--;
            }

            int resto = soma % 11;
            return (resto < 2) ? '0' : ((11 - resto).ToString()[0]);
        }

        private static string Formatarcpf(string cpf)
        {
            // Formata o CPF no padrão XXX.XXX.XXX-XX
            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
        }
        public static bool ValidarCPF(string cpf)
        {
            // Remove formatação
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
                return false;

            string baseCpf = cpf.Substring(0, 9);
            string digitosOriginais = cpf.Substring(9, 2);

            string digito1 = CalcularDigitoVerificador(baseCpf, 10).ToString();
            string tempCpf = baseCpf + digito1;
            string digito2 = CalcularDigitoVerificador(tempCpf, 11).ToString();

            return digitosOriginais == (digito1 + digito2);
        }
    }
}
