using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KemishMusic.Formularios
{
    public partial class CancionesShow : Form
    {
        public CancionesShow()
        {
            InitializeComponent();
        }

        // Cargar las canciones registradas
        private void CancionesShow_Load(object sender, EventArgs e)
        {
            DetallesPlaylist();
            CartasPlaylists();
            DetallesCancion();
            CartasCancion();
        }

        // Obtener las canciones de la lista correspondiente del usuario
        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getListaCancionesUsuario(Usuario.id);
        }
        
        // Se seleccionan las canciones, si no hay, se muestra un mensaje
        public void CartasCancion()
        {
            if (Cancion.lista2.Count == 0)
                lblMensajeCancionBiblio.Visible = true;
            else
            {
                lblMensajeCancionBiblio.Visible = false;
                foreach (Cancion cancion in Cancion.lista2)
                {

                    CancionSelect carta = new CancionSelect();

                    carta.CancionDetalles(cancion);


                    carta.Dock = DockStyle.Left;
                    panelCancion.Controls.Add(carta);
                }
            }
        }


        // Obtener las playlist registradas del usuario
        public void DetallesPlaylist()
        {
            PlaylistClase playlist = new PlaylistClase();
            playlist.getListaPlaylistUsuario(Usuario.id);
        }

        // Generacion de controles de usuario
        public void CartasPlaylists()
        {
            if (PlaylistClase.lista2.Count == 0)
                lblMensajePlaylistBiblio.Visible = true;
            else
            {
                lblMensajePlaylistBiblio.Visible = false;
                foreach (PlaylistClase playlist in PlaylistClase.lista2)
                {
                    PlaylistControl carta = new PlaylistControl();

                    carta.PlaylistDetalles(playlist);


                    carta.Dock = DockStyle.Left;
                    panelPlaylist.Controls.Add(carta);
                }
            }
        }


        
    }
}
