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
    public partial class FrmPersona : Form
    {
        private int? Id;
        public FrmPersona(int? id = null)
        {
            InitializeComponent();
            Id = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dsCrudTableAdapters.PersonaTableAdapter ta = new dsCrudTableAdapters.PersonaTableAdapter();

            if (Id == null)
            {
                ta.Add(tbNombre.Text.Trim(), tbLocalidad.Text.Trim(), (int)numericEdad.Value);
            } else
            {
                ta.Edit(tbNombre.Text.Trim(), tbLocalidad.Text.Trim(), (int)numericEdad.Value, (int)Id);
            }
           
            this.Close();
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            if(Id != null)
            {
                dsCrudTableAdapters.PersonaTableAdapter ta = new dsCrudTableAdapters.PersonaTableAdapter();
                dsCrud.PersonaDataTable dt = ta.GetDataById((int) Id);
                dsCrud.PersonaRow row = (dsCrud.PersonaRow)dt.Rows[0];
                tbNombre.Text = row.nombre;
                tbLocalidad.Text = row.localidad;
                numericEdad.Value = row.edad;
            }
        }
    }
}
