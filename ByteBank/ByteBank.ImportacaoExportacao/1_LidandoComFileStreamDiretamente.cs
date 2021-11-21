using System;
using System.IO;
using System.Text;

namespace ByteBank.ImportacaoExportacao
{
    partial class Program
    {
        static void LidandoComFileStreamDiretamente() {
            var fileAdress = ("contas.txt");

            using (var fluxoDoArquivo = new FileStream(fileAdress, FileMode.Open))
            {
                var buffer = new byte[1024]; // 1 kb
                var numeroDeBytesLidos = -1;

                while(numeroDeBytesLidos !=0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer,0,1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }
            
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;

            var text = utf8.GetString(buffer, 0, bytesLidos);

            Console.WriteLine(text);
            

            // foreach (var meuByte in buffer)
            // {
            //     Console.Write(meuByte);
            //     Console.Write(" ");
            // }
        }
    }
}
