using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public abstract class Cuenta
    {
        private Cliente titular;
        private int codigo;
        private int saldo;

        public Cliente Titular { get { return titular; } set { titular = value; } }
        public int Codigo { get { return codigo; } set { codigo = value; } }

        public int Saldo { get { return saldo; } set { saldo = value; } }

        public abstract bool Extraer(int monto);
        public void Ingresar(int monto)
        {
            saldo += monto;
        }
    }
}
