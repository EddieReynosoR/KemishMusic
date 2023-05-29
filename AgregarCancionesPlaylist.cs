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
    public partial class AgregarCancionesPlaylist : Form
    {
        public AgregarCancionesPlaylist()
        {
            InitializeComponent();
        }

        private void AgregarCancionesPlaylist_Load(object sender, EventArgs e)
        {
            DetallesCancion();
            CartasCancion();
        }

        public void CartasCancion()
        {
            foreach (Cancion cancion in Cancion.lista5)
            {
                CancionParaPlaylist carta = new CancionParaPlaylist();


                carta.CancionDetalles(cancion);



                carta.Dock = DockStyle.Top;
                panelCancionesNOAgregadas.Controls.Add(carta);
            }
        }

        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getListaCancionesNoEnPlaylist(PlaylistControl.id);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCancionesNOAgregadas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
