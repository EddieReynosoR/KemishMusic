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
    public partial class Crear_Playlist : Form
    {
        public Crear_Playlist()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCanciones ag = new AgregarCanciones();


            ag.Show();

            this.Hide();

        }
        int id;

        private void Crear_Playlist_Load(object sender, EventArgs e)
        {
            if (label1.Text != "label1")
            {
                id = Convert.ToInt32(label1.Text);

                Cancion cancion = Cancion.lista[id - 1];

                

                CancionSelect carta = new CancionSelect();

                carta.CancionDetalles(cancion);


                carta.Dock = DockStyle.Left;
                panelAgregar.Controls.Add(carta);

            }

        }
    }
}
