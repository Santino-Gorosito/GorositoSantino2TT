using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public class CajaAhorro : Cuenta
    {
        private const int MAXIMOEXT = 500000;

        public CajaAhorro(Cliente cliente, int num)
        {
            Titular = cliente;
            Codigo = num;
            Saldo = 0;
        }
        public override void Extraer(int monto)
        {
            if (monto > MAXIMOEXT)
            {
                Console.WriteLine("No se puede exceder el maximo de extraccion");
                return;
            }
            else
            {
                Saldo -= monto;
            }
        }
    }
}
