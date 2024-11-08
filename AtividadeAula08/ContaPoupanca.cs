using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula08
{
    internal class ContaPoupanca : ContaBancaria
    {
        private double taxaJuros;

        public ContaPoupanca(int agencia, int conta, double saldo, string titular) : base(agencia, conta, saldo, titular)
        {
            taxaJuros = 1.10;
        }

        public override void creditarConta(double v)
        {
            if (v <= 0)
            {
                throw new ArgumentException("Erro ao creditar: valor inválido");
            }
            else
            {
                base.creditarConta(v);
                this.Saldo *= taxaJuros;
                Console.WriteLine($"Conta creditada com sucesso!\nNovo saldo R${this.Saldo} da conta {this.Conta} de {this.Titular}\n");
            }
        }
    }
}
