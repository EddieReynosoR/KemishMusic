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
        private DataClasses1DataContext conexion = new DataClasses1DataContext();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            conexion.InsertarPlaylist(txtPlaylist.Text);

            MessageBox.Show("Playlist creada para poder verla ve a  Mis Playlist");

            txtPlaylist.Clear();
        }
        
        

        private void Crear_Playlist_Load(object sender, EventArgs e)
        {
            

        }
    }
}
