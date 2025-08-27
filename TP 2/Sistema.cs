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

        public void AgregarSerie(Serie serie)
        {
            Series.Add(serie);
        }

        public void EliminarSerie(Serie serie)
        {
            Series.Remove(serie);
        }

        public bool ExisteSerie(string nombre)
        {
            Serie serie = Series.FirstOrDefault(c => c.Nombre == nombre);

            if (serie == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ExisteCanal(string nombre) {
            Canal canal = Canales.FirstOrDefault(c => c.Nombre ==  nombre);

            if (canal == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public void AgregarCanal(Canal canal)
        {
            Canales.Add(canal);
        }

        public void EliminarCanal(Canal canal)
        {
            Canales.Remove(canal);
        }

        public Canal DevolverCanal(string nombre)
        {
            return Canales.FirstOrDefault(c => c.Nombre == nombre);
        }

        public bool ExistePaquete(string nombre) {
            Paquete paquete = Paquetes.FirstOrDefault(c => c.Nombre == nombre);

            if (paquete == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public void AgregarPaquete(Paquete paquete)
        {
            Paquetes.Add(paquete);
        }

        public void EliminarPaquete(Paquete paquete)
        {
            Paquetes.Remove(paquete);
        }
    }
}
