using System;
using System.IO;
using System.Text;
using ByteBank.ImportacaoExportacao.Modelos;

namespace ByteBank.ImportacaoExportacao
{
    partial class Program
    {
        static void Main()
        {

            File.WriteAllText("escrevendoComAClasseFile.txt", "coloco aqui oq eu quiser");
            //lendo todo o arquivo de uma vez , fazendo um Array 
            var linhas = File.ReadAllLines("contas.txt");
            
        }

        static void CriatArquivoComWriter() {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDoArquivo)){
                escritor.Write("456,787245,4730.50,Gustavo Santos");
            }
        }

        static void CriarArquivoComByte(){
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create)){
                var contaComoString = "456,787245,4730.50,Gustavo Santos";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDoArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriatArquivoComWriterEFlush() {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDoArquivo)){
                for (int i = 0; i < 1000000; i++)
                {
                    escritor.Write($"Linha {i}");

                    escritor.Flush();  //Despeja o buffer para o Stream!
                    Console.ReadLine();

                }
            }
        }
    }
}
