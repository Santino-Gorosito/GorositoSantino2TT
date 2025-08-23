using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2
{
    public class Silver : Paquete
    {
        public Silver(string nom, List<Canal> canales)
        {
            Nombre = nom;
            Canales = canales;
            calculoValorFinal();
        }

        public override void calculoValorFinal()
        {
            ValorFinal = valorBase * 1.15m;
        }
    }
}
