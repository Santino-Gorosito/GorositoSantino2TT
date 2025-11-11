namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            gstClientes frmClientes = new gstClientes();
            frmClientes.ShowDialog();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            gstCuentas frmCuentas = new gstCuentas();
            frmCuentas.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            gstInformes frmInformes = new gstInformes();
            frmInformes.ShowDialog();
        }

        private void s_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
