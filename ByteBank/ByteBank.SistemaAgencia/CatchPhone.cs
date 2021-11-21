using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class CatchPhone
    {
        public string CatchPhoneMetodo(string frase)
        { 
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string novoPadrao = "[0-9]{4}[-][0-9]{4}";
            // string novoPadrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}"; //caso tenha 5 digitos antes do hifen e caso tenha o hifen ou nao
            // string novoPadrao = "[0-9]{4,5}-[0-9]{4}"; //forma reduzida
            string padrao = "[0-9]{4,5}-?[0-9]{4}"; //melhor forma
            string textoDeTeste = "ajgdjgjagsygaugsa 8751-5456 aygsygsygua auyakjskjs";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            return resultado.Value;
            
        }
    }
}
