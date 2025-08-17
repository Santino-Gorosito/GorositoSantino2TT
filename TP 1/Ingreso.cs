using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public class Ingreso : Movimiento
    {
       public Ingreso(DateTime fecha, int imp) {
            Importe = imp;
            Fecha = fecha;
            Tipo = "Ingreso";
            Info = $"{Tipo} | {Importe}$ | {Fecha}";
       }
    }
}
