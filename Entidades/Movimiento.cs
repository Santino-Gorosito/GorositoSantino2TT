using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Movimiento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovimientoId {  get; set; }
        public int CuentaId { get; set; }
        public Cuenta Cuenta { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public string Tipo { get; set; }

        public Movimiento() { }

        public Movimiento(int cuentaId, Cuenta cuenta, DateTime fecha, string descripcion, decimal monto, string tipo)
        {
            CuentaId = cuentaId;
            Cuenta = cuenta;
            Fecha = fecha;
            Descripcion = descripcion;
            Monto = monto;
            Tipo = tipo;
        }
    }
}
