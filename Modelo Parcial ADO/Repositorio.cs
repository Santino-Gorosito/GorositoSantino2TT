using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;

namespace Modelo_Parcial_ADO
{
    public class Repositorio
    {
        private string conexion = "Data Source=DESKTOP-FPDJKD9\\SQLEXPRESS;Initial Catalog=club;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;";
        private List<Socio> Socios;

        public Repositorio()
        {
            Socios = new List<Socio>();
        }

        public bool existeSocio(int numSocio)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = "SELECT * FROM Socios WHERE numero_socio = @num";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@num", numSocio);

                    using (SqlDataReader rdr = cmd.ExecuteReader()) {
                        if (rdr.Read()) {
                            return true;
                        } else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public List<Socio> sociosCuotaAlDia()
        {
            List<Socio> sociosCuota = new List<Socio>();
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = "SELECT * FROM Socios WHERE cuota_al_dia = 1";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sociosCuota.Add(new Socio
                            {
                                Id = (int)reader[0],
                                Nombre = reader[1].ToString(),
                                Apellido = reader[2].ToString(),
                                Dni = reader[3].ToString(),
                                FechaNacimiento = (DateTime)reader[4],
                                NumeroSocio = (int)reader[5],
                                CuotaAlDia = (bool)reader[6]
                            });

                        }
                    } 
                }
                conn.Close();
            }
            return sociosCuota;
        }

        public void Agregar(Socio socio)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = "INSERT INTO Socios (nombre, apellido, dni, fecha_nacimiento, numero_socio, cuota_al_dia) VALUES (@nom, @ap, @dn, @fna, @nso, @cud)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", socio.Nombre);
                    cmd.Parameters.AddWithValue("@ap", socio.Apellido);
                    cmd.Parameters.AddWithValue("@dn", socio.Dni);
                    cmd.Parameters.AddWithValue("@fna", socio.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@nso", socio.NumeroSocio);
                    cmd.Parameters.AddWithValue("@cud", socio.CuotaAlDia);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Eliminar(Socio socio)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = "DELETE FROM Socios WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", socio.Id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Modificar(Socio socio) {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = "UPDATE Socios SET nombre = @nom, apellido = @ap, dni = @dn, fecha_nacimiento = @fna, numero_socio = @nso, cuota_al_dia = @cdi " +
                    "WHERE id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", socio.Id);
                    cmd.Parameters.AddWithValue("@nom", socio.Nombre);
                    cmd.Parameters.AddWithValue("@ap", socio.Apellido);
                    cmd.Parameters.AddWithValue("@dn", socio.Dni);
                    cmd.Parameters.AddWithValue("@fna", socio.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@nso", socio.NumeroSocio);
                    cmd.Parameters.AddWithValue("@cdi", socio.CuotaAlDia);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public List<Socio> GetSocios()
        {
            Socios = new List<Socio>();
            using (SqlConnection conn = new SqlConnection(conexion)) {
                conn.Open();
                string sql = "SELECT id, nombre, apellido, dni, fecha_nacimiento, numero_socio, cuota_al_dia FROM Socios";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) {
                            Socios.Add(new Socio
                            {
                                Id = (int)reader[0],
                                Nombre = reader[1].ToString(),
                                Apellido = reader[2].ToString(),
                                Dni = reader[3].ToString(),
                                FechaNacimiento = (DateTime)reader[4],
                                NumeroSocio = (int)reader[5],
                                CuotaAlDia = (bool)reader[6]
                            });
                        }
                    }
                }
                conn.Close();
            }
            return Socios;
        }
    }
}
