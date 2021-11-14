using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario("706.628.877-55");

            carlos.Nome = "Carlos";
            carlos.Salario = 2000.0;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Diretor roberta = new Diretor("706.628.847-55");

            roberta.Nome = "Roberta";
            roberta.Salario = 5000.0;

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            GerenciadorBonificacao gb = new GerenciadorBonificacao();

            gb.Registrar(carlos);
            gb.Registrar(roberta);
            Console.WriteLine(gb.GetTotalBonificacao());
            
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
        }
    }
}
