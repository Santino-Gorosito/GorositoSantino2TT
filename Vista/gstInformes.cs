using Controlador;
using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class gstInformes : Form
    {
        public gstInformes()
        {
            InitializeComponent();
            Refresh();
        }

        public void Refresh()
        {
            dtCuentas.DataSource = null;

            dtCuentas.AutoGenerateColumns = false;

            dtCuentas.DataSource = Controladora.Instancia.ListarCuentas();
            colNumero.DataPropertyName = "Numero";
            colSaldo.DataPropertyName = "Saldo";
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (string.IsNullOrEmpty(tbDescripcionCredito.Text) || string.IsNullOrEmpty(tbMontoCredito.Text) || string.IsNullOrEmpty(tbNumeroCredito.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos del credito");
                return;
            }

            if (dtCredito.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no debe ser mayor a la actual");
                return;
            }

            decimal monto = 0;

            try
            {
                monto = Convert.ToDecimal(tbMontoCredito.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de monto invalido");
                return;
            }

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser positivo");
                return;
            }
            #endregion

            Cuenta cuenta = Controladora.Instancia.CuentaSolicitada(tbNumeroCredito.Text);

            if (cuenta == null)
            {
                MessageBox.Show("La cuenta indicada no existe");
                return;
            }
            else
            {
               
                cuenta.Saldo += monto;

               

                Movimiento movimiento = new Movimiento(cuenta.CuentaId, cuenta, dtCredito.Value, tbDescripcionCredito.Text, monto, "Credito");
                cuenta.Movimientos.Add(movimiento);

               
                try
                {
                    Controladora.Instancia.GuardarTransaccion(cuenta, movimiento);
                    MessageBox.Show("Movimiento registrado correctamente");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la transaccion");
                    // Revertir el saldo en memoria si la transacción falla
                    cuenta.Saldo -= monto;
                    cuenta.Movimientos.Remove(movimiento);
                }
            }
        }

        public void LimpiarCampos()
        {
            tbDescripcionCredito.Text = string.Empty;
            tbDescripcionDebito.Text = string.Empty;
            tbMontoCredito.Text = string.Empty;
            tbMontoDebito.Text = string.Empty;
            tbNumeroCredito.Text = string.Empty;
            tbNumeroDebito.Text = string.Empty;
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (string.IsNullOrEmpty(tbDescripcionDebito.Text) || string.IsNullOrEmpty(tbMontoDebito.Text) || string.IsNullOrEmpty(tbNumeroDebito.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos del credito");
                return;
            }

            if (dtDebito.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no debe ser mayor a la actual");
                return;
            }

            decimal monto = 0;

            try
            {
                monto = Convert.ToDecimal(tbMontoDebito.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de monto invalido");
                return;
            }

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser positivo");
                return;
            }
            #endregion

            Cuenta cuenta = Controladora.Instancia.CuentaSolicitada(tbNumeroDebito.Text);

            if (cuenta == null)
            {
                MessageBox.Show("La cuenta indicada no existe");
                return;
            }
            else
            {

                cuenta.Saldo -= monto;

                Movimiento movimiento = new Movimiento(cuenta.CuentaId, cuenta, dtCredito.Value, tbDescripcionCredito.Text, monto, "Debito");
                cuenta.Movimientos.Add(movimiento);


                try
                {
                    Controladora.Instancia.GuardarTransaccion(cuenta, movimiento);
                    MessageBox.Show("Movimiento registrado correctamente");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la transaccion");
                    // Revertir el saldo en memoria si la transacción falla
                    cuenta.Saldo += monto;
                    cuenta.Movimientos.Remove(movimiento);
                }
            }
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumeroCuenta.Text))
            {
                MessageBox.Show("Ingrese el numero de la cuenta");
                return;
            }

            Cuenta cuenta = Controladora.Instancia.CuentaSolicitada(tbNumeroCuenta.Text);

            if (cuenta == null)
            {
                MessageBox.Show("La cuenta indicada no existe");
                return;
            }
            else
            {
                ListadoMovimientos(cuenta);
                tbNumeroCuenta.Text = string.Empty;
            }
        }

        public void ListadoMovimientos(Cuenta cuenta)
        {
            dtMovimientos.DataSource = null;
            dtMovimientos.AutoGenerateColumns = false;

            dtMovimientos.DataSource = Controladora.Instancia.ListarPorCuenta(cuenta.CuentaId);
            colFecha.DataPropertyName = "Fecha";
            colMonto.DataPropertyName = "Monto";
            colTipo.DataPropertyName = "Tipo";
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumeroResumen.Text))
            {
                MessageBox.Show("Ingrese el numero de la cuenta");
                return;
            }

            Cuenta cuenta = Controladora.Instancia.CuentaSolicitada(tbNumeroResumen.Text);

            if (cuenta == null)
            {
                MessageBox.Show("La cuenta indicada no existe");
                return;
            }
            else
            {
                var creditos = cuenta.Movimientos.Where(x => x.Tipo == "Credito").Sum(x => x.Monto);
                var debitos = cuenta.Movimientos.Where(x => x.Tipo == "Debito").Sum(x => x.Monto);
                MessageBox.Show($"Creditos: {creditos} | Debitos: {debitos} | Saldo: {cuenta.Saldo}");
            }
        }
    }
}
