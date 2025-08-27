using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_2
{
    public partial class GstSeries : Form
    {
        Sistema sis = new Sistema();
        Form1 menu = new Form1();
        public GstSeries(Sistema sistema, Form1 menuPrincipal)
        {
            InitializeComponent();
            sis = sistema;
            menu = menuPrincipal;
            cbGenero.DataSource = Enum.GetValues(typeof(Genero));
            cbGeneroModif.DataSource = Enum.GetValues(typeof(Genero));

            cbGenero.SelectedIndex = -1;
            cbGeneroModif.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbQTemporadas.Text) || string.IsNullOrEmpty(tbDirector.Text) ||
                string.IsNullOrEmpty(tbDuracion.Text) || string.IsNullOrEmpty(tbQEpisodios.Text) || string.IsNullOrEmpty(tbRanking.Text) || cbGenero.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            int Temporadas = 0;
            int Episodios = 0;
            int Duracion = 0;
            int Ranking = 0;
            Genero genero = (Genero)cbGenero.SelectedItem;

            try
            {
                Temporadas = Convert.ToInt32(tbQTemporadas.Text);
                Episodios = Convert.ToInt32(tbQEpisodios.Text);
                Duracion = Convert.ToInt32(tbDuracion.Text);
                Ranking = Convert.ToInt32(tbRanking.Text);

                if (sis.ExisteSerie(tbNombre.Text))
                {
                    MessageBox.Show("Ya existe una serie con ese nombre");
                    return;
                }

                if (Temporadas <= 0 || Episodios <= 0 || Duracion <= 0 || Ranking <= 0 || Ranking > 10)
                {
                    MessageBox.Show("Los valores enteros deben ser mayores a 0 (el ranking debe ser mayor a 0 y menor igual a 10");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor debe ser numerico");
                return;
            }

            Serie serie = new Serie(Temporadas, Episodios, Duracion, Ranking, tbNombre.Text, tbDirector.Text, genero);
            sis.AgregarSerie(serie);
            ActualizarDataEliminar();
            ActualizarDataModificar();
            LimpiarCampos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActualizarDataEliminar();
        }

        public void ActualizarDataEliminar()
        {
            dataEliminar.DataSource = null;
            dataEliminar.AutoGenerateColumns = false;

            dataEliminar.DataSource = sis.Series;

            colNombre.DataPropertyName = "Nombre";
        }

        public void ActualizarDataModificar()
        {
            dataModificar.DataSource = null;
            dataModificar.AutoGenerateColumns = false;

            dataModificar.DataSource = sis.Series;

            colNombreModif.DataPropertyName = "Nombre";
            colTemporadas.DataPropertyName = "QTemporadas";
            colEpisodios.DataPropertyName = "QEpisodios";
            colDuracion.DataPropertyName = "Duracion";
            colRanking.DataPropertyName = "Ranking";
            colDirector.DataPropertyName = "Director";
            colGenero.DataPropertyName = "Genero";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataEliminar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una serie a eliminar");
                return;
            }

            Serie serieEliminar = (Serie)dataEliminar.SelectedRows[0].DataBoundItem;
            sis.EliminarSerie(serieEliminar);
            ActualizarDataEliminar();
            ActualizarDataModificar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataModificar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una serie a modificar");
                return;
            }

            if (string.IsNullOrEmpty(tbNombre.Text) && string.IsNullOrEmpty(tbQTemporadas.Text) && string.IsNullOrEmpty(tbDirector.Text) &&
                string.IsNullOrEmpty(tbDuracion.Text) && string.IsNullOrEmpty(tbQEpisodios.Text) && string.IsNullOrEmpty(tbRanking.Text) && cbGenero.SelectedItem == null)
            {
                MessageBox.Show("Complete al menos 1 campo");
                return;
            }

            Serie serie = (Serie)dataModificar.SelectedRows[0].DataBoundItem;

            int TemporadasModif = 0;
            int EpisodiosModif = 0;
            int DuracionModif = 0;
            int RankingModif = 0;


            try
            {
                if (!string.IsNullOrEmpty(tbQTemporadasModif.Text))
                {
                    TemporadasModif = Convert.ToInt32(tbQTemporadas.Text);

                    if (TemporadasModif <= 0)
                    {
                        MessageBox.Show("El numero de temporadas debe ser mayor a 0");
                        return;
                    }
                    else
                    {
                        serie.QTemporadas = TemporadasModif;
                    }
                }

                if (!string.IsNullOrEmpty(tbQEpisodiosModif.Text))
                {
                    EpisodiosModif = Convert.ToInt32(tbQEpisodiosModif.Text);

                    if (EpisodiosModif <= 0)
                    {
                        MessageBox.Show("La cantidad de episodios debe ser mayor a 0");
                        return;
                    }
                    else
                    {
                        serie.QEpisodios = EpisodiosModif;
                    }
                }

                if (!string.IsNullOrEmpty(tbDuracionModif.Text))
                {
                    DuracionModif = Convert.ToInt32(tbDuracionModif.Text);

                    if (DuracionModif <= 0)
                    {
                        MessageBox.Show("La duracion del episodio debe ser mayor a 0");
                        return;
                    }
                    else
                    {
                        serie.Duracion = DuracionModif;
                    }
                }

                if (!string.IsNullOrEmpty(tbRankingModif.Text))
                {
                    RankingModif = Convert.ToInt32(tbRankingModif.Text);

                    if (RankingModif <= 0 || RankingModif > 10)
                    {
                        MessageBox.Show("El ranking debe ser mayor a 0 y menos o igual a 10");
                        return;
                    }
                    else
                    {
                        serie.Ranking = RankingModif;
                    }
                }

                if (!string.IsNullOrEmpty(tbNombreModif.Text))
                {
                    if (sis.ExisteSerie(tbNombreModif.Text))
                    {
                        MessageBox.Show("Ya existe una serie con ese nombre");
                        return;
                    }
                    else
                    {
                        serie.Nombre = tbNombreModif.Text;
                    }
                }

                if (cbGeneroModif.SelectedItem != null)
                {
                    Genero genero = (Genero)cbGeneroModif.SelectedItem;
                    serie.Genero = genero;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("El valor debe ser numerico");
                return;
            }

            ActualizarDataEliminar();
            ActualizarDataModificar();
            LimpiarCampos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        public void LimpiarCampos()
        {
            tbDuracion.Text = string.Empty;
            tbDirector.Text = string.Empty;
            tbDuracionModif.Text = string.Empty;
            tbDirectorModif.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbNombreModif.Text = string.Empty;
            tbQEpisodios.Text = string.Empty;
            tbQEpisodiosModif.Text = string.Empty;
            tbQTemporadas.Text = string.Empty;
            tbQTemporadasModif.Text = string.Empty;
            tbRanking.Text = string.Empty;
            tbRankingModif.Text = string.Empty;
        }
    }
}
