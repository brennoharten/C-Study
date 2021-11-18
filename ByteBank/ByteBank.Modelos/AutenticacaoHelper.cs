using System;

namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senha, string tentativa)
        {
            return senha == tentativa;
        }
    }
}