using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class ValidacaoStrings
    {
        public int ContarCaracteres(string? texto)
        {
            if (texto == null) return 0;

            int num = texto.Length;
            return num;
        }
    }
}