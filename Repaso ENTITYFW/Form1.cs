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

namespace Repaso_ENTITYFW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            using (CRUDWFEntities db = new CRUDWFEntities())
            {
                var lst = from d in db.Persona select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch { return null;  }
            
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGst frmGst = new frmGst();
            frmGst.ShowDialog();
            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                frmGst frm = new frmGst(id);
                frm.ShowDialog();
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (CRUDWFEntities db = new CRUDWFEntities())
                {
                    Persona oPersona = db.Persona.Find(id);
                    db.Persona.Remove(oPersona);
                    db.SaveChanges();
                }
                Refrescar();
            }
        }
    }
}
