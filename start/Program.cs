using System;
using System.Collections.Generic;

namespace start
{
    class Program
    {
        static void Main(String[] args) {
           
            Queue<string> veiculos = new Queue<string>();

            veiculos.Enqueue("Carro");
            veiculos.Enqueue("mooto");
            veiculos.Enqueue("aviao");
            veiculos.Enqueue("bike");
            veiculos.Enqueue("skate");

            string primeiro = veiculos.Dequeue();
            string segundo = veiculos.Peek();

            foreach(string v in veiculos) {
                Console.WriteLine(v);
            }

            // nao se pode aplicar indexação na quee
        
            
        }
    }
}
