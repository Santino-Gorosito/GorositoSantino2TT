using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Modelo
{
    public class Context : DbContext
    {
        private string con = "Data Source=DESKTOP-FPDJKD9\\SQLEXPRESS;Initial Catalog=CuentasClientes;Persist Security Info=False;User ID=sa;Password=12345678;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=True;Command Timeout=0";
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta> CuentaCorrientes { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(con);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración explícita para que MovimientoId sea autogenerado
            modelBuilder.Entity<Movimiento>()
                .Property(m => m.MovimientoId)
                .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}
