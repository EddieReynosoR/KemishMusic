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

namespace KemishMusic.Formularios
{
    public partial class Crear_Playlist : Form
    {
        public Crear_Playlist()
        {
            InitializeComponent();
        }
        

        // Seleccionar una imagen de tus archivos
        private void btnSeleccionarImagenPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "Image | *.jpg;*.png;*.jpeg";

                dlg.ShowDialog();

                lblRutaImagen.Text = dlg.FileName;

                picPlaylistNueva.Image = new Bitmap(dlg.FileName);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No seleccionaste ninguna imágen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Guardar playlist
        private void btnInsertarPlaylist_Click(object sender, EventArgs e)
        {
            GuardarPlaylist(lblRutaImagen.Text);
        }

        // Metodo para guardar la playlist en la base de datos
        public void GuardarPlaylist(string rutaImagen)
        {
            if (rutaImagen == "")
                MessageBox.Show("Debes seleccionar una imagen para la playlist.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(txtPlaylist.Text == "")
                MessageBox.Show("Debes añadir un nombre para la playlist.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                using (Stream stream = File.OpenRead(rutaImagen))
                {
                    byte[] buffer = new byte[stream.Length];







                    stream.Read(buffer, 0, buffer.Length);



                    PlaylistClase guardar = new PlaylistClase();

                    guardar.nombre = txtPlaylist.Text;


                    guardar.imagen = buffer;





                    string query = "INSERT INTO playlist(playlist_nombre, playlist_imagen, usuario_id_usuario)VALUES(@playlist_nombre, @playlist_imagen, @usuario_id_usuario)";

                    //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                    //stream.CopyTo(fileStream);

                    //fileStream.Dispose();

                    using (SqlConnection cn = Form1.GetConnection())
                    {

                        SqlCommand cmd = new SqlCommand(query, cn);

                        cn.Open();


                        cmd.Parameters.AddWithValue("@playlist_nombre", guardar.nombre);

                        cmd.Parameters.AddWithValue("@playlist_imagen", guardar.imagen);

                        cmd.Parameters.AddWithValue("@usuario_id_usuario", Usuario.id);


                        cmd.ExecuteNonQuery();



                    }
                }
                DialogResult dialog = MessageBox.Show("Playlist añadida correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dialog == DialogResult.OK)
                {
                    Application.Restart();
                }
                else
                    Application.Restart();
            }
        }

        // Validacion
        private void txtPlaylist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPlaylist.Text.Length > 29)
                MessageBox.Show("El nombre de la playlist no puede mayor de 30 carácteres de largo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
