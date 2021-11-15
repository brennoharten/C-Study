using System;

namespace ByteBankConta
{
    public class LeitorDeArquivo : IDisposable
    {
            public string Arquivo { get; }

            public LeitorDeArquivo(string arquivo)
            {
                    Arquivo = arquivo;
                    Console.WriteLine("Abrindo arquivo: " + arquivo);
            }

            public string LerProximaLinha()
            {
                    Console.WriteLine("Lendo linha...");
                    return "Linha do arquivo";
            }

            public void Dispose() {
                Console.WriteLine("Fechando arquivo.");
            }
    }
}
