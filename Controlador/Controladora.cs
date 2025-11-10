using Modelo;
using Entidades;
namespace Controlador
{
    public class Controladora
    {
        private Repositorio repo = new Repositorio();
        private static Controladora instancia;

        public static Controladora Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora();
                }
                return instancia;
            }
        }

        #region Cliente
        public IReadOnlyCollection<Cliente> ListarCliente()
        {
            return repo.ListarCliente();
        }

        public void AgregarCliente(Cliente cliente)
        {
            repo.AgregarCliente(cliente);
        }

        public void ModificarCliente(Cliente cliente)
        {
            repo.ModificarCliente(cliente);
        }

        public void EliminarCliente(Cliente cliente)
        {
            repo.EliminarCliente(cliente);
        }

        public bool existeDni(string dni)
        {
            IReadOnlyCollection<Cliente> clientes = repo.ListarCliente();
            Cliente cliente = clientes.FirstOrDefault(c => c.DNI == dni);

            if (cliente == null)
            {
                return false;
            } else
            {
                return true;
            }
        }
        #endregion

        #region Cuenta
        public IReadOnlyCollection<Cuenta> ListarCuentas()
        {
            return repo.ListarCuentas();
        }

        public IReadOnlyCollection<Cuenta> ListarPorCliente(int clienteId)
        {
            return repo.ListarCuentasPorCliente(clienteId);
        }

        public void AgregarCuenta(Cuenta cuenta)
        {
            repo.AgregarCuenta(cuenta);
        }

        public bool ExisteCuenta(string num)
        {
            IReadOnlyCollection<Cuenta> cuentas = repo.ListarCuentas();
            Cuenta cuenta = cuentas.FirstOrDefault(c => c.Numero == num);

            if (cuenta == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public void ActualizarCuenta(Cuenta cuenta)
        {
            repo.ModificarCuenta(cuenta);
        }

        public Cuenta CuentaSolicitada(string num)
        {
            IReadOnlyCollection<Cuenta> cuentas = repo.ListarCuentas();
            return cuentas.FirstOrDefault(c => c.Numero == num);
        }
        #endregion

        #region Movimiento
        public IReadOnlyCollection<Movimiento> ListarMovimientos()
        {
            return repo.ListarMovimientos();
        }

        public IReadOnlyCollection<Movimiento> ListarPorCuenta(int cuentaId)
        {
            return repo.ListarPorCuenta(cuentaId);
        }


  
        public void GuardarTransaccion(Cuenta cuenta, Movimiento movimiento)
        {
            using (var context = new Modelo.Context())
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.CuentaCorrientes.Update(cuenta);
                    context.Movimientos.Add(movimiento);

                 
                    context.Entry(movimiento).Property(m => m.MovimientoId).IsTemporary = true;

                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        #endregion
    }
}
