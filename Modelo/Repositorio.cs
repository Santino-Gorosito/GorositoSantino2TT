using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Modelo
{
    public class Repositorio
    {
        private Context context;

        public Repositorio()
        {
            context = new Context();
        }


        #region Cliente
        public IReadOnlyCollection<Cliente> ListarCliente()
        {
            return context.Clientes.ToList().AsReadOnly();
        }

        public void AgregarCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public void ModificarCliente(Cliente cliente)
        {
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }

        public void EliminarCliente(Cliente cliente)
        {
            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }

        #endregion

        #region Cuenta

        public IReadOnlyCollection<Cuenta> ListarCuentas()
        {
   
            return context.CuentaCorrientes
                          .Include(c => c.Movimientos) 
                          .ToList().AsReadOnly();
        }

        public IReadOnlyCollection<Cuenta> ListarCuentasPorCliente(int clienteId)
        {
            return context.CuentaCorrientes.Where(x => x.ClienteId == clienteId).ToList().AsReadOnly();
        }

        public void AgregarCuenta(Cuenta cuentaCorriente)
        {
            context.CuentaCorrientes.Add(cuentaCorriente);
            context.SaveChanges();
        }

        public void ModificarCuenta(Cuenta cuentaCorriente)
        {
            context.CuentaCorrientes.Update(cuentaCorriente);
            context.SaveChanges();
        }

        public void EliminarCuenta(Cuenta cuentaCorriente)
        {
            context.CuentaCorrientes.Remove(cuentaCorriente);
            context.SaveChanges();
        }

        #endregion

        #region Movimiento

        public IReadOnlyCollection<Movimiento> ListarMovimientos()
        {
            return context.Movimientos.OrderBy(x => x.Fecha).ToList().AsReadOnly();
        }

        public IReadOnlyCollection<Movimiento> ListarPorCuenta(int idCuenta)
        {
            return context.Movimientos.Where(x => x.CuentaId == idCuenta).OrderBy(x => x.Fecha).ToList().AsReadOnly();
        }

        public void AgregarMovimiento(Movimiento movimiento)
        {
            context.Movimientos.Add(movimiento);
            context.SaveChanges();
        }

        #endregion
    }
}
