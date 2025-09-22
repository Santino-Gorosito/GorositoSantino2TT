using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;

namespace Repaso_ADO.NET
{
    public class Persona
    {
        private string conecString =
            "Data Source=DESKTOP-FPDJKD9\\SQLEXPRESS; Initial Catalog=CRUDWF; User=sa; Password=12345678";
           
        
        public void Conexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(conecString);
                conexion.Open();
                MessageBox.Show("Conexion establecida");
            } catch
            {
                MessageBox.Show("Error en la conexion a la DB");
            }
        }

        public List<PersonaObj> Get()
        {
            List<PersonaObj> personas = new List<PersonaObj>();

            string query = "select id,nombre,localidad,edad from Persona";

            using (SqlConnection conexion = new SqlConnection(conecString)) {
                SqlCommand cmd = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) {
                        PersonaObj pObj = new PersonaObj();
                        pObj.Id = reader.GetInt32(0);
                        pObj.Nombre = reader.GetString(1);
                        pObj.Localidad = reader.GetString(2);
                        pObj.Edad = reader.GetInt32(3);
                        personas.Add(pObj);
                    }

                    reader.Close();
                    conexion.Close();

                } catch (Exception ex) 
                {
                    MessageBox.Show("Hay un error en la DB: " + ex.Message);
                }
            }

            return personas;
        }

        public PersonaObj ObtenerPorId(int? id)
        {
            

            string query = "select id,nombre,localidad,edad from Persona where id= @id";

            using (SqlConnection conexion = new SqlConnection(conecString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();
                    
                        PersonaObj pObj = new PersonaObj();
                        pObj.Id = reader.GetInt32(0);
                        pObj.Nombre = reader.GetString(1);
                        pObj.Localidad = reader.GetString(2);
                        pObj.Edad = reader.GetInt32(3);


                    
                    reader.Close();
                    conexion.Close();
                    return pObj;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error en la DB: " + ex.Message);
                    return null;
                }
            }

            
        }

        public void Add(string n, string l, int e)
        {

            string query = "insert into Persona(nombre, localidad, edad) values(@name, @loc, @age)";

            using (SqlConnection conexion = new SqlConnection(conecString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@name", n);
                cmd.Parameters.AddWithValue("@loc", l);
                cmd.Parameters.AddWithValue("@age", e);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error en la DB: " + ex.Message);
                }
            }
        }

        public void Update(string n, string l, int e, int Id)
        {

            string query = "update Persona set nombre=@name, localidad=@loc, edad=@age where id=@id";

            using (SqlConnection conexion = new SqlConnection(conecString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@name", n);
                cmd.Parameters.AddWithValue("@loc", l);
                cmd.Parameters.AddWithValue("@age", e);
                cmd.Parameters.AddWithValue("@id", Id);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error en la DB: " + ex.Message);
                }
            }
        }

        public void Delete(int Id)
        {

            string query = "delete from Persona where id=@id";

            using (SqlConnection conexion = new SqlConnection(conecString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", Id);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error en la DB: " + ex.Message);
                }
            }
        }
    }

    public class PersonaObj
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public int Edad { get; set; }
    }
}
