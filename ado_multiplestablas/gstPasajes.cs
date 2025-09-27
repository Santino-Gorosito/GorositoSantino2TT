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
    public partial class gstPasajes : Form
    {
        RepositorioPasajes repositorioPasajes;
        Pasaje pModif;
        public gstPasajes(RepositorioPasajes repositorioPasajes, Pasaje? pasajeModif = null)
        {
            InitializeComponent();
            this.repositorioPasajes = repositorioPasajes;
            pModif = pasajeModif;

            if (pModif != null) { LoadPasaje(pModif); }
        }

        public void LoadPasaje(Pasaje pModif)
        {
            tbNumeroAsiento.Text = pModif.NumeroAsiento;
            tbIdAvion.Text = pModif.Avion.IdAvion.ToString();
            tbIdPasajero.Text = pModif.Pasajero.IdPasajero.ToString();
            dtFechaVuelo.Value = pModif.FechaVuelo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbNumeroAsiento.Text) || string.IsNullOrEmpty(tbIdAvion.Text) || string.IsNullOrEmpty(tbIdPasajero.Text))
            {
                MessageBox.Show("Debe completar los campos");
                return;
            }

            int IdAvion;
            int IdPasajero;

            try
            {
                IdAvion = Convert.ToInt32(tbIdAvion.Text);
                IdPasajero = Convert.ToInt32(tbIdPasajero.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("Los id deben ser numericos");
                return;
            }

            List<Avion> aviones = repositorioPasajes.ListarAviones();
            List<Pasajero> pasajeros = repositorioPasajes.ListarPasajeros();
            List<Pasaje> pasajes = repositorioPasajes.ListarPasajes();


            if (pModif == null)
            {
                Avion av = new Avion();
                Pasajero pas = new Pasajero();

                av = aviones.FirstOrDefault(x => x.IdAvion == IdAvion);
                pas = pasajeros.FirstOrDefault(x => x.IdPasajero == IdPasajero);

                if (av == null || pas == null)
                {
                    MessageBox.Show("Los Ids ingresados son invalidos");
                    return;
                }

                Pasaje pasajeExiste = pasajes.FirstOrDefault(x => x.FechaVuelo == dtFechaVuelo.Value && x.NumeroAsiento == tbNumeroAsiento.Text);
                if (pasajeExiste == null)
                {
                    Pasaje pasaje = new Pasaje();
                    pasaje.Pasajero = pas;
                    pasaje.Avion = av;
                    pasaje.NumeroAsiento = tbNumeroAsiento.Text;
                    pasaje.FechaVuelo = dtFechaVuelo.Value;
                    repositorioPasajes.AgregarPasaje(pasaje);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El pasaje ya esta registrado en la base de datos");
                    return;
                }
            } else
            {
                Avion av = new Avion();
                Pasajero pas = new Pasajero();

                av = aviones.FirstOrDefault(x => x.IdAvion == IdAvion);
                pas = pasajeros.FirstOrDefault(x => x.IdPasajero == IdPasajero);

                if (av == null || pas == null)
                {
                    MessageBox.Show("Los Ids ingresados son invalidos");
                    return;
                }

                Pasaje pasajeExiste = pasajes.FirstOrDefault(x => x.FechaVuelo == dtFechaVuelo.Value && x.NumeroAsiento == tbNumeroAsiento.Text);
                if (pasajeExiste == null)
                {
                    pModif.Pasajero = pas;
                    pModif.Avion = av;
                    pModif.NumeroAsiento = tbNumeroAsiento.Text;
                    pModif.FechaVuelo = dtFechaVuelo.Value;
                    repositorioPasajes.ModificarPasaje(pModif);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El pasaje ya esta registrado en la base de datos");
                    return;
                }
            }
            

            

            
        }
      
    }
}

