using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
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
            LlenarGrid();
        }
        private DataClasses1DataContext conexion = new DataClasses1DataContext();
        void LlenarGrid()
        {
            DataGridView1.DataSource = conexion.LeerPlaylist();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtPlaylist.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
                SqlCommand consulta = new SqlCommand("SELECT playlist_id FROM playlist WHERE playlist_nombre=@playlist_nombre", conexion1);

                conexion1.Open();

                consulta.Parameters.AddWithValue("@playlist_nombre", txtPlaylist.Text);

                SqlDataReader rdr = consulta.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        lblPlaylist.Text = rdr[0].ToString();
                        
                    }
                }
                conexion1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede visualizar " + ex.ToString());
            }
        }
        void LlenarCanciones()
        {
            DataGridView2.DataSource = conexion.MostrarCancion();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            btnMostrar.Hide();
            DataGridView2.Show();
            DataGridView1.Hide();
            btnAgregar.Show();
            label2.Show();
            txtCancion.Show();
            btnBack.Show();
            txtAudio.Show();
            txtImagen.Show();
            lblCancion.Show();
            LlenarCanciones();
        }

        private void AgregarCanciones_Load(object sender, EventArgs e)
        {
            DataGridView2.Hide();
            btnAgregar.Hide();
            label2.Hide();
            txtCancion.Hide();
            btnBack.Hide();
            txtAudio.Hide();
            txtImagen.Hide();
            lblCancion.Hide();
        }
        SqlConnection conexion1 = new SqlConnection(@"Data Source=YAHIR\\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True");
        string datos = "SELECT cancion_audionombre, cancion_imagen,cancion_id FROM cancion WHERE cancion_nombre=@cancion_nombre";

        byte[] dataArray;
        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCancion.Text = DataGridView2.CurrentRow.Cells[0].Value.ToString();

                SqlCommand consulta = new SqlCommand(datos, conexion1);

                conexion1.Open();

                consulta.Parameters.AddWithValue("@cancion_nombre", txtCancion.Text);

                SqlDataReader rdr = consulta.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        txtAudio.Text = rdr[0].ToString();
                        dataArray = (byte[])rdr["cancion_imagen"];
                        lblCancion.Text = rdr["cancion_id"].ToString();
                        const string fileName = "Test#@@#.dat";

                        // Create random data to write to the file.

                        new Random().NextBytes(dataArray);

                        using (FileStream
                            fileStream = new FileStream(fileName, FileMode.Create))
                        {
                            // Write the data to the file, byte by byte.
                            for (int i = 0; i < dataArray.Length; i++)
                            {
                                fileStream.WriteByte(dataArray[i]);
                            }

                            // Set the stream position to the beginning of the file.
                            fileStream.Seek(0, SeekOrigin.Begin);

                            // Read and verify the data.
                            for (int i = 0; i < fileStream.Length; i++)
                            {
                                if (dataArray[i] != fileStream.ReadByte())
                                {
                                    MessageBox.Show("Error");
                                }
                            }
                            txtImagen.Text = fileStream.Name;
                        }
                    }
                }
                conexion1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede visualizar " + ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnMostrar.Show();
            DataGridView2.Hide();
            DataGridView1.Show();
            btnAgregar.Hide();
            label2.Hide();
            txtCancion.Hide();
            btnBack.Hide();
            DataGridView2.Hide();
            txtAudio.Hide();
            txtImagen.Hide();
            lblCancion.Hide();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int playlistId = Convert.ToInt32(lblPlaylist.Text);
            int cancionId = Convert.ToInt32(lblCancion.Text);

            conexion.InsertarCancionPlaylist3(playlistId, cancionId, txtPlaylist.Text, txtCancion.Text);

            
        }
        void LlenarPlaylist()
        {
            DataGridView2.DataSource = conexion.VerCancionPlaylist2(txtPlaylist.Text);
        }

        private void btnVerPlaylist_Click(object sender, EventArgs e)
        {
            LlenarPlaylist();
            DataGridView2.Show();
        }
    }
}
