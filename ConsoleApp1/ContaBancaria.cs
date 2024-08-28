using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    internal class ContaBancaria
    {
        public int NumeroDaConta {  get;private set; }
        public string TitularDaConta { get; set; }
        public double SaldoDaConta { get;private set; }

        public ContaBancaria(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
        }
        public double Deposito(double valor)
        {
            return SaldoDaConta += valor;
        }
        public double Saque(double valor)
        {
            return SaldoDaConta -= valor-5.00;
        }
       

        public ContaBancaria(int numeroDaConta, string titularDaConta, double saldoDaConta) : this(numeroDaConta, titularDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }
        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + TitularDaConta
                + ", Saldo: $ "
                + SaldoDaConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
