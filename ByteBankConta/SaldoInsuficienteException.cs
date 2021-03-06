using System;

namespace ByteBankConta
{
    class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo {get;}
        public double ValorSaque {get;}
        public SaldoInsuficienteException(string message) : base(message)
        {
            
        }
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("tentativa de saque no valor de: " + valorSaque + ", com o saldo de: " + saldo) 
            // poderia ser também : base("namnamna")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException() 
        {

        }
        public SaldoInsuficienteException(string message, Exception exceptionInner) : base(message, exceptionInner)
        {
            
        }
    }
    
}