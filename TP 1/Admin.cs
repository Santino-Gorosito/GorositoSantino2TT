using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public class Admin : Usuario
    {

        public Admin(int DNI, string NAME, string contraseña, string TEL, string MAIL, DateTime FC)
        {
            Dni = DNI;
            Nombre = NAME;
            Telefono = TEL;
            Mail = MAIL;
            Contraseña = contraseña;
            FechaCreacionUsuario = FC;
            Tipo = "Administrador";
        }
    }
}
