using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public class Banco
    {
        public List<Usuario> Usuarios = new List<Usuario>();
        public List<Cuenta> Cuentas = new List<Cuenta>();
        public List<Movimiento> Movimientos = new List<Movimiento>();

        public Usuario buscarUsuarioPorNombre(string nombre)
        {
            Usuario usuario = Usuarios.FirstOrDefault(c => c.Nombre == nombre);
            return usuario;  
        }

        public bool existeDni(int dni)
        {
            bool existe = false;

            Usuario usuariocDNI = Usuarios.FirstOrDefault(c => c.Dni == dni);
            
            if (usuariocDNI == null)
            {
                return existe;
            } else
            {
                return existe = true;
            }
        }

        public void agregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void agregarCuenta(Cuenta cuenta)
        {
            Cuentas.Add(cuenta);
        }
    }
}
