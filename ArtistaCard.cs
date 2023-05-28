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
    public partial class ArtistaCard : UserControl
    {
        public static string id;
        public static event EventHandler ClickArtista;
        public ArtistaCard()
        {
            InitializeComponent();
        }

        private void picArtistaCarta_Click(object sender, EventArgs e)
        {
            id = lblID.Text;

            if (ClickArtista != null)
                ClickArtista(this, e);
        }

        private void ArtistaCard_Load(object sender, EventArgs e)
        {

        }

        public void ArtistaDetalles(Artista e)
        {
            lblID.Text = e.id;

            id = lblID.Text;

            picArtistaCarta.Image = (Bitmap)new ImageConverter().ConvertFrom(e.foto);

            lblArtistaNombre.Text = e.nombreArtistico;
        }

        private void ArtistaCard_Click(object sender, EventArgs e)
        {
            id = lblID.Text;

            if (ClickArtista != null)
                ClickArtista(this, e);
        }
    }
}
