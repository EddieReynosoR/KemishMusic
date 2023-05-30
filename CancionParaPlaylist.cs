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
    public partial class CancionParaPlaylist : UserControl
    {
        // ID correspondiente al control de usuario
        public static string id;
        public CancionParaPlaylist()
        {
            InitializeComponent();
        }

        // Agregar cancion seleccionada a una playlist
        private void btnAgregarCancionAPlaylist_Click(object sender, EventArgs e)
        {
                   


            string query = "INSERT INTO enlistar(cancion_cancion_id, playlist_playlist_id)VALUES(@cancion_cancion_id, @playlist_playlist_id)";

            //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            //stream.CopyTo(fileStream);

            //fileStream.Dispose();

            using (SqlConnection cn = Form1.GetConnection())
            {

                SqlCommand cmd = new SqlCommand(query, cn);

                cn.Open();


                cmd.Parameters.AddWithValue("@cancion_cancion_id", lblID.Text);

                cmd.Parameters.AddWithValue("@playlist_playlist_id", VerContenidoPlaylist.id);



                cmd.ExecuteNonQuery();


                
            }
            


            DialogResult dialog = MessageBox.Show("Canción añadida correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VerContenidoPlaylist contenido = new VerContenidoPlaylist();
            AgregarCancionesPlaylist agregar = new AgregarCancionesPlaylist();
            agregar.Hide();
            contenido.RefrescarPlaylist();

            if (dialog == DialogResult.OK)
            {
                
            }
        }

        // Obtener el nombre del artista de la cancion
        public string SeleccionarNombreArtista(string idArtista)
        {
            string nombre = "";
            SqlConnection cn = Form1.GetConnection();

            cn.Open();

            string query = "SELECT usuario.usuario_nombreartist FROM cancion INNER JOIN usuario on id_usuario = cancion.usuario_id_usuario WHERE cancion.cancion_id = '" + idArtista + "'";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                nombre = dr["usuario_nombreartist"].ToString();
            }

            cn.Close();

            return nombre;
        }

        // Desplegar datos de la cancion
        public void CancionDetalles(Cancion e)
        {
            lblID.Text = e.id;
            id = lblID.Text;

            picCancionAPlaylist.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            lblNombreCancion.Text = e.nombre;

            lblAutor.Text = SeleccionarNombreArtista(e.id);
        }
    }
}
