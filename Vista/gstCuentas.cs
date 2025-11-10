using Controlador;
using Entidades;
using System;
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
    public partial class gstCuentas : Form
    {
        public gstCuentas()
        {
            InitializeComponent();
            cbCliente.DataSource = Controladora.Instancia.ListarCliente();
            cbCliente.DisplayMember = "DNI";
            cbCliente.ValueMember = "DNI";
            Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumeroCuenta.Text) || cbCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            Cliente cliente = (Cliente)cbCliente.SelectedItem;

            bool existeCuenta = Controladora.Instancia.ExisteCuenta(tbNumeroCuenta.Text);

            if (existeCuenta)
            {
                MessageBox.Show("Ya existe una cuenta registrada con ese numero");
                return;
            }
            else
            {
                Cuenta cuenta = new Cuenta(tbNumeroCuenta.Text, cliente.ClienteId, cliente);
                Controladora.Instancia.AgregarCuenta(cuenta);
                MessageBox.Show("Cuenta registrada correctamente");
                Refresh();
                LimpiarCampos();
            }
        }

        public void Refresh()
        {
            dtCuentas.DataSource = null;
            dtCuentas.AutoGenerateColumns = false;

            dtCuentas.DataSource = Controladora.Instancia.ListarCuentas();
            colNumero.DataPropertyName = "Numero";
            colSaldo.DataPropertyName = "Saldo";
        }

        public void LimpiarCampos()
        {
            tbNumeroCuenta.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumeroEstado.Text))
            {
                MessageBox.Show("Debe ingresar el numero de la cuenta a consultar");
                return;
            }
            Cuenta cuenta = Controladora.Instancia.CuentaSolicitada(tbNumeroEstado.Text);
            MessageBox.Show($"El saldo de la cuenta es de {cuenta.Saldo}");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
