using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_Parcial_ADO
{
    public partial class gstSocios : Form
    {
        Socio socioModif;
        Repositorio repo;
        public gstSocios(Repositorio repo, Socio? soc = null)
        {
            InitializeComponent();
            this.repo = repo;
            socioModif = soc;

            if (socioModif != null)
            {
                LoadSocio(socioModif);
            }
        }

        public void LoadSocio(Socio socioModif)
        {
            tbNombre.Text = socioModif.Nombre;
            tbApellido.Text = socioModif.Apellido;
            tbDni.Text = socioModif.Dni;
            dtNacimiento.Value = socioModif.FechaNacimiento;
            tbNumSocio.Text = socioModif.NumeroSocio.ToString();
            if (socioModif.CuotaAlDia == true)
            {
                Si.Checked = true;
            } else
            {
                No.Checked = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbApellido.Text) || string.IsNullOrEmpty(tbDni.Text)
                || string.IsNullOrEmpty(tbNumSocio.Text) || (Si.Checked == false && No.Checked == false))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

           

            int numSocio = 0;

            try
            {
                numSocio = Convert.ToInt32(tbNumSocio.Text);
            } catch (FormatException)
            {
                MessageBox.Show("El numero de socio debe ser numerico");
                return;
            }


            

            Socio socio = new Socio();
            socio.Id = socioModif.Id;
            socio.Nombre = tbNombre.Text;
            socio.Apellido = tbApellido.Text;
            socio.Dni = tbDni.Text;
            socio.NumeroSocio = numSocio;
            socio.FechaNacimiento = dtNacimiento.Value;


            if (Si.Checked)
            {
                socio.CuotaAlDia = true;
            } else
            {
                socio.CuotaAlDia = false;
            }

            if (socioModif == null) 
            {
                if (repo.existeSocio(numSocio))
                {
                    MessageBox.Show("El socio ya existe");
                    return;
                }

                repo.Agregar(socio);
                this.Close();
            }
            else 
            {
                
                if (numSocio != socioModif.NumeroSocio && repo.existeSocio(numSocio))
                {
                    MessageBox.Show("El socio ya existe con ese número");
                    return;
                }

                repo.Modificar(socio);
                this.Close();
            }



        }
    }
}
