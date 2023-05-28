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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        string where = "";
        string where2 = "";
        string where3 = "";
        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                panelCancionBusqueda.Focus();
        }

        public void DetallesArtista(string where)
        {
            Artista artista = new Artista();

            artista.getListaArtista(where);
        }

        public void DetallesCancion(string where)
        {
            Cancion cancion = new Cancion();
            cancion.getListaCancion(where);
        }

        public void ArtistaPanel()
        {
            if(Artista.lista.Count == 0)
            {
                lblMensajeArtista.Visible = true;
            }
            else
            {
                lblMensajeArtista.Visible = false;
                foreach (Artista artista in Artista.lista)
                {
                    ArtistaCard panelArtista = new ArtistaCard();

                   panelArtista.ArtistaDetalles(artista);

                    panelArtista.Dock = DockStyle.Left;
                    panelArtistasBusqueda.Controls.Add(panelArtista);
                }
            }
        }
        public void DetallesPlaylist(string where)
        {
            PlaylistClase playlist = new PlaylistClase();

            playlist.getListaPlaylist(where);
        }
        public void PlaylistPanel()
        {
            if (PlaylistClase.lista3.Count == 0)
            {
                lblMensajePlaylist.Visible = true;
            }
            else
            {
                lblMensajePlaylist.Visible = false;
                foreach (PlaylistClase playlist in PlaylistClase.lista3)
                {
                    PlaylistControl panelPlaylist = new PlaylistControl();

                    panelPlaylist.PlaylistDetalles(playlist);

                    panelPlaylist.Dock = DockStyle.Left;
                    panelPlaylistBusqueda.Controls.Add(panelPlaylist);
                }
            }
        }
        public void CancionPanel()
        {
            if (Cancion.lista3.Count == 0)
            {
                lblMensajeCancion.Visible = true;
            }
            else
            {
                lblMensajeCancion.Visible = false;
                foreach (Cancion cancion in Cancion.lista3)
                {
                    CancionSelect panelCancion = new CancionSelect();

                    panelCancion.CancionDetalles(cancion);

                    panelCancion.Dock = DockStyle.Left;
                    panelCancionBusqueda.Controls.Add(panelCancion);
                }
            }
        }


        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                where = "WHERE usuario_nombreartist LIKE '%" + txtBuscar.Text + "%' ";
                where2 = "WHERE usuario_nombreartist LIKE '%" + txtBuscar.Text + "%' OR cancion_nombre = '%" + txtBuscar.Text + "%'";
                where3 = "WHERE usuario_nombreartist LIKE '%" + txtBuscar.Text + "%' OR playlist_nombre = '%" + txtBuscar.Text + "%'";

                panelArtistasBusqueda.Controls.Clear();
                panelCancionBusqueda.Controls.Clear();
                panelPlaylistBusqueda.Controls.Clear();

                DetallesArtista(where);
                DetallesCancion(where2);
                DetallesPlaylist(where3);


                ArtistaPanel();
                CancionPanel();
                PlaylistPanel();


            }
            else
            {
                where = "";
                where2 = "";
                where3 = "";
                panelCancionBusqueda.Controls.Clear();
                panelArtistasBusqueda.Controls.Clear();
                panelPlaylistBusqueda.Controls.Clear();

                DetallesArtista(where);
                DetallesCancion(where2);
                DetallesPlaylist(where3);


                ArtistaPanel();
                CancionPanel();
                PlaylistPanel();

            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length < 1)
            {
                where = "";
                where2 = "";
                where3 = "";
                Artista.lista.Clear();
                Cancion.lista3.Clear();
                PlaylistClase.lista3.Clear();
            }
            panelArtistasBusqueda.Controls.Clear();
            panelCancionBusqueda.Controls.Clear();
            panelPlaylistBusqueda.Controls.Clear();

            DetallesArtista(where);
            DetallesCancion(where2);
            DetallesPlaylist(where3);

            CancionPanel();
            ArtistaPanel();
            PlaylistPanel();
            
                
            // DetallesArtista(where);
            // ArtistaPanel();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            DetallesArtista(where);
            ArtistaPanel();

            DetallesCancion(where2);
            CancionPanel();

            DetallesPlaylist(where3);
            PlaylistPanel();
        }
    }
}
