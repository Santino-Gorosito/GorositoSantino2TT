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
        public IReadOnlyCollection<Cliente> Listar()
        {
            return repo.ListarCliente();
        }

        public void AgregarCliente(Cliente cliente)
        {
            repo.AgregarCliente(cliente);
        }

        public void Modificar(Cliente cliente)
        {
            repo.ModificarCliente(cliente);
        }

        public void Eliminar(Cliente cliente)
        {
            repo.EliminarCliente(cliente);
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


        public void Agregar(Movimiento movimiento)
        {
            repo.AgregarMovimiento(movimiento);
        }

        #endregion
    }
}
