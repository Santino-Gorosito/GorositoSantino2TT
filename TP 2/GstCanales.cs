using System;
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
    public partial class GstCanales : Form
    {
        Sistema sis = new Sistema();
        Form1 menu = new Form1();
        Canal canalModificar;
        public GstCanales(Sistema sistema, Form1 menuPrincipal)
        {
            InitializeComponent();
            sis = sistema;
            menu = menuPrincipal;
            CargarCheckedSeries();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text) || clbSeries.CheckedItems == null)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (sis.ExisteCanal(tbNombre.Text))
            {
                MessageBox.Show("Ya existe un canal con ese nombre");
                return;
            }
            else
            {

                List<Serie> series = new List<Serie>();

                foreach (var serie in clbSeries.CheckedItems)
                {
                    Serie serieSeleccionada = (Serie)serie;
                    series.Add(serieSeleccionada);
                }

                Canal canal = new Canal(tbNombre.Text, series);
                sis.AgregarCanal(canal);
                ActualizarDataEliminar();
                LimpiarCampos();
            }
        }

        public void CargarCheckedSeries()
        {
            clbSeries.Items.Clear();

            foreach (var serie in sis.Series)
            {
                clbSeries.Items.Add(serie, false);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActualizarDataEliminar();
        }

        public void ActualizarDataEliminar()
        {
            dataEliminar.DataSource = null;
            dataEliminar.DataSource = sis.Canales;

            colNombre.DataPropertyName = "Nombre";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataEliminar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un canal para eliminar");
                return;
            }

            Canal canal = (Canal)dataEliminar.SelectedRows[0].DataBoundItem;

            sis.EliminarCanal(canal);
            ActualizarDataEliminar();
        }

        private void btnCargarCanal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombreCanal.Text))
            {
                MessageBox.Show("Ingrese el nombre del canal a editar");
                return;
            }

            canalModificar = sis.DevolverCanal(tbNombreCanal.Text);

            if (canalModificar == null)
            {
                MessageBox.Show("No existe un canal con ese nombre");
                return;
            }
            else
            {
                tbNombreModif.Enabled = true;
                clbSeriesModif.Enabled = true;
                btnModificar.Enabled = true;
                LimpiarCampos();
                MostrarSeriesCanal(canalModificar);
            }
            
        }

        public void MostrarSeriesCanal(Canal canal)
        {
            clbSeriesModif.Items.Clear();

            foreach (var serie in sis.Series)
            {
                int index = clbSeriesModif.Items.Add(serie);

                if (canal.Series.Any(s => s.Nombre == serie.Nombre))
                {
                    clbSeriesModif.SetItemChecked(index, true);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNombreModif.Text))
            {
                canalModificar.Nombre = tbNombreModif.Text;
            }

            canalModificar.Series.Clear();

            foreach (var item in clbSeriesModif.CheckedItems)
            {
                canalModificar.Series.Add((Serie)item);
            }

            ActualizarDataEliminar();
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            tbNombre.Text = string.Empty;
            tbNombreCanal.Text = string.Empty;
            tbNombreModif.Text = string.Empty;
        }
    }
}
