using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace TemaHeranças
{
    class Conta
    {
        // Declaração da variaveis com encapsulamento
        public int _numero { get; private set; }
        public string _titular { get; private set; }
        public double _saldo { get; protected set; } // utilização do protected para alteração de valores entre classes
        public Conta() 
        {
            // Criação do construtor com parâmetros 
        }
        public Conta(int numero, string titular, double saldo)
        {       
            _numero = numero;
            _titular = titular;
            _saldo = saldo;
        }
        public virtual void Saque(double saldoTotal) // Realiza o Saque
        {
            _saldo -= saldoTotal;
        }
        public void Deposito(double saldoTotal) // Realiza o Depósito
        {
            _saldo += saldoTotal;
        }
    }
}
