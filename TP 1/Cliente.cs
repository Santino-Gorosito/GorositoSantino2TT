using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public class Cliente
    {
        private int dni;
        private string nombre;
        private string telefono;
        private string mail;
        private DateTime fechaNacimiento;

        public int Dni {get { return dni;} set { dni = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Mail { get { return mail; } set { mail = value; } }

        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }

        public List<CuentaCorriente> CuentasCorrientes = new List<CuentaCorriente>();
        public List<CajaAhorro> CajasAhorro = new List<CajaAhorro>();

        public Cliente(int DNI, string NAME, string TEL, string MAIL, DateTime FNAC)
        {
            Dni = DNI;
            Nombre = NAME;
            Telefono = TEL;
            Mail = MAIL;    
            FechaNacimiento = FNAC;
        }
    }
}
