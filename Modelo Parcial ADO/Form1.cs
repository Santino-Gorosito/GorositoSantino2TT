namespace Modelo_Parcial_ADO
{
    public partial class Form1 : Form
    {
        Repositorio repo = new Repositorio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = repo.GetSocios();
            dgvSocios.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gstSocios frmSocios = new gstSocios(repo);
            frmSocios.ShowDialog();
            Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un socio a eliminar");
                return;
            }

            Socio socioElim = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;

            repo.Eliminar(socioElim);
            Refresh();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un socio a modificar");
                return;
            }

            Socio socioModi = (Socio)dgvSocios.SelectedRows[0].DataBoundItem;

            gstSocios frmSocios = new gstSocios(repo, socioModi);
            frmSocios.ShowDialog();
            Refresh();
        }

        private void btnCuotasAlDia_Click(object sender, EventArgs e)
        {
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = repo.sociosCuotaAlDia();
            dgvSocios.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
