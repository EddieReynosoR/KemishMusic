using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KemishMusic.Formularios
{
    public partial class AgregarCanciones : Form
    {
        public AgregarCanciones()
        {
            InitializeComponent();
        }
        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getList();
        }

        SqlConnection conexion = Form1.GetConnection();

        public void CartasCancion()
        {
           // Cancion cancion = Cancion.lista[1];
            
                CancionSelect carta = new CancionSelect();

               // carta.CancionDetalles(cancion);


                carta.Dock = DockStyle.Left;
                //panelAgregar.Controls.Add(carta);
            
        }

        private void AgregarCanciones_Load(object sender, EventArgs e)
        {
            DetallesCancion();
            //CartasCancion();
        }
        int id;
        Crear_Playlist cP = new Crear_Playlist();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("select * from cancion WHERE cancion_nombre = @cancion_nombre", conexion);

            conexion.Open();

            //consulta.Parameters.AddWithValue("@cancion_nombre", txtNombre.Text);

            SqlDataReader rdr = consulta.ExecuteReader();

            while (rdr.Read())
            {
                //lblID.Text = rdr[0].ToString();
               
            }
            //id = Convert.ToInt32(lblID.Text);
            Cancion cancion = Cancion.lista[id-2];
           // Cancion cancion = Cancion.lista[id - 1];

            //((System.Windows.Forms.Label)cP.Controls["label1"]).Text = lblID.Text;

            //i++;
            CancionSelect carta = new CancionSelect();

            carta.CancionDetalles(cancion);


            carta.Dock = DockStyle.Left;
            //panelAgregar.Controls.Add(carta);



            MessageBox.Show("Consulta Realizada");



            conexion.Close();
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            cP.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
