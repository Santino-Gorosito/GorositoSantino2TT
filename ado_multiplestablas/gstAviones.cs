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
    public partial class gstAviones : Form
    {
        RepositorioPasajes repos = new RepositorioPasajes();
        Avion avModif;
        public gstAviones(RepositorioPasajes repos, Avion? avionModif = null)
        {
            InitializeComponent();
            this.repos = repos;
            avModif = avionModif;

            if (avionModif != null)
            {
                LoadAvion(avModif);
            }
        }

        public void LoadAvion(Avion avionModif)
        {
            tbCapacidad.Text = avionModif.Capacidad.ToString();
            tbModelo.Text = avionModif.Modelo;
            tbMatricula.Text = avionModif.Matricula;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCapacidad.Text) || string.IsNullOrEmpty(tbMatricula.Text) || string.IsNullOrEmpty(tbModelo.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            int capacidad = 0;

            try
            {
                capacidad = Convert.ToInt32(tbCapacidad.Text);

            } catch (Exception ex)
            {
                MessageBox.Show("La capacidad debe ser numerica");
                return;
            }

            if (avModif == null)
            {
                Avion avion = new Avion();
                avion.Capacidad = capacidad;
                avion.Matricula = tbMatricula.Text;
                avion.Modelo = tbModelo.Text;
                repos.AgregarAvion(avion);
                this.Close();
            } else
            {
                avModif.Matricula = tbMatricula.Text;
                avModif.Modelo = tbModelo.Text;
                avModif.Capacidad = capacidad;

                repos.ModificarAvion(avModif);
                this.Close();
            }
        }
    }
}
