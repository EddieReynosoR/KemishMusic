using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KemishMusic
{
    public class Artista
    {
        public string id { get; set; }
        public string usuario { get; set; }
        public byte[] foto { get; set; }

        public byte[] fotoPortada { get; set; }

        public string descripcion { get; set; }

        public string nombreArtistico { get; set; }

        public static List<Artista> lista = new List<Artista>();

        public static List<Artista> lista2 = new List<Artista>();

        public void getArtista(string id)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM usuario WHERE id_usuario = '" + id + "'";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            

            if (reader.Read())
            {

                this.id = reader["id_usuario"].ToString();
                usuario = reader["usuario_username"].ToString();
                foto = (byte[])reader["usuario_fotoperfil"];
                fotoPortada = (byte[])reader["usuario_fportada"];
                descripcion = reader["usuario_descripcion"].ToString();
                nombreArtistico = reader["usuario_nombreartist"].ToString();


                    
                
            }
            conn.Close();
            conn.Dispose();
            reader.Close();
        }

        public void getListaColab(string idColab)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM colaboracion INNER JOIN usuario on usuario.id_usuario = colaboracion.usuario_usuario_id WHERE colaboracion.cancion_cancion_id = '"+idColab+"'";
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista2.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Artista detalles = new Artista
                    {
                        id = reader["id_usuario"].ToString(),
                        usuario = reader["usuario_username"].ToString(),
                        foto = (byte[])reader["usuario_fotoperfil"],
                        fotoPortada = (byte[])reader["usuario_fportada"],
                        descripcion = reader["usuario_descripcion"].ToString(),
                        nombreArtistico = reader["usuario_nombreartist"].ToString()


                    };
                    lista2.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }
        public void getListaArtista(string where)
        {
            SqlConnection conn = Form1.GetConnection();
            //SqlConnection conn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT * FROM usuario " + where;
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();

            lista.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Artista detalles = new Artista
                    {                     
                        id = reader["id_usuario"].ToString(),
                        usuario = reader["usuario_username"].ToString(),
                        foto = (byte[])reader["usuario_fotoperfil"],
                        fotoPortada = (byte[])reader["usuario_fportada"],
                        descripcion = reader["usuario_descripcion"].ToString(),
                        nombreArtistico = reader["usuario_nombreartist"].ToString()


                    };
                    lista.Add(detalles);
                }
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
