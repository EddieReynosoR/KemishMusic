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
    public partial class PlaylistRepro : UserControl
    {
        // ID correspondiente a cada control de usuario
        public static string id;
        public PlaylistRepro()
        {
            InitializeComponent();
        }



        // Cargar el nombre del artista correspondiente a la cancion
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

        // Cargar datos de la cancion
        public void CancionDetalles(Cancion e)
        {

            lblID.Text = e.id;

            id = lblID.Text;
            

            picCancionRep.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            lblNombreCancion.Text = e.nombre;

            lblAutor.Text = SeleccionarNombreArtista(e.usuarioID);

            PlaylistClase obtener = new PlaylistClase();
            obtener.GetDatosPlaylist(PlaylistControl.id);

            if (obtener.usuarioID == Usuario.id)
                btnEliminarDEPlaylist.Visible = true;

        }

        // Eliminar cancion correspondiente de la playlist
        private void btnEliminarDEPlaylist_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás segur@ de que quieres eliminar esta canción?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SqlConnection cn = Form1.GetConnection();
                cn.Open();

               

                SqlCommand elimina = new SqlCommand("DELETE FROM enlistar WHERE cancion_cancion_id=@cancion_cancion_id", cn);
                elimina.Parameters.AddWithValue("@cancion_cancion_id", lblID.Text);

                elimina.ExecuteNonQuery();             

            

                MessageBox.Show("Canción eliminada de la playlist.");

                VerContenidoPlaylist contenido = new VerContenidoPlaylist();
                contenido.RefrescarPlaylist();


                cn.Close();


                

            }

        }
    }
}
