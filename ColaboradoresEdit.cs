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
    public partial class ColaboradoresEdit : UserControl
    {
        // ID respectivo
        public static string id;
        public ColaboradoresEdit()
        {
            InitializeComponent();
        }

        // Obtener detalles del colaborador
        public void ColabDetalles(Artista e)
        {
            lblID.Text = e.id;
            lblNombreColab.Text = e.nombreArtistico;

            id = lblID.Text;         

        }

        // Boton para eliminar colab
        private void btnEliminarColab_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás segur@ de que quieres eliminar esta colaboración?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SqlConnection cn = Form1.GetConnection();
                cn.Open();




                SqlCommand elimina = new SqlCommand("DELETE FROM colaboracion WHERE usuario_usuario_id=@usuario_usuario_id AND cancion_cancion_id = @cancion_cancion_id", cn);
                elimina.Parameters.AddWithValue("@usuario_usuario_id", lblID.Text);
                elimina.Parameters.AddWithValue("@cancion_cancion_id", CancionSelect.id);

                elimina.ExecuteNonQuery();



                MessageBox.Show("Colaboración eliminada.");

                cn.Close();

                Application.Restart();
            }
        }

    }
}
