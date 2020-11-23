using System;
using System.Globalization;

namespace TemaHeranças
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Goku", 0.0);
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0.0, 500.0);
            // Conta para Conta Juridica
            Conta acc1 = bacc;
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.00);
            // Conta para Conta Poupança
            Conta acc3 = new ContaPoupança(1004, "Vegeta", 0.0, 0.01);
            ContaJuridica acc4 = (ContaJuridica)acc2; // Downcasting
            acc4.Emprestimo(100.0);
            // Verficar se a nova conta criada é uma Juridica ou Poupança
            if (acc3 is ContaJuridica)
            {
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }
            if (acc3 is ContaPoupança)
            {
                ContaPoupança acc5 = (ContaPoupança)acc3;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
            Console.ReadKey();
        }
    }
}
