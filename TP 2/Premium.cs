using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2
{
    public class Premium : Paquete
    {

        public Premium(string nom, List<Canal> canales)
        {
            Nombre = nom;
            Canales = canales;
            calculoValorFinal();
        }

        public override void calculoValorFinal()
        {
            ValorFinal = valorBase * 1.20m;
        }
    }
}
