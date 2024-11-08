using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca cp = new ContaPoupanca(1111, 123, 1500, "Malu");
            ContaCorrente cc = new ContaCorrente(1111, 123, 1500, "Malu");

            Console.WriteLine($"Agência: {cp.Agencia}");
            Console.WriteLine($"Conta: {cp.Conta}");
            Console.WriteLine($"Saldo: {cp.Saldo}");
            Console.WriteLine($"Titular da Conta: {cp.Titular}\n");

            Console.WriteLine($"Agência: {cc.Agencia}");
            Console.WriteLine($"Conta: {cc.Conta}");
            Console.WriteLine($"Saldo: {cc.Saldo}");
            Console.WriteLine($"Titular da Conta: {cc.Titular}\n");

            cp.creditarConta(200);

            cc.debitarConta(200);
        }
    }
}
