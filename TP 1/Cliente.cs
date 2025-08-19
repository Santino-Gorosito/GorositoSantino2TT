using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public class Cliente : Usuario
    {
        public List<CuentaCorriente> CuentasCorrientes = new List<CuentaCorriente>();
        public List<CajaAhorro> CajasAhorro = new List<CajaAhorro>();

        public Cliente(int DNI, string NAME, string contraseña, string TEL, string MAIL, DateTime FNAC, DateTime FC)
        {
            Dni = DNI;
            Nombre = NAME;
            Telefono = TEL;
            Mail = MAIL;
            FechaNacimiento = FNAC;
            Contraseña = contraseña;
            FechaCreacionUsuario = FC;
            Tipo = "Cliente";
        }

    }
}
