using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public abstract class Movimiento
    {
        private string tipo;
        private DateTime fecha;
        private int importe;
        private string info;

        public string Tipo { get { return tipo; } protected set { tipo = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int Importe { get { return importe; } set { importe = value; } }
        public string Info { get { return info; } protected set { info = value; } }

    }
}
