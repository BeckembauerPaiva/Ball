
using ConsoleApp1;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria Conta;
            Console.Write("Entre com o número da conta: ");
            int Num = int.Parse(Console.ReadLine());
            Console.Write( "Entre o titular da conta: " );
            string Nome=Console.ReadLine();
            Console.Write("Hávera depósito inicial (s/n):");
           
   
            char Pergunta = char.Parse(Console.ReadLine());
            if (Pergunta == 's'||Pergunta=='S') 
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double DepositoInicial=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Conta = new ContaBancaria(Num,Nome,DepositoInicial);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(Conta);
                Console.WriteLine();
                Console.Write("Entre o valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta.Deposito(deposito);
                Console.WriteLine(Conta);
                Console.WriteLine();
                Console.Write("Entre com o valor para saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta.Saque(saque);
                Console.WriteLine(Conta);

            }
            else if (Pergunta=='n'||Pergunta=='N')

            {
                double DepositoInicial= 0;
                Conta = new ContaBancaria(Num, Nome, DepositoInicial);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(Conta);
                Console.WriteLine();
                Console.Write("Entre o valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta.Deposito(deposito);
                Console.WriteLine(Conta);
                Console.WriteLine();
                Console.Write("Entre com o valor para saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta.Saque(saque);
                Console.WriteLine(Conta);



            }
            








        }
    }
}