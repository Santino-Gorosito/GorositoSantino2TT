namespace ado_multiplestablas
{
    public partial class Form1 : Form
    {
        RepositorioPasajes repos = new RepositorioPasajes();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnRefrescarAviones_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAgregarAviones_Click(object sender, EventArgs e)
        {
            gstAviones frmAviones = new gstAviones(repos);
            frmAviones.ShowDialog();
            Refresh();
        }

        public void Refresh()
        {


            dgvAviones.DataSource = null;
            dgvAviones.DataSource = repos.ListarAviones();

            dgvPasajeros.DataSource = null;
            dgvPasajeros.DataSource = repos.ListarPasajeros();

            dgvPasajes.AutoGenerateColumns = false;
            dgvPasajes.DataSource = null;
            dgvPasajes.DataSource = repos.ListarPasajes();
            colIdPasaje.DataPropertyName = "IdPasaje";
            colNumAsiento.DataPropertyName = "NumeroAsiento";
            colIdPasajero.DataPropertyName = "Pasajero";
            colFecha.DataPropertyName = "FechaVuelo";
            colIdAvion.DataPropertyName = "Avion";

        }

        private void btnEliminarAviones_Click(object sender, EventArgs e)
        {



            int Id = int.Parse(dgvAviones.Rows[dgvAviones.CurrentRow.Index].Cells[0].Value.ToString());

            if (Id == null)
            {
                MessageBox.Show("Seleccione un avion a eliminar");
                return;
            }
            else
            {
                repos.EliminarAvion(Id);
                Refresh();
            }
        }

        private void btnAgregarPasajeros_Click(object sender, EventArgs e)
        {
            gstPasajeros frmPasajeros = new gstPasajeros(repos);
            frmPasajeros.ShowDialog();
            Refresh();
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dgvPasajeros.Rows[dgvPasajeros.CurrentRow.Index].Cells[0].Value.ToString());

            if (Id == null)
            {
                MessageBox.Show("Seleccione un pasajero a eliminar");
                return;
            }
            else
            {
                repos.EliminarPasajero(Id);
                Refresh();
            }
        }

        private void btnAgregarPasaje_Click(object sender, EventArgs e)
        {
            gstPasajes frmPasajes = new gstPasajes(repos);
            frmPasajes.ShowDialog();
            Refresh();
        }

        private void btnEliminarPasaje_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dgvPasajes.Rows[dgvPasajes.CurrentRow.Index].Cells[0].Value.ToString());

            if (Id == null)
            {
                MessageBox.Show("Seleccione un pasaje a eliminar");
                return;
            }
            else
            {
                repos.EliminarPasaje(Id);
                Refresh();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Avion avionModificar = (Avion)dgvAviones.SelectedRows[0].DataBoundItem;
            gstAviones frmAviones = new gstAviones(repos, avionModificar);
            frmAviones.ShowDialog();
            Refresh();
        }

        private void btnModifPasajero_Click(object sender, EventArgs e)
        {
            Pasajero pasajeroModificar = (Pasajero)dgvPasajeros.SelectedRows[0].DataBoundItem;
            gstPasajeros frmPasajeros = new gstPasajeros(repos, pasajeroModificar);
            frmPasajeros.ShowDialog();
            Refresh();
        }

        private void btnModifPasaje_Click(object sender, EventArgs e)
        {
            Pasaje pasajeModificar = (Pasaje)dgvPasajes.SelectedRows[0].DataBoundItem;
            gstPasajes frmPasajes = new gstPasajes(repos, pasajeModificar);
            frmPasajes.ShowDialog();
            Refresh();
        }
    }
}
