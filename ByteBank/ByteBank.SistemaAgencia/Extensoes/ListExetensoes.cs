using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListaExtensoes //Nao se pode ter uma classe de extensão generica, em uma classe estatica
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens){ // Mas da pra ter um método generico tranquilo

            foreach(T iten in itens)
            {
                lista.Add(iten);
            }
        }

    }
}
