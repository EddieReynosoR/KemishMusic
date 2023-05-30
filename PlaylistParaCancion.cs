using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KemishMusic
{
    public partial class PlaylistParaCancion : UserControl
    {
        // ID correspondiente de la playlist
        public static string id;
        public PlaylistParaCancion()
        {
            InitializeComponent();
        }


        // Agregar a playlist, evento
        private void btnAgregarAPlaylist_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO enlistar(cancion_cancion_id, playlist_playlist_id)VALUES(@cancion_cancion_id, @playlist_playlist_id)";

            //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            //stream.CopyTo(fileStream);

            //fileStream.Dispose();

            using (SqlConnection cn = Form1.GetConnection())
            {

                SqlCommand cmd = new SqlCommand(query, cn);

                cn.Open();


                cmd.Parameters.AddWithValue("@cancion_cancion_id", CancionSelect.id);

                cmd.Parameters.AddWithValue("@playlist_playlist_id", lblID.Text);



                cmd.ExecuteNonQuery();



            }



            DialogResult dialog = MessageBox.Show("Canción añadida correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialog == DialogResult.OK)
            {

            }
        }

        // Obtener el nombre del artista de la playlist
        public string SeleccionarNombreArtista(string idArtista)
        {
            string nombre = "";
            SqlConnection cn = Form1.GetConnection();

            cn.Open();

            string query = "SELECT usuario_nombreartist FROM usuario WHERE id_usuario = '" + idArtista + "'";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                nombre = dr["usuario_nombreartist"].ToString();
            }

            cn.Close();

            return nombre;
        }

        // Cargar detalles de la playlist
        public void PlaylistDetalles(PlaylistClase e)
        {
            lblID.Text = e.id;
            id = lblID.Text;

            picCancionAPlaylist.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            lblNombrePlaylist.Text = e.nombre;
            lblAutorPlaylist.Text = SeleccionarNombreArtista(e.usuarioID);
        }
    }
}
