using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Model
{
    internal class Conta
    {
        public string numeroConta {  get; set; }
        public long codigoCliente { get; set; }
        public string nome { get; set; }
        public DateTime dataEncerramento { get; set; }
        public double saldoDisponivel { get; set; }
        public double saldoBloqueado { get; set; }
        public double saldoBloqueadoJudAdm { get; set; }

        public Conta() { }

        public Conta(string numeroConta, long codigoCliente, string nome, DateTime dataEncerramento, double saldoDisponivel, double saldoBloqueado, double saldoBloqueadoJudAdm)
        {
            this.numeroConta = numeroConta;
            this.codigoCliente = codigoCliente;
            this.nome = nome;
            this.dataEncerramento = dataEncerramento;
            this.saldoDisponivel = saldoDisponivel;
            this.saldoBloqueado = saldoBloqueado;
            this.saldoBloqueadoJudAdm = saldoBloqueadoJudAdm;
        }
    }
}
