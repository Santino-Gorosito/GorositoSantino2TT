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
    public partial class GstPaquetes : Form
    {
        Sistema sis = new Sistema();
        Form1 menu = new Form1();
        public GstPaquetes(Sistema sistema, Form1 menuPrincipal)
        {
            InitializeComponent();
            sis = sistema;
            menu = menuPrincipal;

            CargarCheckedCanales();



        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text) || clbCanales.CheckedItems == null || (radioButton1.Checked == false && radioButton2.Checked == false))
            {
                MessageBox.Show("Marque todos los campos necesarios");
                return;
            }

            if (sis.ExistePaquete(tbNombre.Text))
            {
                MessageBox.Show("Ya existe un paquete con ese nombre");
                return;
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    List<Canal> canales = new List<Canal>();

                    foreach (var canal in clbCanales.CheckedItems)
                    {
                        Canal canalSeleccionado = (Canal)canal;
                        canales.Add(canalSeleccionado);
                    }

                    Silver paqueteSilver = new Silver(tbNombre.Text, canales);
                    sis.AgregarPaquete(paqueteSilver);
                }
                else if (radioButton2.Checked == true)
                {
                    List<Canal> canales = new List<Canal>();

                    foreach (var canal in clbCanales.CheckedItems)
                    {
                        Canal canalSeleccionado = (Canal)canal;
                        canales.Add(canalSeleccionado);
                    }

                    Premium paquetePremium = new Premium(tbNombre.Text, canales);
                    sis.AgregarPaquete(paquetePremium);
                }
            }
        }

        public void CargarCheckedCanales()
        {
            clbCanales.Items.Clear();

            foreach (var canal in sis.Canales)
            {
                clbCanales.Items.Add(canal, false);
            }
        }

        public void ActualizarDataEliminar()
        {
            dataEliminar.AutoGenerateColumns = false;
            dataEliminar.DataSource = null;
            dataEliminar.DataSource = sis.Paquetes;

            colNombre.DataPropertyName = "Nombre";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActualizarDataEliminar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataEliminar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un paquete a eliminar");
                return;
            }

            sis.EliminarPaquete((Paquete)dataEliminar.SelectedRows[0].DataBoundItem);
        }
    }
}
