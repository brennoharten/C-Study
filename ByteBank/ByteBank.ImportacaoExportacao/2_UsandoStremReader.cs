using System;
using System.IO;
using System.Text;
using ByteBank.ImportacaoExportacao.Modelos;

namespace ByteBank.ImportacaoExportacao
{
    partial class Program
    {
        static void LerArquivo(string[] args)
        {
            var fileAdress = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(fileAdress, FileMode.Open))
            using(var leitor = new StreamReader(fluxoDoArquivo)){

                while(!leitor.EndOfStream) {
                    var linha = leitor.ReadLine();

                    var contaConrrente = ConverterArquivoCC(linha);
                    Console.WriteLine(linha);
                }

            }

            Console.ReadLine();
        }

        static ContaCorrente ConverterArquivoCC(string linha){
            var campos = linha.Split(" ");

            var agencia = int.Parse(campos[0]);
            var numero = int.Parse(campos[1]);
            var saldo = double.Parse(campos[2].Replace('.', ','));
            var nomeTitular = campos[3];

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agencia, numero);
            resultado.Depositar(saldo);
            return resultado;
        }
    }
}
