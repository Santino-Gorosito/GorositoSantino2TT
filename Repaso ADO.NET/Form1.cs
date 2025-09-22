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
    public partial class Form1 : Form
    {
        Persona db = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            db.Conexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        } 

        public void Refrescar()
        {
            dgwDB.DataSource = null;
            dgwDB.DataSource = db.Get();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formGst frmGst = new formGst();
            frmGst.ShowDialog();
            Refrescar();
        }

        public int? GetId()
        {
            try
            {
                return int.Parse(dgwDB.Rows[dgwDB.CurrentRow.Index].Cells[0].Value.ToString());
            } catch { return null; }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null) {
                formGst frmEdit = new formGst(Id);
                frmEdit.ShowDialog();
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                db.Delete((int)Id);
                Refrescar();
            }
        }
    }
}
