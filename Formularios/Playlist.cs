using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace KemishMusic.Formularios
{
    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Image | *.jpg;*.png;*.jpeg";

            dlg.ShowDialog();

            txtImagen.Text = dlg.FileName;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarArchivo(txtImagen.Text, txtAudio.Text);
        }

        public void GuardarArchivo(string archivoImagen, string archivoAudio)
        {
            Form1 frm1 = new Form1();

            using (Stream stream = File.OpenRead(archivoImagen))
            {
                using (Stream stream2 = File.OpenRead(archivoAudio))
                {
                    FileStream fs = stream2 as FileStream;

                    byte[] buffer = new byte[stream.Length];







                    stream.Read(buffer, 0, buffer.Length);

                    string extn = new FileInfo(archivoAudio).Extension;

                    string nombreCancion = Path.GetFileName(archivoAudio);

                    Cancion guardar = new Cancion();

                    guardar.nombre = txtNombre.Text;
                    guardar.audio = frm1.getPath(nombreCancion);

                    guardar.imagen = buffer;




                    string query = "INSERT INTO Canciones(Nombre,Imagen,Audio)VALUES(@nombre,@imagen,@audio)";

                    //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                    //stream.CopyTo(fileStream);

                    //fileStream.Dispose();

                    using (SqlConnection cn = GetConnection())
                    {
                        SqlCommand cmd = new SqlCommand(query, cn);

                        cmd.Parameters.AddWithValue("@nombre", guardar.nombre);

                        cmd.Parameters.AddWithValue("@imagen", guardar.imagen);

                        cmd.Parameters.AddWithValue("@audio", guardar.audio);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }


            string path = frm1.Path();


            File.Copy(@archivoAudio, Path.Combine(path, Path.GetFileName(archivoAudio)));
        }
        

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=KemishMusic;Integrated Security=true;");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.ShowDialog();

            txtAudio.Text = dlg.FileName;
        }

        private void Playlist_Load(object sender, EventArgs e)
        {

        }
    }
}
