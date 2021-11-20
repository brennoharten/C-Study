using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public class ExtractUrl
    {
        public Dictionary<string, string> Argumentos = new Dictionary<string, string>();
        public string Url { get; }
        public ExtractUrl(string url)
        {
            if (String.IsNullOrEmpty(url)) {
                throw new ArgumentException("O argumetno não pode ser nulo ou vazio");
            } 

            // int indexInterrogacao = url.IndexOf("?");
            
            // //imutabilidade da substrinf que é uma fatia da string
            // string subs = url.Substring(indexInterrogacao,9);

            string[] arrayURL = url.Split("?");

            for (int i = 1; i < arrayURL.Length; i++) {
                ExtractArgument(arrayURL[i]);
            }

            Url = url;
        }

        public void ExtractArgument(String argumento) {
            int start = argumento.IndexOf("=") + 1;
            string key = argumento.Substring(0, start -1);
            string valor = argumento.Substring(start);

            Argumentos.Add(key, valor);
        }
    }
}
