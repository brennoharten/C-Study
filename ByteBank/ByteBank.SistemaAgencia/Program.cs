using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 12, 17);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);

            //ContaCorrente conta = new ContaCorrente(15, 134513);

            //Console.WriteLine(conta.Numero);
        }
    }
}
