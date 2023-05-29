using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KemishMusic
{
    public partial class Perfil : Form
    {
        public static string id;
        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            DetallesUsuario();
            DetallesCancion();
            CartasCancion();
            DetallesPlaylist();
            CartasPlaylist();
        }

        public void DetallesUsuario()
        {
            lblID.Text = verArtista.id;

            lblNombreUsuario.Text = verArtista.nombreArtistico;

            lblDescripcion.Text = verArtista.descripcion;

            ImageConverter converter = new ImageConverter();

            picFotoPerfil.Image = (Image)converter.ConvertFrom(verArtista.foto);
        }

        public void CartasCancion()
        {
            if (Cancion.lista2.Count == 0)
                lblMensajeCancion.Visible = true;
            else
            {
                lblMensajeCancion.Visible = false;
                foreach (Cancion cancion in Cancion.lista2)
                {
                    CancionSelect carta = new CancionSelect();


                    carta.CancionDetalles(cancion);



                    carta.Dock = DockStyle.Left;
                    panelCanciones.Controls.Add(carta);
                }
            }
        }

        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getListaCancionesUsuario(verArtista.id);
        }

        public void CartasPlaylist()
        {
            if (PlaylistClase.lista2.Count == 0)
                lblPlaylist.Visible = true;
            else
            {
                lblPlaylist.Visible = false;
                foreach (PlaylistClase playlist in PlaylistClase.lista2)
                {
                    PlaylistControl carta = new PlaylistControl();

                    carta.PlaylistDetalles(playlist);

                    carta.Dock = DockStyle.Left;
                    panelPlaylist.Controls.Add(carta);
                }
            }
        }

        public void DetallesPlaylist()
        {
            PlaylistClase playlist = new PlaylistClase();
            playlist.getListaPlaylistUsuario(verArtista.id);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            EditarUsuario editar = new EditarUsuario();

            editar.Show();
        }
    }
}
