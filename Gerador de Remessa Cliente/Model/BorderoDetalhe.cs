using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Model
{
    internal class BorderoDetalhe
    {
        public string numero {  get; set; }
        public string Emissao { get; set; }
        public string Vencimento { get; set; }
        public string SeuNumero { get; set; }
        public double Valor { get; set; }
        public string DocPagador { get; set; }
        public int NumeroCobrador { get; set; }

        public BorderoDetalhe(string numero, string emissao, string vencimento, string seuNumero, double valor, string docPagador, int numeroCobrador)
        {
            this.numero = numero;
            Emissao = emissao;
            Vencimento = vencimento;
            SeuNumero = seuNumero;
            Valor = valor;
            DocPagador = docPagador;
            NumeroCobrador = numeroCobrador;
        }

        public BorderoDetalhe() { }
    }
}
