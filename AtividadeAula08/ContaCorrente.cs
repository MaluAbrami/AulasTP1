using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula08
{
    internal class ContaCorrente : ContaBancaria
    {
        private double taxaSaque;

        public ContaCorrente(int agencia, int conta, double saldo, string titular) : base(agencia, conta, saldo, titular)
        {
            taxaSaque = 0.05;
        }

        public override void debitarConta(double saque)
        {
            if(saque > this.Saldo)
            {
                throw new ArgumentException("Erro: valor de saque maior que o saldo em conta");
            }
            else if(saque <= 0)
            {
                throw new ArgumentException("Erro: valor de saque precisa ser maior que 0");
            }
            else
            {
                base.debitarConta(saque);
                this.Saldo = this.Saldo - (this.Saldo * taxaSaque);
                Console.WriteLine($"Taxa de saque aplicada e conta debitada com sucesso!\nNovo saldo R${this.Saldo} da conta {this.Conta} de {this.Titular}\n");
            }
        }
    }
}
