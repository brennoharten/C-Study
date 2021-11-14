using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "706.628.877-55";
            carlos.Salario = 2000.0;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Diretor roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.CPF = "706.628.847-55";
            roberta.Salario = 5000.0;

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            GerenciadorBonificacao gb = new GerenciadorBonificacao();

            gb.Registrar(carlos);
            gb.Registrar(roberta);
            Console.WriteLine(gb.GetTotalBonificacao());
            


        }
    }
}
