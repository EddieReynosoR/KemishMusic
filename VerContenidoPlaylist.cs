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
        public static string id;
        public static event EventHandler PlaylistClick;
        public VerContenidoPlaylist()
        {
            InitializeComponent();
        }

        private void VerContenidoPlaylist_Load(object sender, EventArgs e)
        {           
            DetallesPlaylist();
            DetallesCancion();
            CartasCancion();
        }

        public void DetallesPlaylist()
        {
            PlaylistClase obtener = new PlaylistClase();
            obtener.GetDatosPlaylist(PlaylistControl.id);

            lblNombrePlaylist.Text = obtener.nombre;
            picPlaylistSelect.Image = (Bitmap)new ImageConverter().ConvertFrom(obtener.imagen);
            lblPropietario.Text = ObtenerNombrePropietario(obtener.id);

            if (obtener.usuarioID == Usuario.id)
                btnInsertarCancion.Visible = true;
        }

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

        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getListaCancionesPlaylist(PlaylistControl.id);
        }

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

        private void btnInsertarCancion_Click(object sender, EventArgs e)
        {
            lblID.Text = PlaylistControl.id;
            panelCancionesPlaylist.Visible = false;
            id = lblID.Text;

            AgregarCancionesPlaylist editar = new AgregarCancionesPlaylist();
            editar.Show();
        }

        private void btnReproducirPlaylist_Click(object sender, EventArgs e)
        {
            Form1.colaCanciones.Clear();
            foreach(Cancion cancion in Cancion.lista4)
            {
                Form1.colaCanciones.AddLast(cancion);
            }

            if (PlaylistClick != null)
                PlaylistClick(this, e);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }
    }
}
