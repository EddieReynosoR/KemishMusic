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
        public static string id;
        public static event EventHandler ClickPlaylist;
        public PlaylistControl()
        {
            InitializeComponent();
        }

        private void PlaylistControl_Load(object sender, EventArgs e)
        {
            panelOpcionesPlaylist.Visible = false;
            if (playlistUsuarioID.Text == Usuario.id)
                btnEditarPlaylist.Visible = true;
        }

        public void PlaylistDetalles(PlaylistClase e)
        {
            lblID.Text = e.id;

            id = lblID.Text;

            picPlaylist.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            playlistNombre.Text = e.nombre;

            playlistUsuarioID.Text = e.usuarioID;
        }

        private void picPlaylist_Click(object sender, EventArgs e)
        {
            id = lblID.Text;

            if(ClickPlaylist != null)
            {
                ClickPlaylist(this, e);
            }
        }

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

        private void btnEditarPlaylist_Click(object sender, EventArgs e)
        {
            panelOpcionesPlaylist.Visible = false;
            id = lblID.Text;

            EditarPlaylist editar = new EditarPlaylist();
            editar.Show();
        }

        private void panelOpcionesPlaylist_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
