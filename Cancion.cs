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
        // Atributos clase Cancion
        public string id { get; set; }
        public string nombre { get; set; }
        public byte[] imagen { get; set; }
        public string audio { get; set; }

        public string fecha;

        public string usuarioID { get; set; }


        // Listas correspondientes para seleccion de canciones
        public static List<Cancion> lista = new List<Cancion>();

        public static List<Cancion> lista2 = new List<Cancion>();

        public static List<Cancion> lista3 = new List<Cancion>();
        public static List<Cancion> lista4 = new List<Cancion>();
        public static List<Cancion> lista5 = new List<Cancion>();

        // Obtener lista de canciones
        public void getList()
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

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
                        id = reader["cancion_id"].ToString(),
                        usuarioID = reader["usuario_id_usuario"].ToString()

                };
                    lista.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }

        // Obtener lista de canciones buscadas
        public void getListaCancion(string where)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM cancion INNER JOIN usuario on id_usuario = usuario_id_usuario " + where;
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista3.Clear();

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
                        id = reader["cancion_id"].ToString(),
                        usuarioID = reader["usuario_id_usuario"].ToString()

                    };
                    lista3.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }

        // Obtener cancion para reproducirla
        public void ReproducirCancion(string id)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");
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
                usuarioID = reader["usuario_id_usuario"].ToString();

            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
        }

        // Obtener lista de canciones registradas por cierto usuario
        public void getListaCancionesUsuario(string usuarioID)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM cancion WHERE usuario_id_usuario = '" + usuarioID +"'";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista2.Clear();

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
                        id = reader["cancion_id"].ToString(),
                        usuarioID = reader["usuario_id_usuario"].ToString()

                    };
                    lista2.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }

        // Obtener canciones registradas en una playlist
        public void getListaCancionesPlaylist(string playlistID)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM cancion INNER JOIN enlistar on enlistar.cancion_cancion_id = cancion_id WHERE playlist_playlist_id = '" + playlistID + "'";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista4.Clear();

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
                        id = reader["cancion_id"].ToString(),
                        usuarioID = reader["usuario_id_usuario"].ToString()

                    };
                    lista4.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }

        // Checar canciones que no esten en la playlist
        public void getListaCancionesNoEnPlaylist(string playlistID)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM cancion WHERE cancion_id NOT IN(SELECT cancion_cancion_id FROM enlistar WHERE playlist_playlist_id = '"+playlistID+"');";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista5.Clear();

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
                        id = reader["cancion_id"].ToString(),
                        usuarioID = reader["usuario_id_usuario"].ToString()

                    };
                    lista5.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }


    }
}
