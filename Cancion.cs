using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace KemishMusic
{
    public class Cancion
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public byte[] imagen { get; set; }
        public string audio { get; set; }

        public static List<Cancion> lista = new List<Cancion>();

        public void getList()
        {
            
                
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=KemishMusic;Integrated Security=true;");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM Canciones";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Cancion detalles = new Cancion
                    {
                        nombre = reader["Nombre"].ToString(),
                        imagen = (byte[])reader["Imagen"],
                        audio = reader["Audio"].ToString(),
                        id = reader["ID"].ToString(),

                    };
                    lista.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }

        public void ReproducirCancion(string id)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=KemishMusic;Integrated Security=true;");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM Canciones WHERE ID = '" + id + "'";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                nombre = reader["Nombre"].ToString();
                imagen = (byte[])reader["Imagen"];
                audio = reader["Audio"].ToString();
                this.id = reader["ID"].ToString();

            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
        }
    }
}
