using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(458,455755);
            
            Console.WriteLine(conta.Saldo);
        }
    }
}
