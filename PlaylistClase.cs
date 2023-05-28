using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KemishMusic
{
    public class PlaylistClase
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public byte[] imagen { get; set; }
        public string usuarioID { get; set; }

        public static List<PlaylistClase> lista = new List<PlaylistClase>();

        public static List<PlaylistClase> lista2 = new List<PlaylistClase>();
        public static List<PlaylistClase> lista3 = new List<PlaylistClase>();
        public static List<PlaylistClase> lista4 = new List<PlaylistClase>();

        public void getListPlaylist()
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM playlist";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    PlaylistClase detalles = new PlaylistClase
                    {
                        nombre = reader["playlist_nombre"].ToString(),
                        imagen = (byte[])reader["playlist_imagen"],
                        id = reader["playlist_id"].ToString(),
                        usuarioID = reader["usuario_id_usuario"].ToString()

                    };
                    lista.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }

        public void getListaPlaylistUsuario(string usuarioID)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM playlist WHERE usuario_id_usuario = '" + usuarioID + "'";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista2.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    PlaylistClase detalles = new PlaylistClase
                    {
                        nombre = reader["playlist_nombre"].ToString(),
                        imagen = (byte[])reader["playlist_imagen"],
                        id = reader["playlist_id"].ToString(),
                        usuarioID = reader["usuario_id_usuario"].ToString()

                    };
                    lista2.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }

        public void GetDatosPlaylist(string id)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM playlist WHERE playlist_id = '" + id + "'";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                nombre = reader["playlist_nombre"].ToString();
                imagen = (byte[])reader["playlist_imagen"];
                this.id = reader["playlist_id"].ToString();
                usuarioID = reader["usuario_id_usuario"].ToString();

            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
        }

        public void getListaPlaylist(string where)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM playlist INNER JOIN usuario on id_usuario = usuario_id_usuario " + where;
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista3.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    PlaylistClase detalles = new PlaylistClase
                    {
                        nombre = reader["playlist_nombre"].ToString(),
                        imagen = (byte[])reader["playlist_imagen"],
                        id = reader["playlist_id"].ToString(),
                        usuarioID = reader["usuario_id_usuario"].ToString()

                    };
                    lista3.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }

        public void getListaCancionesNoEnPlaylist(string cancionID)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM playlist WHERE playlist_id NOT IN(SELECT playlist_playlist_id FROM enlistar WHERE cancion_cancion_id = '" + cancionID + "');";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista4.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    PlaylistClase detalles = new PlaylistClase
                    {
                        nombre = reader["playlist_nombre"].ToString(),
                        imagen = (byte[])reader["playlist_imagen"],
                        id = reader["playlist_id"].ToString(),
                        usuarioID = reader["usuario_id_usuario"].ToString()

                    };
                    lista4.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }
    }

    
}
