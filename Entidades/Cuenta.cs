using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        public int CuentaId {  get; set; }
        public string Numero {  get; set; }
        public int ClienteId { get; set; }
        public decimal Saldo { get; set; }
        public Cliente Cliente { get; set; }
        public List<Movimiento> Movimientos { get; set; }

        public Cuenta() { }

        public Cuenta(string numero, int clienteId, Cliente cliente)
        {
            Numero = numero;
            ClienteId = clienteId;
            Cliente = cliente;
            Movimientos = new List<Movimiento>();
            Saldo = 0;
        }
    }
}
