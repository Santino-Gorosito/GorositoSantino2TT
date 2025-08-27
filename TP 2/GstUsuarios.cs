using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2
{
    public partial class GstUsuarios : Form
    {
        private Sistema sis = new Sistema();

        public class EdadInvalidaException : Exception
        {
            public EdadInvalidaException(string mensaje) : base(mensaje) {
                mensaje = "No puedes registrarte siendo menor de edad";
            }
        }



        public GstUsuarios(Sistema sistema)
        {
            InitializeComponent();
            sis = sistema;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbDni.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            int dni = 0;

            try
            {
                dni = Convert.ToInt32(tbDni.Text);
                DateTime fechaNac = dtFechaNac.Value;

                int edad = CalcularEdad(fechaNac);

                if (sis.ExisteDni(dni))
                {
                    MessageBox.Show("El DNI ingresado ya existe. Ingrese otro");
                    return;
                }
                else
                {
                    Cliente cliente = new Cliente(tbNombre.Text, fechaNac, dni);
                    sis.AgregarCliente(cliente);
                    limpiarCampos();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El DNI debe ser numerico");
                return;
            }
            catch (EdadInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
                return;
            }
        }

        public int CalcularEdad(DateTime fechaNac)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNac.Year;

            if (fechaNac.Date > hoy.AddYears(-edad))
                edad--;

            if (edad < 18)
                throw new EdadInvalidaException("El usuario debe ser mayor de edad");

            return edad;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataEliminar.SelectedRows.Count == 0)
            {
                Console.WriteLine("Seleccione un cliente a eliminar");
                return;
            }
            else
            {
                Cliente clienteEliminar = (Cliente)dataEliminar.SelectedRows[0].DataBoundItem;
                sis.EliminarCliente(clienteEliminar);
                ActualizarDataEliminar();
                ActualizarDataModificar();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActualizarDataEliminar();
        }

        public void ActualizarDataEliminar()
        {

            dataEliminar.DataSource = null;
            dataEliminar.AutoGenerateColumns = false;
            dataEliminar.DataSource = sis.Clientes;

            colNombre.DataPropertyName = "Nombre";
            colDni.DataPropertyName = "Dni";
        }

        public void ActualizarDataModificar()
        {

            dataModificar.DataSource = null;
            dataModificar.AutoGenerateColumns = false;
            dataModificar.DataSource = sis.Clientes;

            colNombreModif.DataPropertyName = "Nombre";
            colDniModif.DataPropertyName = "Dni";
            colFechaNacModif.DataPropertyName = "FechaNacimiento";
        }

        private void btnListarModif_Click(object sender, EventArgs e)
        {
            ActualizarDataModificar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataModificar.SelectedRows.Count == 0) {
                MessageBox.Show("Seleccione un cliente a modificar");
                return;
            }

            Cliente cliente = (Cliente)dataModificar.SelectedRows[0].DataBoundItem;

            if (!string.IsNullOrEmpty(tbNombreModif.Text))
            {
                cliente.Nombre = tbNombreModif.Text;
                ActualizarDataEliminar();
                ActualizarDataModificar();
            }

            if (!string.IsNullOrEmpty(tbDniModif.Text)) {
                try
                {
                    int dniModif = Convert.ToInt32(tbDniModif.Text);

                    if (sis.ExisteDni(dniModif)) {
                        MessageBox.Show("Ese dni ya existe");
                        return;
                    } else
                    {
                        cliente.Dni = dniModif;
                        ActualizarDataEliminar();
                        ActualizarDataModificar();
                    }
                } catch (FormatException) {
                    MessageBox.Show("Ingrese un DNI numerico");
                    return;
                } 
            } 
        }

        public void limpiarCampos()
        {
            tbDni.Text = string.Empty;
            tbDniModif.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbNombreModif.Text = string.Empty;

        }
    }
}
