using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2
{
    public class Cliente
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;

        #region Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public List<Paquete> Paquetes = new List<Paquete>();
        #endregion

        #region Constructores
        public Cliente(string nom, DateTime fechaNac, int dni)
        {
            Nombre = nom;
            FechaNacimiento = fechaNac;
            Dni = dni;
        }
        #endregion

        #region Métodos
        
        #endregion
    }
}
