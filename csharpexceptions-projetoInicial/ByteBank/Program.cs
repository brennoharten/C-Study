using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 0);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("o parametro " + e.ParamName + "nao pode ser igual a zero");
            }
        }
    }
}
