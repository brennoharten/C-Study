using System;

namespace ByteBankConta
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
        
        public int Numero { get; }
        public int Agencia{ get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0) 
            {
                throw new ArgumentException("A agencia deve ser maiores qeu zero", nameof(agencia));

            }
            if (numero <= 0)
            {
                throw new ArgumentException("O numero deve ser maiores qeu zero", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 /TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if (valor < 0) {
                throw new ArgumentException("argumento com problema:", nameof(valor));
            }
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(_saldo, valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            try 
            {
                Sacar(valor);
                contaDestino.Depositar(valor);
            } catch (Exception ex)
            {
                throw new OperacaoFinanceiraException("Operação não realizada!", ex);
            }
        }
    }
}
