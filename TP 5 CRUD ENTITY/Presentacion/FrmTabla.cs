using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_5_CRUD_ENTITY.Models;

namespace TP_5_CRUD_ENTITY.Presentacion
{
    public partial class FrmTabla : Form
    {
        public int? id;
        Persona oPersona = null;
        public FrmTabla(int? id=null)
        {
            InitializeComponent();
            this.id = id;

            if (id != null)
            {
                CargaDatos();
            }
        }

        private void CargaDatos()
        {
            using (CRUDWFEntities db = new CRUDWFEntities())
            {
                oPersona = db.Persona.Find(id);
                tbNombre.Text = oPersona.nombre;
                tbLocalidad.Text = oPersona.localidad;
                tbEdad.Text = oPersona.edad.ToString();
            }
        }

        private void btnGuardado_Click(object sender, EventArgs e)
        {
            using (CRUDWFEntities db = new CRUDWFEntities())
            {
                if (id == null)
                {
                    // Nuevo registro
                    oPersona = new Persona();
                }
                else
                {
                    
                    oPersona = db.Persona.Find(id);
                }

               
                oPersona.nombre = tbNombre.Text;
                oPersona.localidad = tbLocalidad.Text;
                oPersona.edad = int.Parse(tbEdad.Text);

                if (id == null)
                {
                    db.Persona.Add(oPersona);
                }
                else
                {
                    db.Entry(oPersona).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                this.Close();
            }
        }

    }
}
