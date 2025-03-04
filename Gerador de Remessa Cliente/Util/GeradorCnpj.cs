using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Util
{
    public class GeradorCnpj
    {
        public string GerarCnpjValido()
        {
            Random random = new Random();
            int[] baseNumbers = new int[12];

            // Gerar os primeiros 8 dígitos
            for (int i = 0; i < 8; i++)
            {
                baseNumbers[i] = random.Next(0, 10);
            }

            // Adicionar 4 dígitos fixos (0001)
            baseNumbers[8] = 0;
            baseNumbers[9] = 0;
            baseNumbers[10] = 0;
            baseNumbers[11] = 1;

            // Calcular os dígitos verificadores
            int firstDigit = CalcularCnpjDigito(baseNumbers);
            int secondDigit = CalcularCnpjDigito(baseNumbers, firstDigit);

            // Montar o CNPJ completo
            string cnpj = string.Format("{0:D2}.{1:D3}.{2:D3}/{3:D4}-{4:D2}",
                CombineToInteger(baseNumbers, 0, 1),
                CombineToInteger(baseNumbers, 2, 4),
                CombineToInteger(baseNumbers, 5, 7),
                CombineToInteger(baseNumbers, 8, 11),
                firstDigit * 10 + secondDigit);

            return cnpj;
        }

        private static int CalcularCnpjDigito(int[] baseNumbers, int firstDigit = -1)
        {
            int[] weights = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum = 0;

            for (int i = 0; i < 12; i++)
            {
                sum += baseNumbers[i] * weights[i + (firstDigit == -1 ? 0 : 1)];
            }

            int remainder = sum % 11;
            return remainder < 2 ? 0 : 11 - remainder;
        }

        private static int CombineToInteger(int[] baseNumbers, int start, int end)
        {
            int number = 0;
            for (int i = start; i <= end; i++)
            {
                number = number * 10 + baseNumbers[i];
            }
            return number;
        }

    }
}
