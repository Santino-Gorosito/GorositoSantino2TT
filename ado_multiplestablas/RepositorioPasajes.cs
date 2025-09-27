using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado_multiplestablas
{
    public class RepositorioPasajes
    {
        private string cadenaConexion = "Data Source=DESKTOP-FPDJKD9\\SQLEXPRESS;Initial Catalog=PasajesAviones;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;";
        private List<Avion> listaAviones;
        private List<Pasaje> listaPasajes;
        private List<Pasajero> listaPasajeros;

        public RepositorioPasajes()
        {
            listaAviones = new List<Avion>();
            listaPasajeros = new List<Pasajero>();
            listaPasajes = new List<Pasaje>();
        }

        public void AgregarAvion(Avion avion)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "INSERT INTO Avion (Matricula, Modelo, Capacidad) VALUES (@Matricula, @Modelo, @Capacidad)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Matricula", avion.Matricula);
                    cmd.Parameters.AddWithValue("@Modelo", avion.Modelo);
                    cmd.Parameters.AddWithValue("@Capacidad", avion.Capacidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarAvion(int Id)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "DELETE FROM Avion WHERE IdAvion = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void ModificarAvion(Avion avModif)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "UPDATE Avion " +
                    "SET Matricula = @Mat, Modelo = @Mod, Capacidad = @Cap " +
                    "WHERE IdAvion = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", avModif.IdAvion);
                    cmd.Parameters.AddWithValue("@Mat", avModif.Matricula);
                    cmd.Parameters.AddWithValue("@Mod", avModif.Modelo);
                    cmd.Parameters.AddWithValue("@Cap", avModif.Capacidad);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public List<Avion> ListarAviones()
        {
            
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                listaAviones = new List<Avion>();
                conn.Open();
                string sql = "SELECT IdAvion, Matricula, Modelo, Capacidad FROM Avion";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaAviones.Add(new Avion
                        {
                            IdAvion = (int)reader[0],
                            Matricula = reader[1].ToString(),
                            Modelo = reader[2].ToString(),
                            Capacidad = (int)reader[3]
                        });
                    }
                }
                conn.Close();
            }
            return listaAviones;
        }

        public void AgregarPasajero(Pasajero pasajero)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "INSERT INTO Pasajero (Pasaporte, NombreApellido, Nacionalidad, FechaNacimiento) " +
                             "VALUES (@Pasaporte, @NombreApellido, @Nacionalidad, @FechaNacimiento)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Pasaporte", pasajero.Pasaporte);
                    cmd.Parameters.AddWithValue("@NombreApellido", pasajero.NombreApellido);
                    cmd.Parameters.AddWithValue("@Nacionalidad", pasajero.Nacionalidad);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", pasajero.FechaNacimiento);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public void EliminarPasajero(int Id)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "DELETE FROM Pasajero WHERE IdPasajero = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void ModificarPasajero(Pasajero pModif)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "UPDATE Pasajero " +
                    "SET Pasaporte = @Pas, NombreApellido = @Nap, Nacionalidad = @Nac, FechaNacimiento = @Fna " +
                    "WHERE IdPasajero = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", pModif.IdPasajero);
                    cmd.Parameters.AddWithValue("@Pas", pModif.Pasaporte);
                    cmd.Parameters.AddWithValue("@Nap", pModif.NombreApellido);
                    cmd.Parameters.AddWithValue("@Nac", pModif.Nacionalidad);
                    cmd.Parameters.AddWithValue("@Fna", pModif.FechaNacimiento);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public List<Pasajero> ListarPasajeros()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                listaPasajeros = new List<Pasajero>();
                conn.Open();
                string sql = "SELECT IdPasajero, Pasaporte, NombreApellido, Nacionalidad, FechaNacimiento FROM Pasajero";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPasajeros.Add(new Pasajero
                        {
                            IdPasajero = (int)reader["IdPasajero"],
                            Pasaporte = reader["Pasaporte"].ToString(),
                            NombreApellido = reader["NombreApellido"].ToString(),
                            Nacionalidad = reader["Nacionalidad"].ToString(),
                            FechaNacimiento = (DateTime)reader["FechaNacimiento"]
                        });
                    }
                }
                conn.Close();
            }
            return listaPasajeros;
        }

        public void AgregarPasaje(Pasaje pasaje)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "INSERT INTO Pasaje (NumeroAsiento, FechaVuelo, IdAvion, IdPasajero) " +
                             "VALUES (@NumeroAsiento, @FechaVuelo, @IdAvion, @IdPasajero)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NumeroAsiento", pasaje.NumeroAsiento);
                    cmd.Parameters.AddWithValue("@FechaVuelo", pasaje.FechaVuelo);
                    cmd.Parameters.AddWithValue("@IdAvion", pasaje.Avion.IdAvion);
                    cmd.Parameters.AddWithValue("@IdPasajero", pasaje.Pasajero.IdPasajero);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void EliminarPasaje(int Id)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "DELETE FROM Pasaje WHERE IdPasaje = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void ModificarPasaje(Pasaje pModif)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "UPDATE Pasaje " +
                    "SET NumeroAsiento = @NuA, FechaVuelo = @FeV, IdAvion = @IdV, IdPasajero = @IdP " +
                    "WHERE IdPasaje = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", pModif.IdPasaje);
                    cmd.Parameters.AddWithValue("@NuA", pModif.NumeroAsiento);
                    cmd.Parameters.AddWithValue("@FeV", pModif.FechaVuelo);
                    cmd.Parameters.AddWithValue("@IdV", pModif.Avion.IdAvion);
                    cmd.Parameters.AddWithValue("@IdP", pModif.Pasajero.IdPasajero);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public List<Pasaje> ListarPasajes()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                listaPasajes = new List<Pasaje>();
                conn.Open();
                string sql = "SELECT IdPasaje, NumeroAsiento, FechaVuelo, IdAvion, IdPasajero FROM Pasaje";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPasajes.Add(new Pasaje
                        {
                            IdPasaje = (int)reader["IdPasaje"],
                            NumeroAsiento = reader["NumeroAsiento"].ToString(),
                            FechaVuelo = (DateTime)reader["FechaVuelo"],
                            Avion = listaAviones.FirstOrDefault(x => x.IdAvion == (int)reader["IdAvion"]),
                            Pasajero = listaPasajeros.FirstOrDefault(x => x.IdPasajero == (int)reader["IdPasajero"])
                        }); 
                    }
                }
            }
            return listaPasajes;
        }

    }
}
