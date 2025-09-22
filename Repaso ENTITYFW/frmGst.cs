using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repaso_ENTITYFW.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Repaso_ENTITYFW
{
    public partial class frmGst : Form
    {
        public int? id;
        Persona oPersona = null;
        public frmGst(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null) { GetPersona(); }
        }

        private void GetPersona()
        {
            using (CRUDWFEntities db = new CRUDWFEntities())
            {
                oPersona = db.Persona.Find(id);
                tbNombre.Text = oPersona.nombre;
                tbLocalidad.Text = oPersona.localidad;
                tbEdad.Text = oPersona.edad.ToString();
            }
        } 

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbLocalidad.Text) || string.IsNullOrEmpty(tbEdad.Text)) {
                MessageBox.Show("Complete los campos");
                return;
            }

            int Edad = 0;
            try
            {
                Edad = Convert.ToInt32(tbEdad.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Error, la edad debe ser numerica");
                return;
            }

            using (CRUDWFEntities db = new CRUDWFEntities())
            {
                
                if (id == null)
                {
                     oPersona = new Persona();
                }
                oPersona.nombre = tbNombre.Text;
                oPersona.localidad = tbLocalidad.Text;
                oPersona.edad = Edad;

                if (id == null)
                {
                    db.Persona.Add(oPersona);
                } else
                {
                    db.Entry(oPersona).State = System.Data.Entity.EntityState.Modified;
                }

               
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
