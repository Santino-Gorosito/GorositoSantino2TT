namespace TP_2;

public partial class Form1 : Form
{
    Sistema sistema = new Sistema();
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        GstUsuarios menuUsuarios = new GstUsuarios(sistema, this);
        menuUsuarios.Show();
        this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        GstSeries menuSeries = new GstSeries(sistema, this);
        menuSeries.Show();
        this.Hide();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        GstCanales menuCanales = new GstCanales(sistema, this);
        menuCanales.Show();
        this.Hide();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        GstPaquetes menuPaquetes = new GstPaquetes(sistema, this);
        menuPaquetes.Show();
        this.Hide();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        GstVentas menuVentas = new GstVentas(sistema, this);
        menuVentas.Show();
        this.Hide();
    }
}
