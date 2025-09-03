using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_4_CRUD_DATA_SET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Refrescar();
        }

        private void Refrescar()
        {
            dsCrudTableAdapters.PersonaTableAdapter ta = new dsCrudTableAdapters.PersonaTableAdapter();
            dsCrud.PersonaDataTable dt = ta.GetData();

            dataSQL.DataSource = dt;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnNuev_Click(object sender, EventArgs e)
        {
            FrmPersona frmPersona = new FrmPersona();
            frmPersona.ShowDialog();
            Refrescar();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataSQL.Rows[dataSQL.CurrentRow.Index].Cells[0].Value.ToString());
            } catch
            {
                return null;
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null) {
                FrmPersona frm = new FrmPersona(Id);
                frm.ShowDialog();
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                dsCrudTableAdapters.PersonaTableAdapter ta = new dsCrudTableAdapters.PersonaTableAdapter();
                ta.Delete1((int)Id);
                Refrescar();
            }
        }
    }
}
