using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public class CuentaCorriente : Cuenta
    {
        private const int TOPE = -100000;

        public CuentaCorriente(Cliente cliente, int num)
        {
            Titular = cliente;
            Codigo = num;
            Saldo = 0;
        }
        public override bool Extraer(int monto)
        {
            if ((Saldo -= monto) < TOPE)
            {
                Console.WriteLine("No se puede exceder el tope de extraccion descubierto");
                return false;
            } else
            {
                Saldo -= monto;
                return true;
            }
        }
    }
}
