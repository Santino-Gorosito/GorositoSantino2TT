using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP_2
{
    public abstract class Paquete
    {
        private string nombre;
        public const decimal valorBase = 15000;
        private decimal valorFinal;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public decimal ValorFinal { get { return valorFinal; } set { valorFinal = value; } }
        public List<Canal> Canales = new List<Canal>();

        public abstract void calculoValorFinal();
    }
}
