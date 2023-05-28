using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace KemishMusic
{
    public partial class EditarPlaylist : Form
    {
        public EditarPlaylist()
        {
            InitializeComponent();
        }
        
        public void EditarPlaylistFuncion(string archivoImagen)
        {
            using (Stream stream = File.OpenRead(archivoImagen))
            {


                byte[] buffer = new byte[stream.Length];







                stream.Read(buffer, 0, buffer.Length);


                PlaylistClase guardar = new PlaylistClase();

                guardar.nombre = txtPlaylistEditar.Text;


                guardar.imagen = buffer;





                string query = "UPDATE playlist SET playlist_nombre = @playlist_nombre, playlist_imagen = @playlist_imagen WHERE playlist_id ='" + PlaylistControl.id + "'";

                //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                //stream.CopyTo(fileStream);

                //fileStream.Dispose();

                using (SqlConnection cn = Form1.GetConnection())
                {

                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();


                    cmd.Parameters.AddWithValue("@playlist_nombre", guardar.nombre);

                    cmd.Parameters.AddWithValue("@playlist_imagen", guardar.imagen);




                    cmd.ExecuteNonQuery();



                }

                DialogResult dialog = MessageBox.Show("Playlist editada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dialog == DialogResult.OK)
                {
                    Application.Restart();
                }
                else
                    Application.Restart();
            }
        }

        public void EditarPlaylistFuncion2(string nombrePlaylist)
        {
            


            








            PlaylistClase guardar = new PlaylistClase();

            guardar.nombre = txtPlaylistEditar.Text;


            





            string query = "UPDATE playlist SET playlist_nombre = @playlist_nombre WHERE playlist_id ='" + PlaylistControl.id + "'";

            //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            //stream.CopyTo(fileStream);

            //fileStream.Dispose();

            using (SqlConnection cn = Form1.GetConnection())
            {

                SqlCommand cmd = new SqlCommand(query, cn);

                cn.Open();


                cmd.Parameters.AddWithValue("@playlist_nombre", guardar.nombre);





                cmd.ExecuteNonQuery();



            }

            DialogResult dialog = MessageBox.Show("Playlist editada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialog == DialogResult.OK)
            {
                Application.Restart();
            }
            else
                Application.Restart();
            
        }
        private void btnEditarPlaylist_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (lblRutaImagen.Text != "")
                    EditarPlaylistFuncion(lblRutaImagen.Text); 
                else if(txtPlaylistEditar.Text != playlistNombreAnterior && lblRutaImagen.Text =="")
                    EditarPlaylistFuncion2(txtPlaylistEditar.Text);
                else
                    MessageBox.Show("No hay cambios realizados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        string playlistNombreAnterior;
        private void EditarPlaylist_Load(object sender, EventArgs e)
        {
            playlistNombreAnterior = txtPlaylistEditar.Text;

            DetallesPlaylist();
        }

        public void DetallesPlaylist()
        {
            PlaylistClase playlist = new PlaylistClase();
            playlist.GetDatosPlaylist(PlaylistControl.id);

            txtPlaylistEditar.Text = playlist.nombre;

            picPlaylistEditar.Image = (Bitmap)new ImageConverter().ConvertFrom(playlist.imagen);
        }
        

        private void btnSeleccionarImagenPlaylistEditar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Image | *.jpg;*.png;*.jpeg";

            dlg.ShowDialog();

            lblRutaImagen.Text = dlg.FileName;

            picPlaylistEditar.Image = new Bitmap(dlg.FileName);
        }

        private void btnEliminarPlaylist_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás segur@ de que quieres eliminar esta playlist?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SqlConnection cn = Form1.GetConnection();
                cn.Open();

                SqlCommand elimina3 = new SqlCommand("DELETE FROM enlistar WHERE playlist_playlist_id=@playlist_playlist_id", cn);
                elimina3.Parameters.AddWithValue("@playlist_playlist_id", PlaylistControl.id);

                elimina3.ExecuteNonQuery();

                SqlCommand elimina2 = new SqlCommand("DELETE FROM playlist WHERE playlist_id=@playlist_id", cn);
                elimina2.Parameters.AddWithValue("@playlist_id", PlaylistControl.id);

                elimina2.ExecuteNonQuery();


                MessageBox.Show("Playlist eliminada.");

                cn.Close();




            }
        }
    }
}
