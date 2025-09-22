using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_ADO.NET
{
    public partial class formGst : Form
    {
        private int? id;
        public formGst(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                LoadPersona();
            }
        }

        private void LoadPersona()
        {
            Persona db = new Persona();
            PersonaObj persona = db.ObtenerPorId(id);
            tbNombre.Text = persona.Nombre;
            tbLocalidad.Text = persona.Localidad;
            tbEdad.Text = persona.Edad.ToString();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbLocalidad.Text) || string.IsNullOrEmpty(tbEdad.Text)) {
                MessageBox.Show("Debe completar los campos");
                return;
            }

            int edad = 0;

            try
            {
                edad = Convert.ToInt32(tbEdad.Text);
            } catch (FormatException)
            {
                MessageBox.Show("La edad debe ser numerica");
                return;
            }
            Persona db = new Persona();

            if (id != null)
            {
                db.Update(tbNombre.Text, tbLocalidad.Text, edad, (int)id);
                this.Close();
            } else
            {
                db.Add(tbNombre.Text, tbLocalidad.Text, edad);
                this.Close();
            }
            
        }
    }
}
