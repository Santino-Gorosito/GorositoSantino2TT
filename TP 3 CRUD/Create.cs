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
        public Create(Form1 menuPrincipal)
        {
            InitializeComponent();
            menu = menuPrincipal;
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

                db.Agregar(tbNombre.Text, tbLocalidad.Text, edad);
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
