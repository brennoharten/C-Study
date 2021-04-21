using System;

namespace start
{
    class Program
    {
        enum DiasSemana{domingo, segunda, terça, quarta, quinta, sexta, sabado};
        static void Main(String[] args) {

            int num = 10;
	        Console.Write(dobrar(num));

        }

        static int dobrar(int valor) {
            return valor *= 2;
        }
    }
}
