using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_3_CRUD
{
    public partial class Create : Form
    {
        Form1 menu = new Form1();
        private int? Id;
        public Create(Form1 menuPrincipal, int? id = null)
        {
            InitializeComponent();
            menu = menuPrincipal;
            this.Id = id;
            if (this.Id != null)
                CargarData();
        }

        private void CargarData()
        {
            PersonaDB db = new PersonaDB();
            Persona persona = db.ObtenerPersonas((int)Id);
            tbNombre.Text = persona.Nombre;
            tbLocalidad.Text = persona.Localidad;
            tbEdad.Text = persona.Edad.ToString();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PersonaDB db = new PersonaDB();

            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbEdad.Text) || string.IsNullOrEmpty(tbLocalidad.Text))
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            int edad = 0;

            try
            {
                edad = Convert.ToInt32(tbEdad.Text);
                if (Id==null) 
                    db.Agregar(tbNombre.Text, tbLocalidad.Text, edad);
                else
                    db.Editar(tbNombre.Text, tbLocalidad.Text, edad, (int)Id);
                menu.RellenarData();
            }
            catch (FormatException)
            {
                MessageBox.Show("La edad debe ser un entero");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } 
            
        }
    }
}
