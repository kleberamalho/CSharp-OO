using System;
using BangBank;
using BangBank.Titular;

namespace BangBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas Vindas ao seu banco, BangBank");

            //ContaCorrente conta1 = new ContaCorrente();
            //conta1.titular = "Kleber Ramalho";
            //conta1.conta = "10662-x";
            //conta1.numero_agencia = 52;
            //conta1.nome_agencia = "Agencia Central";
            //conta1.saldo = 100;

            //ContaCorrente conta2 = new ContaCorrente();
            //conta2.titular = "Leticia lima";
            //conta2.conta = "10291-3";
            //conta2.numero_agencia = 22;
            //conta2.nome_agencia = "Agencia Pirapora";
            //conta2.saldo = 100;

            //Console.WriteLine("Saldo da Leticia pré-saque: " + conta2.saldo);
            //bool saque = conta2.Sacar(50);
            //Console.WriteLine("Saque realizado? " +saque);            

            //Console.WriteLine("Saldo da Leticia pós-saque: " + conta2.saldo);

            //Console.WriteLine("Saldo da Leticia pós-depósito: " + conta2.saldo);

            //Console.WriteLine(conta1 == conta2);

            //Cliente cliente = new Cliente();
            //cliente.nome = "Jão Cloud";
            //cliente.cpf = "123456789";
            //cliente.profissao = "Programador";


            //ContaCorrente conta3 = new ContaCorrente();
            //conta3.titular = new Cliente();
            //conta3.titular.nome = "Renan";
            //conta3.titular.profissao = "lider Tecnico";
            //conta3.titular.cpf = "9874563";
            //conta3.conta = "10281-4";
            //conta3.numero_agencia = 39;
            //conta3.nome_agencia = "Agencia Centro";

            //Console.WriteLine(conta3.titular.nome);

            //if(conta3.titular == null)
            //{
            //    Console.WriteLine("Campo titular esta nulo.");
            //}

            //Console.ReadKey();

            Cliente sarah = new Cliente();

            ContaCorrente conta4 = new ContaCorrente();

            conta4.Saldo = 100;
            conta4.Titular = sarah;

            Console.WriteLine("Saldo: " +conta4.Saldo);

            Console.ReadKey();

            /*Parei mod 06.Construtores continuar Método construtor 11min*/

        }
    }
}
