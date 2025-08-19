using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public abstract class Usuario
    {
        private int dni;
        private string nombre;
        private string telefono;
        private string mail;
        private DateTime fechaNacimiento;
        private string contraseña;
        private DateTime fechaCreacionUsuario;
        private string tipo;

        public int Dni { get { return dni; } set { dni = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }

        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public DateTime FechaCreacionUsuario { get { return fechaCreacionUsuario; } set { fechaCreacionUsuario = value; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }

        
    }
}
