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

        // Cargar los datos del usuario que haya iniciado sesion
        private void Perfil_Load(object sender, EventArgs e)
        {
            DetallesUsuario();
            DetallesCancion();
            CartasCancion();
            DetallesPlaylist();
            CartasPlaylist();

            if (verArtista.id == Usuario.id)
                btnEditarPerfil.Visible = true;
            else
                btnEditarPerfil.Visible = false;
        }

        // Obtener los datos del usuario
        public void DetallesUsuario()
        {
            lblID.Text = verArtista.id;

            lblNombreUsuario.Text = verArtista.nombreArtistico;

            lblDescripcion.Text = verArtista.descripcion;

            ImageConverter converter = new ImageConverter();

            picFotoPerfil.Image = (Image)converter.ConvertFrom(verArtista.foto);
        }

        // Cargar canciones del usuario
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

        // Obtener los datos de las canciones del usuario
        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getListaCancionesUsuario(verArtista.id);
        }

        // Cargar las playlist del usuario
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

        // Obtener los datos de las playlist del usuario
        public void DetallesPlaylist()
        {
            PlaylistClase playlist = new PlaylistClase();
            playlist.getListaPlaylistUsuario(verArtista.id);
        }

        // Boton editar perfil
        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            EditarUsuario editar = new EditarUsuario();

            editar.Show();
        }
    }
}
