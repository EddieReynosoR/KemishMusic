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
    public partial class VerContenidoPlaylist : Form
    {
        // ID respectivo de la playlist y evento del formulario
        public static string id;
        public static event EventHandler PlaylistClick;
        public VerContenidoPlaylist()
        {
            InitializeComponent();
        }

        // Cargar datos de la playlist y sus respectivas canciones 
        private void VerContenidoPlaylist_Load(object sender, EventArgs e)
        {           
            DetallesPlaylist();
            RefrescarPlaylist();
        }

        // Cargar los datos de la playlist
        public void DetallesPlaylist()
        {
            PlaylistClase obtener = new PlaylistClase();
            obtener.GetDatosPlaylist(PlaylistControl.id);

            lblNombrePlaylist.Text = obtener.nombre;
            picPlaylistSelect.Image = (Bitmap)new ImageConverter().ConvertFrom(obtener.imagen);
            lblPropietario.Text = ObtenerNombrePropietario(obtener.id);
            lblID.Text = obtener.id;

            if (obtener.usuarioID == Usuario.id)
                btnInsertarCancion.Visible = true;
        }

        // Refrescar canciones en la playlist
        public void RefrescarPlaylist()
        {
            panelCancionesPlaylist.Controls.Clear();
            DetallesCancion();
            CartasCancion();
        }

        // Cargar controles de usuario de cada cancion en la playlist
        public void CartasCancion()
        {
            foreach (Cancion cancion in Cancion.lista4)
            {
                PlaylistRepro carta = new PlaylistRepro();


                carta.CancionDetalles(cancion);



                carta.Dock = DockStyle.Top;
                panelCancionesPlaylist.Controls.Add(carta);
            }
        }

        // Cargar detalles de cada cancion
        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getListaCancionesPlaylist(PlaylistControl.id);
        }

        // Obtener el nombre del propietario de la playlist
        public string ObtenerNombrePropietario(string idPropietario)
        {
            string admin = "";
            SqlConnection conn = Form1.GetConnection();

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            string sql = "SELECT usuario_nombreartist FROM playlist INNER JOIN usuario on id_usuario = playlist.usuario_id_usuario WHERE playlist_id = '" + idPropietario + "'";
            cmd.CommandText = sql;


            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    admin = reader["usuario_nombreartist"].ToString();

                }
                conn.Close();
                conn.Dispose();
            }

            return admin;
        }

        // Evento click para agregar una cancion a la playlist
        private void btnInsertarCancion_Click(object sender, EventArgs e)
        {
            panelCancionesPlaylist.Visible = false;
            id = lblID.Text;

            AgregarCancionesPlaylist editar = new AgregarCancionesPlaylist();
            editar.Show();
        }


        // Evento del boton para reproducir todas las canciones de la playlist
        private void btnReproducirPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.colaCanciones.Clear();
                foreach (Cancion cancion in Cancion.lista4)
                {
                    Form1.colaCanciones.AddLast(cancion);
                }

                if (PlaylistClick != null)
                    PlaylistClick(this, e);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay canciones para reproducir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
