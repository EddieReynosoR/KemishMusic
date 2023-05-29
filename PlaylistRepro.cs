using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KemishMusic
{
    public partial class PlaylistRepro : UserControl
    {
        public static string id;
        public PlaylistRepro()
        {
            InitializeComponent();
        }

        private void PlaylistRepro_Load(object sender, EventArgs e)
        {
            
        }

        public void CancionDetalles(Cancion e)
        {

            lblID.Text = e.id;

            id = lblID.Text;
            

            picCancionRep.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            lblNombreCancion.Text = e.nombre;

            if (e.usuarioID == Usuario.id)
                btnEliminarDEPlaylist.Visible = true;

        }

        private void btnEliminarDEPlaylist_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás segur@ de que quieres eliminar esta canción?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SqlConnection cn = Form1.GetConnection();
                cn.Open();

               

                SqlCommand elimina = new SqlCommand("DELETE FROM enlistar WHERE cancion_cancion_id=@cancion_cancion_id", cn);
                elimina.Parameters.AddWithValue("@cancion_cancion_id", lblID.Text);

                elimina.ExecuteNonQuery();             

            

                MessageBox.Show("Canción eliminada de la playlist.");

                cn.Close();




            }

        }
    }
}
