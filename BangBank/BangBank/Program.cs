using System;
using BangBank;

namespace BangBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas Vindas ao seu banco, BangBank");

            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "Kleber Ramalho";
            conta1.conta = "10662-x";
            conta1.numero_agencia = 52;
            conta1.nome_agencia = "Agencia Central";
            conta1.saldo = 100;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Leticia lima";
            conta2.conta = "10291-3";
            conta2.numero_agencia = 22;
            conta2.nome_agencia = "Agencia Pirapora";
            conta2.saldo = 100;

            Console.WriteLine("Saldo da Leticia pré-saque: " + conta2.saldo);
            bool saque = conta2.Sacar(50);
            Console.WriteLine("Saque realizado? " +saque);            
            
            Console.WriteLine("Saldo da Leticia pós-saque: " + conta2.saldo);

            Console.WriteLine("Saldo da Leticia pós-depósito: " + conta2.saldo);

            Console.WriteLine(conta1 == conta2);

            Console.ReadKey();

        }
    }
}
