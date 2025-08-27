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
    }
}
