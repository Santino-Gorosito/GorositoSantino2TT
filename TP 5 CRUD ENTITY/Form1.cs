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

namespace TP_5_CRUD_ENTITY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
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
            } catch
            {
                return null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presentacion.FrmTabla oFrmTabla = new Presentacion.FrmTabla();
            oFrmTabla.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null) {
                Presentacion.FrmTabla oFrmTabla = new Presentacion.FrmTabla(Id);
                oFrmTabla.ShowDialog();

                Refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                using (CRUDWFEntities db = new CRUDWFEntities())
                {
                    Persona oPersona = db.Persona.Find(Id);
                    db.Persona.Remove(oPersona);

                    db.SaveChanges();

                }
                    Refresh();
            }

        }
    }
}
