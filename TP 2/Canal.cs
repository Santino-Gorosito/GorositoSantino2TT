using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_2;

namespace TP_2
{
    public class Canal
    {
        private string nombre;
        
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<Serie> Series = new List<Serie>();

        public Canal(string nom, List<Serie> ser)
        {
            Nombre = nom;
            Series = ser;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
