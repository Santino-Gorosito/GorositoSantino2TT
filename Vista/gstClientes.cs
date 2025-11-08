using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class gstClientes : Form
    {
        public gstClientes()
        {
            InitializeComponent();
            Refresh();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            #region Validaciones Campos
            if (string.IsNullOrEmpty(tbNombreAlta.Text) || string.IsNullOrEmpty(tbApellidoAlta.Text) || string.IsNullOrEmpty(tbDniAlta.Text) || string.IsNullOrEmpty(tbTelefonoAlta.Text))
            {
                MessageBox.Show("Debe completar todos los campos del registro");
                return;
            }

            #region Expresiones Regulares

            string patronDni = @"^\d{8}$";
            if (!Regex.IsMatch(tbDniAlta.Text, patronDni))
            {
                MessageBox.Show("El DNI debe contener exactamente 8 digitos");
                return;
            }


            string patronTelefono = @"^\d{10}$";
            if (!Regex.IsMatch(tbTelefonoAlta.Text, patronTelefono))
            {
                MessageBox.Show("El telefono debe contener exactamente 10 digitos numericos (sin espacios, guiones ni codigo de area)");
                return;
            }

            #endregion
            #endregion

            bool existeCliente = Controladora.Instancia.existeDni(tbDniAlta.Text);

            if (existeCliente)
            {
                MessageBox.Show("Ya existe un cliente con ese DNI");
                return;
            }
            else
            {
                Cliente cliente = new Cliente(tbNombreAlta.Text, tbApellidoAlta.Text, tbDniAlta.Text, tbTelefonoAlta.Text);
                Controladora.Instancia.AgregarCliente(cliente);
                MessageBox.Show("Cliente agregado correctamente");
                Refresh();
                LimpiarCampos();
            }
        }

        public void Refresh()
        {
            dtClientesElim.DataSource = null;
            dtClientesModif.DataSource = null;
            dtClientesModif.MultiSelect = false;
            dtClientesElim.MultiSelect = false;

            dtClientesElim.AutoGenerateColumns = false;
            dtClientesModif.AutoGenerateColumns = false;

            dtClientesElim.DataSource = Controladora.Instancia.ListarCliente();
            dtClientesModif.DataSource = Controladora.Instancia.ListarCliente();

            dtClientesElim.ClearSelection();
            dtClientesModif.ClearSelection();

            colNombreElim.DataPropertyName = "Nombre";
            colApellidoElim.DataPropertyName = "Apellido";
            colTelefonoElim.DataPropertyName = "Telefono";
            colDniElim.DataPropertyName = "DNI";

            colNombreModif.DataPropertyName = "Nombre";
            colApellidoModif.DataPropertyName = "Apellido";
            colTelefonoModif.DataPropertyName = "Telefono";
            colDniModif.DataPropertyName = "DNI";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtClientesElim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar");
                return;
            }

            Cliente c = (Cliente)dtClientesElim.SelectedRows[0].DataBoundItem;
            Controladora.Instancia.EliminarCliente(c);
            MessageBox.Show("Cliente eliminado correctamente");
            Refresh();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            #region Validaciones Campos

            if (dtClientesModif.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente para modificar");
                return;
            }

            if (string.IsNullOrEmpty(tbNombreModif.Text) && string.IsNullOrEmpty(tbApellidoModif.Text) && string.IsNullOrEmpty(tbDniModif.Text) && string.IsNullOrEmpty(tbTelefonoModif.Text))
            {
                MessageBox.Show("Debe completar al menos 1 campo para modificar");
                return;
            }

            #endregion

            Cliente clienteModif = (Cliente)dtClientesModif.SelectedRows[0].DataBoundItem;

            if (!string.IsNullOrEmpty(tbNombreModif.Text))
            {
                clienteModif.Nombre = tbNombreModif.Text;
            }

            if (!string.IsNullOrEmpty(tbApellidoModif.Text))
            {
                clienteModif.Apellido = tbApellidoModif.Text;
            }

            if (!string.IsNullOrEmpty(tbDniModif.Text))
            {
                string patronDni = @"^\d{8}$";
                if (!Regex.IsMatch(tbDniModif.Text, patronDni))
                {
                    MessageBox.Show("El DNI debe contener exactamente 8 digitos");
                    return;
                }

                bool existeDni = Controladora.Instancia.existeDni(tbDniModif.Text);

                if (existeDni) {
                    MessageBox.Show("Ya existe un cliente con ese DNI");
                    return;
                } else
                {
                    clienteModif.DNI = tbDniModif.Text;
                }
            }

            if (!string.IsNullOrEmpty(tbTelefonoModif.Text))
            {
                string patronTelefono = @"^\d{10}$";
                if (!Regex.IsMatch(tbTelefonoModif.Text, patronTelefono))
                {
                    MessageBox.Show("El telefono debe contener exactamente 10 digitos numericos (sin espacios, guiones ni codigo de area)");
                    return;
                } else
                {
                    clienteModif.Telefono = tbTelefonoModif.Text;
                }
            }

            Controladora.Instancia.ModificarCliente(clienteModif);
            MessageBox.Show("Cliente modificado");
            Refresh();
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            tbApellidoAlta.Text = string.Empty;
            tbApellidoModif.Text = string.Empty;
            tbNombreAlta.Text = string.Empty;
            tbNombreModif.Text = string.Empty;
            tbTelefonoAlta.Text = string.Empty;
            tbTelefonoModif.Text = string.Empty;
            tbDniAlta.Text = string.Empty;
            tbDniModif.Text = string.Empty;
        }
    }
}
