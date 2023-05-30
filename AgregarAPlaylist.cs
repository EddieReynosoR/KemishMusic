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
    public partial class AgregarAPlaylist : Form
    {
        public AgregarAPlaylist()
        {
            InitializeComponent();
        }

        // Cargar playlist a las que se puede insertar la cancion
        private void AgregarAPlaylist_Load(object sender, EventArgs e)
        {
            DetallesCancion();
            CartasCancion();
        }

        // Cargar los controles de usuario correspondientes
        public void CartasCancion()
        {
            if (PlaylistClase.lista4.Count == 0)
                lblMensajeCancion.Visible = true;
            else
            {
                lblMensajeCancion.Visible = false;
                foreach (PlaylistClase playlist in PlaylistClase.lista4)
                {
                    PlaylistParaCancion carta = new PlaylistParaCancion();


                    carta.PlaylistDetalles(playlist);



                    carta.Dock = DockStyle.Top;
                    panelPlaylistNOAsignadas.Controls.Add(carta);
                }
            }

            
        }

        // Obtener detalles de la playlist
        public void DetallesCancion()
        {
            PlaylistClase playlist = new PlaylistClase();
            playlist.getListaCancionesNoEnPlaylist(CancionSelect.id, Usuario.id);
        }
    }
}
