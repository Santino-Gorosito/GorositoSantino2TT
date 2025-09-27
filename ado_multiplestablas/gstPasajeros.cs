using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado_multiplestablas
{
    public partial class gstPasajeros : Form
    {
        RepositorioPasajes repos;
        Pasajero pModif;
        public gstPasajeros(RepositorioPasajes repos, Pasajero? pModif = null)
        {
            InitializeComponent();
            this.repos = repos;
            this.pModif = pModif;

            if (pModif != null)
            {
                LoadPasajero(pModif);
            }
        }

        public void LoadPasajero(Pasajero pasajero)
        {
            tbPasaporte.Text = pasajero.Pasaporte;
            tbNacionalidad.Text = pasajero.Pasaporte;
            tbNombre.Text = pasajero.NombreApellido;
            dtFechaNacimiento.Value = pasajero.FechaNacimiento;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbNacionalidad.Text) || string.IsNullOrEmpty(tbPasaporte.Text))
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            if (pModif == null) {
                Pasajero pasajero = new Pasajero();
                pasajero.NombreApellido = tbNombre.Text;
                pasajero.Pasaporte = tbPasaporte.Text;
                pasajero.Nacionalidad = tbPasaporte.Text;
                pasajero.FechaNacimiento = dtFechaNacimiento.Value;

                repos.AgregarPasajero(pasajero);
                this.Close();
            } else
            {
                pModif.Pasaporte = tbPasaporte.Text;
                pModif.Nacionalidad = tbNacionalidad.Text;
                pModif.NombreApellido = tbNombre.Text;
                pModif.FechaNacimiento = dtFechaNacimiento.Value;

                repos.ModificarPasajero(pModif);
                this.Close();
            }

            
        }
    }
}
