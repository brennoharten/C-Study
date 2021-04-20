using System;

namespace start
{
    class Program
    {
        static void Main(String[] args) {

            int opcao;

            Console.WriteLine("Selecione uma opção ");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - para desbloqueio");
            Console.WriteLine("--------------------");
            Console.WriteLine("2 - para bloqueio   ");
            Console.WriteLine("--------------------");
            Console.WriteLine("3 - para cédito     ");
            Console.WriteLine("--------------------");
            Console.WriteLine("4 - para sair       ");
            Console.WriteLine("--------------------");

            opcao = int.Parse(Console.ReadLine());

            switch(opcao)  {
                case 1: 
                {
                    Console.WriteLine("cartao desbloqueado");
                    break;
                } 
                case 2: 
                {
                    Console.WriteLine("cartao bloqueado");
                    break;
                }
                case 3: 
                {
                    Console.WriteLine("credito solicitado");
                    break;
                }
                case 4: 
                {
                    Console.Clear();
                    Console.WriteLine("Volte sempre");
                    break;
                }
                default: 
                {
                    Console.WriteLine("Opção não existe");
                    break;
                }

            }
        }
    }
}
