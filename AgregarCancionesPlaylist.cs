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

        // Cargar canciones en el form
        private void AgregarCancionesPlaylist_Load(object sender, EventArgs e)
        {
            DetallesCancion();
            CartasCancion();
        }

        // Mostrar canciones disponibles para agregar a la playlist
        public void CartasCancion()
        {
            if (Cancion.lista5.Count == 0)
                lblMensajeCancion.Visible = true;
            else
            {
                lblMensajeCancion.Visible = false;
                foreach (Cancion cancion in Cancion.lista5)
                {
                    CancionParaPlaylist carta = new CancionParaPlaylist();


                    carta.CancionDetalles(cancion);



                    carta.Dock = DockStyle.Top;
                    panelCancionesNOAgregadas.Controls.Add(carta);
                }
            }
        }

        // Cargas detalles de la cancion
        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getListaCancionesNoEnPlaylist(PlaylistControl.id);
        }


    }
}
