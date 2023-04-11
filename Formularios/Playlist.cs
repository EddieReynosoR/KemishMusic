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

            dlg.ShowDialog();

            txtImagen.Text = dlg.FileName;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarArchivo(txtImagen.Text, txtAudio.Text);
        }

        private void GuardarArchivo(string archivoImagen, string archivoAudio)
        {
            using(Stream stream = File.OpenRead(archivoImagen))
            {
                using (Stream stream2 = File.OpenRead(archivoAudio))
                {
                    FileStream fs = stream2 as FileStream;

                    byte[] buffer = new byte[stream.Length];



                    Form1 frm1 = new Form1();




                    stream.Read(buffer, 0, buffer.Length);

                    string nombre = txtNombre.Text;
                    string extn = new FileInfo(archivoAudio).Extension;

                    string nombreCancion = Path.GetFileName(archivoAudio);

                    string pathCancion = frm1.getPath(nombreCancion);




                    string query = "INSERT INTO Canciones(Nombre,Imagen,Audio)VALUES(@nombre,@imagen,@audio)";

                    //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                    //stream.CopyTo(fileStream);

                    //fileStream.Dispose();

                    using (SqlConnection cn = GetConnection())
                    {
                        SqlCommand cmd = new SqlCommand(query, cn);

                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;

                        cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = buffer;

                        cmd.Parameters.Add("@audio", SqlDbType.VarChar).Value = pathCancion;

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Canciones\\";

            
            File.Move(@archivoAudio, path + Path.GetFileName(path));
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
    }
}
