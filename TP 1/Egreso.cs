using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public class Egreso : Movimiento
    {
        public Egreso(DateTime fecha, int imp)
        {
            Importe = imp;
            Fecha = fecha;
            Tipo = "Egreso";
            Info = $"{Tipo} | {Importe}$ | {Fecha}";
        }
    }
}
