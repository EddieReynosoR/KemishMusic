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

        private void CancionesShow_Load(object sender, EventArgs e)
        {
            DetallesPlaylist();
            CartasPlaylists();
            DetallesCancion();
            CartasCancion();
        }
        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getListaCancionesUsuario(Usuario.id);
        }
        
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

        public void DetallesPlaylist()
        {
            PlaylistClase playlist = new PlaylistClase();
            playlist.getListaPlaylistUsuario(Usuario.id);
        }

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


        private void panelCancion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
