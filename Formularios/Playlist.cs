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
        public List<string> listaColaboradores = new List<string>();
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

            picCancion.Image = new Bitmap(dlg.FileName);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarArchivo(txtImagen.Text, txtAudio.Text);
        }


        public void RellenarComboBoxColaboradores()
        {
            SqlConnection cn = Form1.GetConnection();

            cn.Open();

            string query = "SELECT id_usuario, usuario_nombreartist FROM usuario WHERE id_usuario != '" + Usuario.id +"'";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbColaboradores.Items.Add(dr["id_usuario"].ToString()+" "+dr["usuario_nombreartist"].ToString());
            }

            cn.Close();
        }

        public void GuardarArchivo(string archivoImagen, string archivoAudio)
        {
            Form1 frm1 = new Form1();
            if(txtNombre.Text == "")
                MessageBox.Show("La canción debe de tener un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (archivoAudio == "")
                MessageBox.Show("Debes seleccionar un archivo de audio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (archivoImagen == "")
                MessageBox.Show("Debes seleccionar un archivo para la imagen de portada para la canción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
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
                        guardar.audio = nombreCancion;


                        guardar.imagen = buffer;

                        guardar.fecha = DateTime.Now.Date.ToString();




                        string query = "INSERT INTO cancion(cancion_nombre,cancion_imagen,cancion_audionombre,cancion_fechaestreno, usuario_id_usuario)VALUES(@nombre,@imagen,@audio,@fecha, @usuario_id_usuario)";

                        //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                        //stream.CopyTo(fileStream);

                        //fileStream.Dispose();

                        using (SqlConnection cn = Form1.GetConnection())
                        {

                            SqlCommand cmd = new SqlCommand(query, cn);

                            cn.Open();


                            cmd.Parameters.AddWithValue("@nombre", guardar.nombre);

                            cmd.Parameters.AddWithValue("@imagen", guardar.imagen);

                            cmd.Parameters.AddWithValue("@audio", guardar.audio);

                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now.Date);

                            cmd.Parameters.AddWithValue("@usuario_id_usuario", Usuario.id);


                            cmd.ExecuteNonQuery();


                            if (cmbColaboradores.SelectedIndex != -1)
                            {

                                using (SqlConnection cn2 = Form1.GetConnection())
                                {
                                    string query2;
                                    query2 = "INSERT INTO colaboracion (cancion_cancion_id, usuario_usuario_id) VALUES ((SELECT MAX(cancion_id) FROM cancion), @usuario_usuario_id)";
                                    foreach (string colaborador in listaColaboradores)
                                    {

                                        SqlCommand cmd2 = new SqlCommand(query2, cn2);

                                        cn2.Open();



                                        cmd2.Parameters.AddWithValue("@usuario_usuario_id", colaborador.Split()[0]);



                                        cmd2.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                }



                string path = frm1.PathGlobal();


                File.Copy(@archivoAudio, Path.Combine(path, Path.GetFileName(archivoAudio)), true);
                File.SetAttributes(Path.Combine(path, Path.GetFileName(archivoAudio)), FileAttributes.Normal);


                DialogResult dialog = MessageBox.Show("Canción añadida correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dialog == DialogResult.OK)
                {
                    Application.Restart();
                }
                else
                    Application.Restart();
            }
        }
        

        

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.ShowDialog();

            txtAudio.Text = dlg.FileName;
        }

        private void Playlist_Load(object sender, EventArgs e)
        {
            RellenarComboBoxColaboradores();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertarColab_Click(object sender, EventArgs e)
        {
            if (cmbColaboradores.SelectedIndex == -1)
                MessageBox.Show("No se ha seleccionado a ningún artista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                listaColaboradores.Add(cmbColaboradores.SelectedItem.ToString());

                lblListaColab.Text = "";


                foreach (string colaborador in listaColaboradores)
                {
                    lblListaColab.Text += colaborador.Split()[1] + "\n";
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text.Length > 29)
                MessageBox.Show("El nombre de la canción no puede mayor de 30 carácteres de largo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
