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
    public partial class PlaylistControl : UserControl
    {
        // ID respectivo de la playlist y evento click del control de usuario
        public static string id;
        public static event EventHandler ClickPlaylist;
        public PlaylistControl()
        {
            InitializeComponent();
        }

        // Poder editar la playlist solo si es del usuario correspondiente
        private void PlaylistControl_Load(object sender, EventArgs e)
        {
            panelOpcionesPlaylist.Visible = false;
            if (playlistUsuarioID.Text == Usuario.id)
                btnEditarPlaylist.Visible = true;
        }

        // Cargar datos de la playlist
        public void PlaylistDetalles(PlaylistClase e)
        {
            lblID.Text = e.id;

            id = lblID.Text;

            picPlaylist.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            playlistNombre.Text = e.nombre;

            playlistUsuarioID.Text = e.usuarioID;
        }

        // Evento click de la playlist
        private void picPlaylist_Click(object sender, EventArgs e)
        {
            id = lblID.Text;

            if(ClickPlaylist != null)
            {
                ClickPlaylist(this, e);
            }
        }

        // Mostrar y ocultar opciones de la playlist
        bool showPanelOpcionesPlaylist = false;
        private void iconOpcionesPlaylist_Click(object sender, EventArgs e)
        {
            if (!showPanelOpcionesPlaylist)
            {
                panelOpcionesPlaylist.Visible = true;
                showPanelOpcionesPlaylist = true;
            }
            else
            {
                panelOpcionesPlaylist.Visible = false;
                showPanelOpcionesPlaylist = false;
            }
        }

        // Editar playlist
        private void btnEditarPlaylist_Click(object sender, EventArgs e)
        {
            panelOpcionesPlaylist.Visible = false;
            id = lblID.Text;

            EditarPlaylist editar = new EditarPlaylist();
            editar.Show();
        }

    }
}
