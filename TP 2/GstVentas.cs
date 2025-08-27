using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2
{
    public partial class GstVentas : Form
    {
        Sistema sis = new Sistema();
        Form1 menu = new Form1();
        public GstVentas(Sistema sistema, Form1 menuPrincipal)
        {
            InitializeComponent();
            sis  = sistema; 
            menu = menuPrincipal;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}
