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

namespace KemishMusic
{
    public partial class SignUp : Form
    {     
       
        public SignUp()
        {
            InitializeComponent();

            
        }

        private void scrollVertical_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Image | *.jpg;*.png;*.jpeg";

            dlg.ShowDialog();

            label1.Text = dlg.FileName;
            picUsuario.Image = new Bitmap(dlg.FileName);
        }

        public void Registrarse(string archivoImagen, string archivoPortada)
        {
            
            using (Stream stream = File.OpenRead(archivoImagen))
            {
                using (Stream stream2 = File.OpenRead(archivoPortada))
                {
                    FileStream fs = stream as FileStream;
                    FileStream fs2 = stream2 as FileStream;

                    byte[] buffer = new byte[stream.Length];
                    byte[] buffer2 = new byte[stream2.Length];







                    stream.Read(buffer, 0, buffer.Length);
                    stream2.Read(buffer2, 0, buffer2.Length);



                    string nombreUsuario = txtUsuario.Text;
                    string nombreArtistico = txtNombreArtistico.Text;
                    string contraUsuario = txtContra.Text;
                    string nombresUsuario = txtNombre.Text;
                    string correoElec = txtCorreo.Text;
                    string apellidoPUsuario = txtApellidoP.Text;
                    string apelllidoMUsuario = txtApellidoM.Text;









                    string query = "INSERT INTO usuario(usuario_username, usuario_contra, usuario_nombre, usuario_apellidop, usuario_apellidom, usuario_fotoperfil, usuario_correo, usuario_fnacimiento, usuario_descripcion, usuario_fportada, usuario_nombreartist)VALUES(@usuario_username, @usuario_contra, @usuario_nombre, @usuario_apellidop, @usuario_apellidom, @usuario_fotoperfil, @usuario_correo, @usuario_fnacimiento, @usuario_descripcion, @usuario_fportada, @usuario_nombreartist)";



                    //Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=KemishMusic;Integrated Security=true;

                    //Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True;

                    using (SqlConnection cn = Form1.GetConnection())
                    {
                        SqlCommand cmd = new SqlCommand(query, cn);

                        cmd.Parameters.AddWithValue("@usuario_username", nombreUsuario);

                        cmd.Parameters.AddWithValue("@usuario_contra", contraUsuario);

                        cmd.Parameters.AddWithValue("@usuario_nombre", nombresUsuario);

                        cmd.Parameters.AddWithValue("@usuario_apellidop", apellidoPUsuario);

                        cmd.Parameters.AddWithValue("@usuario_apellidom", apelllidoMUsuario);

                        cmd.Parameters.AddWithValue("@usuario_fotoperfil", buffer);

                        cmd.Parameters.AddWithValue("@usuario_correo", correoElec);

                        cmd.Parameters.AddWithValue("@usuario_fnacimiento", fechaNacimientoT.Value.Date);

                        cmd.Parameters.AddWithValue("@usuario_descripcion", "");

                        cmd.Parameters.AddWithValue("@usuario_fportada", buffer2);

                        cmd.Parameters.AddWithValue("@usuario_nombreartist", nombreArtistico);


                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Te has registrado con exito.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Login loginForm = new Login();
                    Close();
                    loginForm.Show();
                }
            }
            
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse(label1.Text, label2.Text);
        }

        private void btnInsertarPortada_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Image | *.jpg;*.png;*.jpeg";

            dlg.ShowDialog();

            label2.Text = dlg.FileName;
            picPortada.Image = new Bitmap(dlg.FileName);
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
