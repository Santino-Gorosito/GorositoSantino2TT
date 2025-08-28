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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RellenarData();
        }

       public void RellenarData()
        {
            
            PersonaDB db = new PersonaDB();
            dataSQL.DataSource = null;
            dataSQL.DataSource = db.ObtenerPersonas();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RellenarData();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Create crearForm = new Create(this);
            crearForm.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = ObtenerId();
            if (Id != null)
            {
                Create editar = new Create(this, Id);
                editar.Show();
                this.Hide();
                RellenarData();
            }
        }

        private int? ObtenerId()
        {
            try
            {
                return int.Parse(dataSQL.Rows[dataSQL.CurrentRow.Index].Cells[0].Value.ToString());
            } catch
            {
                return null;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = ObtenerId();

            try
            {
                if (Id != null)
                {
                    PersonaDB db = new PersonaDB();
                    db.Eliminar((int)Id);
                    RellenarData();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
