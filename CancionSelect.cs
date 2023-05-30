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
    public partial class CancionSelect : UserControl
    {
        // ID y eventos correspondientes a cada control de usuario de la cancion
        public static string id;
        public static event EventHandler ImagenClick;
        public static event EventHandler CancionClick;
        public static event EventHandler AgregarFila;

        



        public CancionSelect()
        {
            InitializeComponent();
        }

        // Evento al dar click a la cancion
        private void picCancion_Click(object sender, EventArgs e)
        {
            id = lblID.Text;

            if (ImagenClick != null)
                ImagenClick(this, e);

           
        }

        // Obtener nombres del usuario
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

        // Obtener detalles de la cancion
        public void CancionDetalles(Cancion e)
        {

            lblID.Text = e.id;

            id = lblID.Text;

            picCancion.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            cancionNombre.Text = e.nombre;

            lblArtista.Text = SeleccionarNombreArtista(e.usuarioID);
            SeleccionarColab(e.id);

            lblIDUsuario.Text = e.usuarioID;
        }

        // Obtener colaboraciones
        public void SeleccionarColab(string idColab)
        {
            SqlConnection cn = Form1.GetConnection();

            cn.Open();

            string query = "SELECT usuario.usuario_nombreartist FROM cancion INNER JOIN colaboracion on colaboracion.cancion_cancion_id = cancion_id INNER JOIN usuario on id_usuario = colaboracion.usuario_usuario_id WHERE cancion.cancion_id = '" + idColab + "'";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lblArtista.Text += ", " + dr["usuario_nombreartist"].ToString();
            }

            cn.Close();
        }

        // Capacidad de editar una cancion solo si el ususario es dueño de esta
        private void CancionSelect_Load(object sender, EventArgs e)
        {
            //lblID.Hide();           
            panelOpciones.Visible = false;

            if (lblIDUsuario.Text == Usuario.id)
                btnEditarCancion.Visible = true;

        }


        // Mostrar opciones de la cancion
        private void picOpciones_Click(object sender, EventArgs e)
        {
            id = lblID.Text;

            if (CancionClick != null)
            {
                CancionClick(this, e);
            }

            panelOpciones.Visible = false;


        }

        // Evento agregar a la cola
        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            id = lblID.Text;            

            if (AgregarFila != null)
                AgregarFila(this, e);

            panelOpciones.Visible = false;
        }

        // Mostrar y ocultar opciones

        bool showOpciones = false;
        private void iconOpciones_Click(object sender, EventArgs e)
        {
            if (!showOpciones)
            {
                panelOpciones.Visible = true;
                showOpciones = true;
            }
            else
            {
                panelOpciones.Visible = false;
                showOpciones = false;
            }
            
        }

        // Boton editar cancion
        private void btnEditarCancion_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
            id = lblID.Text;

            EditarCancion editar = new EditarCancion();
            editar.Show();
        }

        // Evento para agregar cancion a una playlist
        private void btnAgregarAPlaylist_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
            id = lblID.Text;

            AgregarAPlaylist editar = new AgregarAPlaylist();
            editar.Show();
        }
    }
}
