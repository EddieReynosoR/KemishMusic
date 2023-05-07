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

        public void Registrarse(string archivoImagen)
        {
            
            using (Stream stream = File.OpenRead(archivoImagen))
            {
                FileStream fs = stream as FileStream;

                byte[] buffer = new byte[stream.Length];







                stream.Read(buffer, 0, buffer.Length);



                string nombreUsuario = txtUsuario.Text;
                string contraUsuario = txtContra.Text;
                string nombresUsuario = txtNombre.Text;
                string correoElec = txtCorreo.Text;
                string apellidoPUsuario = txtApellidoP.Text;
                string apelllidoMUsuario = txtApellidoM.Text;

                

                





                string query = "INSERT INTO usuario(usuario_username, usuario_contra, usuario_nombre, usuario_apellidop, usuario_apellidom, usuario_fotoperfil, usuario_correo, usuario_fnacimiento, usuario_megusta, usuario_descripcion)VALUES(@usuario_username, @usuario_contra, @usuario_nombre, @usuario_apellidop, @usuario_apellidom, @usuario_fotoperfil, @usuario_correo, @usuario_fnacimiento, @usuario_megusta, @usuario_descripcion)";



                //Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=KemishMusic;Integrated Security=true;
               

                using (SqlConnection cn = new SqlConnection(@"Data Source=YAHIR\SQLEXPRESS;Initial Catalog=KemishMusic;Integrated Security=True"))
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

                    cmd.Parameters.AddWithValue("@usuario_megusta", 0);

                    cmd.Parameters.AddWithValue("@usuario_descripcion", "");


                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Te has registrado con exito.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Login loginForm = new Login();
                Hide();
                loginForm.Show();
            }
            
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse(label1.Text);
        }
    }
}
