using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2
{
    public class Sistema
    {
        public List<Paquete> Paquetes = new List<Paquete>();
        public List<Cliente> Clientes = new List<Cliente>();
        public List<Serie> Series = new List<Serie>();
        public List<Canal> Canales = new List<Canal>();

        public bool ExisteDni(int dni)
        {
            Cliente cliente = Clientes.FirstOrDefault(c => c.Dni == dni);

            if (cliente == null)
            {
                return false;
            } else
            {
                return true;
            }
        }


        public void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void EliminarCliente(Cliente cliente)
        {
            Clientes.Remove(cliente);
        }
    }
}
