using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Util
{
    public class GeradorCartaoVisa
    {
        private static Random random = new Random();

        public (string NumeroCartao, string CVV, DateTime DataVencimento) GerarCartaoVisa()
        {
            // Gera o número do cartão Visa com 16 dígitos
            string numeroCartao = GerarNumeroCartao();

            // Gera o CVV de 3 dígitos
            string cvv = GerarCVV();

            // Gera a data de vencimento (atual + 2 a 5 anos)
            DateTime dataVencimento = GerarDataVencimento();

            return (FormatarNumeroCartao(numeroCartao), cvv, dataVencimento);
        }

        private static string GerarNumeroCartao()
        {
            // Visa começa com 4
            string numero = "4";

            // Gera 14 dígitos aleatórios (15 no total, falta o dígito verificador)
            for (int i = 0; i < 14; i++)
            {
                numero += random.Next(0, 10).ToString();
            }

            // Adiciona o dígito verificador calculado pelo algoritmo de Luhn
            numero += CalcularDigitoLuhn(numero);

            return numero;
        }

        private static char CalcularDigitoLuhn(string numero)
        {
            int soma = 0;
            bool dobrar = true; // Dobra a cada segundo dígito, começando do penúltimo

            for (int i = numero.Length - 1; i >= 0; i--)
            {
                int digito = int.Parse(numero[i].ToString());
                if (dobrar)
                {
                    digito *= 2;
                    if (digito > 9) digito -= 9; // Subtrai 9 se o resultado for maior que 9
                }
                soma += digito;
                dobrar = !dobrar;
            }

            int resto = soma % 10;
            return resto == 0 ? '0' : ((10 - resto).ToString()[0]);
        }

        private static string GerarCVV()
        {
            // Gera um CVV de 3 dígitos (100 a 999)
            return random.Next(100, 1000).ToString();
        }

        private static DateTime GerarDataVencimento()
        {
            // Gera uma data de vencimento entre 2 e 5 anos a partir de hoje
            int anosValidade = random.Next(2, 6); // 2 a 5 anos
            return DateTime.Today.AddYears(anosValidade);
        }

        private static string FormatarNumeroCartao(string numero)
        {
            // Formata o número no padrão XXXX XXXX XXXX XXXX
            return $"{numero.Substring(0, 4)} {numero.Substring(4, 4)} {numero.Substring(8, 4)} {numero.Substring(12, 4)}";
        }

        // Método opcional para validar o número gerado
        public static bool ValidarNumeroCartao(string numero)
        {
            numero = new string(numero.Where(char.IsDigit).ToArray());

            if (numero.Length != 16 || numero[0] != '4')
                return false;

            int soma = 0;
            bool dobrar = false;

            for (int i = numero.Length - 1; i >= 0; i--)
            {
                int digito = int.Parse(numero[i].ToString());
                if (dobrar)
                {
                    digito *= 2;
                    if (digito > 9) digito -= 9;
                }
                soma += digito;
                dobrar = !dobrar;
            }

            return soma % 10 == 0;
        }
    }
}
