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
        public static string id;
        public CancionParaPlaylist()
        {
            InitializeComponent();
        }

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


                cmd.Parameters.AddWithValue("@cancion_cancion_id", id);

                cmd.Parameters.AddWithValue("@playlist_playlist_id", VerContenidoPlaylist.id);



                cmd.ExecuteNonQuery();


                
            }
            


            DialogResult dialog = MessageBox.Show("Canción añadida correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialog == DialogResult.OK)
            {
                
            }
        }

        private void CancionParaPlaylist_Load(object sender, EventArgs e)
        {

        }

        public void CancionDetalles(Cancion e)
        {
            lblID.Text = e.id;
            id = lblID.Text;

            picCancionAPlaylist.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            lblNombreCancion.Text = e.nombre;
        }
    }
}
