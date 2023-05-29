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
    public partial class MusicaRepr : UserControl
    {
        public static string id;
        public string estatus;
        public static event EventHandler CancionClick;

        public MusicaRepr()
        {
            InitializeComponent();
        }

        public void CancionDetalles(Cancion e)
        {

            lblID.Text = e.id;

            id = lblID.Text;


            if(e == Form1.cancionSiguiente.Value)
                lblEstado.Text = "Reproduciendo";

            picCancionRep.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            lblNombreCancion.Text = e.nombre;

            SeleccionarColab(e.id);
            lblAutor.Text = SeleccionarNombreArtista(e.usuarioID);

        }
        public string SeleccionarNombreArtista(string idArtista)
        {
            string nombreArtista = "";
            SqlConnection cn = Form1.GetConnection();

            cn.Open();

            string query = "SELECT usuario_nombreartist FROM usuario WHERE id_usuario = '" + idArtista + "'";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                nombreArtista = dr["usuario_nombreartist"].ToString();
            }

            cn.Close();

            return nombreArtista;
        }
        public void SeleccionarColab(string idColab)
        {
            SqlConnection cn = Form1.GetConnection();

            cn.Open();

            string query = "SELECT usuario.usuario_nombreartist FROM cancion INNER JOIN colaboracion on colaboracion.cancion_cancion_id = cancion_id INNER JOIN usuario on id_usuario = colaboracion.usuario_usuario_id WHERE cancion.cancion_id = '" + idColab + "'";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lblAutor.Text += ", " + dr["usuario_nombreartist"].ToString();
            }

            cn.Close();
        }
        private void MusicaRepro_Load(object sender, EventArgs e)
        {

        }

        private void MusicaRepro_Click(object sender, EventArgs e)
        {
            
        }

        private void lblNombreCancion_Click(object sender, EventArgs e)
        {

        }

        private void MusicaRepro_MouseHover(object sender, EventArgs e)
        {
            //MusicaRepro.BackColor = Color.Gray;
        }

        private void MusicaRepro_MouseLeave(object sender, EventArgs e)
        {
            //MusicaRepro.BackColor = Color.LightGray;
        }

        private void MusicaRepro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MusicaRepro_Click_1(object sender, EventArgs e)
        {
            id = lblID.Text;
            // estatus = lblEstado.Text;
            
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
