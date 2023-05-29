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

        public static string id;
        public static event EventHandler ImagenClick;
        public static event EventHandler CancionClick;
        public static event EventHandler AgregarFila;

        ToolTip tooltip1 = new ToolTip();



        public CancionSelect()
        {
            InitializeComponent();
        }


        private void picCancion_Click(object sender, EventArgs e)
        {
            id = lblID.Text;

            if (ImagenClick != null)
                ImagenClick(this, e);

           
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

        public void CancionDetalles(Cancion e)
        {

            lblID.Text = e.id;

            id = lblID.Text;

            picCancion.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            cancionNombre.Text = e.nombre;

            lblArtista.Text = SeleccionarNombreArtista(e.usuarioID);

            lblIDUsuario.Text = e.usuarioID;
        }

        private void CancionSelect_Load(object sender, EventArgs e)
        {
            //lblID.Hide();           
            panelOpciones.Visible = false;

            if (lblIDUsuario.Text == Usuario.id)
                btnEditarCancion.Visible = true;

        }

        private void CancionSelect_Click(object sender, EventArgs e)
        {
        }

        private void picOpciones_Click(object sender, EventArgs e)
        {
            id = lblID.Text;

            if (CancionClick != null)
            {
                CancionClick(this, e);
            }

            panelOpciones.Visible = false;


        }

        private void picOpciones_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            id = lblID.Text;            

            if (AgregarFila != null)
                AgregarFila(this, e);

            panelOpciones.Visible = false;
        }

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

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditarCancion_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
            id = lblID.Text;

            EditarCancion editar = new EditarCancion();
            editar.Show();
        }

        private void btnAgregarAPlaylist_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
            id = lblID.Text;

            AgregarAPlaylist editar = new AgregarAPlaylist();
            editar.Show();
        }
    }
}
