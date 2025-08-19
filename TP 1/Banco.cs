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

        public Usuario buscarUsuarioPorDNI(int dni)
        {
            Usuario usuario = Usuarios.FirstOrDefault(c => c.Dni == dni);
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

        public Cuenta obtenerCuenta(int num)
        {
            Cuenta cuenta = Cuentas.FirstOrDefault(c => c.Codigo == num);
            return cuenta;
        }

        public void EliminarClientesSinCuentas()
        {
            foreach (Cliente c in Usuarios)
            {
                if (c.CuentasCorrientes.Count == 0 && c.CajasAhorro.Count == 0)
                {
                    Usuarios.Remove(c);
                }
            }
        }

        public void EliminarCuentas()
        {
            foreach(Cliente c in Usuarios)
            {
                var cuentasCSinSaldo = c.CuentasCorrientes.Where(c => c.Saldo == 0).ToList();
                var cajasSinSaldo = c.CajasAhorro.Where(c => c.Saldo == 0).ToList();

                foreach (var cuenta in cuentasCSinSaldo)
                {
                    
                    c.CuentasCorrientes.Remove(cuenta);
                    Cuentas.Remove(cuenta);
                }

                foreach (var caja in cajasSinSaldo)
                {

                    c.CajasAhorro.Remove(caja);
                    Cuentas.Remove(caja);
                }
            }
           
        }
    }
}
