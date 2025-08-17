using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    public class Banco
    {
        public List<Cliente> Clientes = new List<Cliente>();
        public List<Cuenta> Cuentas = new List<Cuenta>();
        public List<Movimiento> Movimientos = new List<Movimiento>();

        public Cliente buscarUsuarioPorNombre(string nombre)
        {
            Cliente usuario = Clientes.FirstOrDefault(c => c.Nombre == nombre);
            return usuario;  
        }

        public bool existeDni(int dni)
        {
            bool existe = false;

            Cliente usuariocDNI = Clientes.FirstOrDefault(c => c.Dni == dni);
            
            if (usuariocDNI == null)
            {
                return existe;
            } else
            {
                return existe = true;
            }
        }

        public void agregarUsuario(Cliente usuario)
        {
            Clientes.Add(usuario);
        }
    }
}
