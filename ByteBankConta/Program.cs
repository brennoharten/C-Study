using System;

namespace ByteBankConta
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 4446457);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("o parametro " + e.ParamName + "nao pode ser igual a zero");
            }
            catch(SaldoInsuficienteException e)
            {
                Console.WriteLine("Exceção do tipo saldo insuficiente");
            }
        }
    }
}
