using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TP_3_CRUD
{
    public class PersonaDB
    {
        private string connectionString =
            "Data Source=DESKTOP-FPDJKD9\\SQLEXPRESS;Initial Catalog=CRUDWF;" +
            "User=sa;Password=12345678";
            
        public bool ok()
        {
            try {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            } catch
            {
                return false;
            }
            return true;
            
        }   

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();

            string query = "select id,nombre,localidad,edad from Persona";

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) {
                        Persona persona = new Persona();
                        persona.Id = reader.GetInt32(0);
                        persona.Nombre = reader.GetString(1);
                        persona.Localidad = reader.GetString(2);
                        persona.Edad = reader.GetInt32(3);
                        personas.Add(persona);
                    }
                    reader.Close();
                    connection.Close();
                } catch (Exception ex) 
                {
                    throw new Exception("Hay un error en el query" + ex.Message);
                }
            }
            return personas;
        }

        public Persona ObtenerPersonas(int id)
        {
           

            string query = "select id,nombre,localidad,edad from Persona where id=@id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    
                        Persona persona = new Persona();
                        persona.Id = reader.GetInt32(0);
                        persona.Nombre = reader.GetString(1);
                        persona.Localidad = reader.GetString(2);
                        persona.Edad = reader.GetInt32(3);

                        reader.Close();
                        connection.Close();

                    return persona;
                    
                   
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en el query" + ex.Message);
                }
            }
           
        }

        public void Agregar(string nom, string loc, int edad)
        {
            string query = "insert into Persona(nombre, localidad, edad) values" +
                "(@nombre, @localidad, @edad)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nom);
                command.Parameters.AddWithValue("@localidad", loc);
                command.Parameters.AddWithValue("@edad", edad);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en el query" + ex.Message);
                }
            }
        }

        public void Editar(string nom, string loc, int edad, int id)
        {
            string query = "update Persona set nombre=@nombre, localidad=@localidad, edad=@edad where id=@id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nom);
                command.Parameters.AddWithValue("@localidad", loc);
                command.Parameters.AddWithValue("@edad", edad);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en el query" + ex.Message);
                }
            }
        }

        public void Eliminar(int id)
        {
            string query = "delete from Persona where id=@id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en el query" + ex.Message);
                }
            }
        }

    }

    public class Persona {
        public int Id { get; set; }
        public string Nombre {  get; set; }
        public int Edad {  get; set; }
        public string Localidad { get; set; }
           
    }

}
