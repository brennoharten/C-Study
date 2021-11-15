using System;

namespace ByteBankConta
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            } 
            catch(Exception)
            {

            }
        }

        private static void CarregarContas()
        {
            using(LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            // --------------------------------------------------


            // LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
            // try
            // {
            //     leitor.LerProximaLinha();
            //     leitor.LerProximaLinha();
            //     leitor.LerProximaLinha();
            // }
            // catch(IOException)
            // {
            //     Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            // }
            // finally
            // {
            //     leitor.Fechar();
            // }
        }
    }
}
