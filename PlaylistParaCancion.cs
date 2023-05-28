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
        public static string id;
        public PlaylistParaCancion()
        {
            InitializeComponent();
        }

        private void PlaylistParaCancion_Load(object sender, EventArgs e)
        {

        }

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
        public void PlaylistDetalles(PlaylistClase e)
        {
            lblID.Text = e.id;
            id = lblID.Text;

            picCancionAPlaylist.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            lblNombrePlaylist.Text = e.nombre;
        }
    }
}
