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

        public string fecha;

        public static List<Cancion> lista = new List<Cancion>();

        public void getList()
        {
            
                //Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=KemishMusic;Integrated Security=true;
            SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM cancion";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Cancion detalles = new Cancion
                    {
                        nombre = reader["cancion_nombre"].ToString(),
                        imagen = (byte[])reader["cancion_imagen"],
                        audio = reader["cancion_audionombre"].ToString(),
                        fecha = reader["cancion_fechaestreno"].ToString(),
                        id = reader["cancion_id"].ToString()

                };
                    lista.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }

        public void ReproducirCancion(string id)
        {
            //Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=KemishMusic;Integrated Security=true;
            SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM cancion WHERE cancion_id = '" + id + "'";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                nombre = reader["cancion_nombre"].ToString();
                imagen = (byte[])reader["cancion_imagen"];
                audio = reader["cancion_audionombre"].ToString();
                fecha = reader["cancion_fechaestreno"].ToString();
                this.id = reader["cancion_id"].ToString();

            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
        }
    }
}
