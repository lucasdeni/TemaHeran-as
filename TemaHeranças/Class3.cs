using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace TemaHeranças
{
    class ContaPoupança : Conta
    {
        public double TaxaJuros { get; set; } // Declaração das variáveis com encapsulamento
        public ContaPoupança()
        {
            // Criação do construtor com parâmetros utilizando o da Classe Conta
        }
        public ContaPoupança(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }
        public sealed override void Saque(double saldoTotal) // Realiza o Saque
        {
            base.Saque(saldoTotal);
            _saldo -= 2.0;
        }
        public void atualizacaoSaldo() // Atualiza o Saldo
        {
            _saldo += _saldo * TaxaJuros;

        }
    }
}
