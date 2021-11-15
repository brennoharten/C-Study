using System;

namespace ByteBankConta
{
    class OperacaoFinanceiraException : Exception
    {
        public double Saldo {get;}
        public double ValorSaque {get;}
        public OperacaoFinanceiraException(string message, Exception exceptionInner) : base(message, exceptionInner)
        {
            
        }
        public OperacaoFinanceiraException(string message) : base(message)
        {
            
        }
        public OperacaoFinanceiraException(double saldo, double valorSaque)
            : this("tentativa de saque no valor de: " + valorSaque + ", com o saldo de: " + saldo) 
            // poderia ser também : base("namnamna")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public OperacaoFinanceiraException() 
        {

        }
    }
    
}