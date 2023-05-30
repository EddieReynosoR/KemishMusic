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
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace KemishMusic
{
    public partial class EditarUsuario : Form
    {
        // Obtener lista de audios de las canciones del usuario
        public static List<string> listaAudios = new List<string>();
        public EditarUsuario()
        {
            InitializeComponent();
        }

        // Cargar datos del usuario a editar
        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Usuario.usuario;
            txtNombreArtistico.Text = Usuario.nombreArtistico;
            txtContra.Text = Usuario.contra;
            txtNombre.Text = Usuario.nombre;
            txtCorreo.Text = Usuario.correo;
            txtApellidoP.Text = Usuario.apellidop;
            txtApellidoM.Text = Usuario.apellidom;

            fechaNacimientoT.Value = Usuario.fechaNacimiento;

            picUsuario.Image = (Bitmap)new ImageConverter().ConvertFrom(Usuario.foto);

            picPortada.Image = (Bitmap)new ImageConverter().ConvertFrom(Usuario.fotoPortada);
        }

        // Validar correo email
        public bool ValidateUsingEmailAddressAttribute(string emailAddress)
        {
            var emailValidation = new EmailAddressAttribute();
            return emailValidation.IsValid(emailAddress);
        }

        // FUNCIONES PARA EDITAR USUARIO
        public void EditarUsuarioFuncion(string fotoperfil, string fotoportada)
        {
            
            using (Stream stream = File.OpenRead(fotoperfil))
            {
                using (Stream stream2 = File.OpenRead(fotoportada))
                {
                    FileStream fs = stream as FileStream;
                    FileStream fs2 = stream2 as FileStream;

                    byte[] buffer = new byte[stream.Length];
                    byte[] buffer2 = new byte[stream2.Length];







                    stream.Read(buffer, 0, buffer.Length);
                    stream2.Read(buffer2, 0, buffer2.Length);
                    SqlConnection cn = Form1.GetConnection();

                    cn.Open();

                    string query = "UPDATE usuario SET usuario_username = @usuario_username, usuario_contra = @usuario_contra, usuario_nombre = @usuario_nombre,  usuario_apellidop = @usuario_apellidop, usuario_apellidom = @usuario_apellidom, usuario_fotoperfil = @usuario_fotoperfil, usuario_correo = @usuario_correo, usuario_fnacimiento = @usuario_fnacimiento, usuario_descripcion = @usuario_descripcion, usuario_fportada = @usuario_fportada, usuario_nombreartist = @usuario_nombreartist WHERE id_usuario = '" + Usuario.id + "'";

                    
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@usuario_username", txtUsuario.Text);

                    cmd.Parameters.AddWithValue("@usuario_contra", txtContra.Text);

                    cmd.Parameters.AddWithValue("@usuario_nombre", txtNombre.Text);

                    cmd.Parameters.AddWithValue("@usuario_apellidop", txtApellidoP.Text);

                    cmd.Parameters.AddWithValue("@usuario_apellidom", txtApellidoM.Text);

                    cmd.Parameters.AddWithValue("@usuario_fotoperfil", buffer);

                    cmd.Parameters.AddWithValue("@usuario_correo", txtCorreo.Text);

                    cmd.Parameters.AddWithValue("@usuario_fnacimiento", fechaNacimientoT.Value.Date);

                    cmd.Parameters.AddWithValue("@usuario_descripcion", txtDescripcion.Text);

                    cmd.Parameters.AddWithValue("@usuario_fportada", buffer2);

                    cmd.Parameters.AddWithValue("@usuario_nombreartist", txtNombreArtistico.Text);

                    cmd.ExecuteNonQuery();



                    cn.Close();

                    MessageBox.Show("Datos actualizados. Cerrando sesión...");


                    Application.Restart();
                    
                }
            }
            
        }
        public void EditarUsuarioFuncion2(string fotoportada)
        {
            
            using (Stream stream2 = File.OpenRead(fotoportada))
            {
                FileStream fs2 = stream2 as FileStream;

                byte[] buffer2 = new byte[stream2.Length];







                stream2.Read(buffer2, 0, buffer2.Length);
                SqlConnection cn = Form1.GetConnection();

                cn.Open();

                string query = "UPDATE usuario SET usuario_username = @usuario_username, usuario_contra = @usuario_contra, usuario_nombre = @usuario_nombre,  usuario_apellidop = @usuario_apellidop, usuario_apellidom = @usuario_apellidom, usuario_correo = @usuario_correo, usuario_fnacimiento = @usuario_fnacimiento, usuario_descripcion = @usuario_descripcion, usuario_fportada = @usuario_fportada, usuario_nombreartist = @usuario_nombreartist WHERE id_usuario = '" + Usuario.id + "'";


                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@usuario_username", txtUsuario.Text);

                cmd.Parameters.AddWithValue("@usuario_contra", txtContra.Text);

                cmd.Parameters.AddWithValue("@usuario_nombre", txtNombre.Text);

                cmd.Parameters.AddWithValue("@usuario_apellidop", txtApellidoP.Text);

                cmd.Parameters.AddWithValue("@usuario_apellidom", txtApellidoM.Text);


                cmd.Parameters.AddWithValue("@usuario_correo", txtCorreo.Text);

                cmd.Parameters.AddWithValue("@usuario_fnacimiento", fechaNacimientoT.Value.Date);

                cmd.Parameters.AddWithValue("@usuario_descripcion", txtDescripcion.Text);

                cmd.Parameters.AddWithValue("@usuario_fportada", buffer2);

                cmd.Parameters.AddWithValue("@usuario_nombreartist", txtNombreArtistico.Text);

                cmd.ExecuteNonQuery();



                cn.Close();

                MessageBox.Show("Datos actualizados. Cerrando sesión...");


                Application.Restart();
            }
            
        }
        public void EditarUsuarioFuncion3(string fotoperfil)
        {
            using (Stream stream = File.OpenRead(fotoperfil))
            {
                
                FileStream fs = stream as FileStream;

                byte[] buffer = new byte[stream.Length];







                stream.Read(buffer, 0, buffer.Length);
                SqlConnection cn = Form1.GetConnection();

                cn.Open();

                string query = "UPDATE usuario SET usuario_username = @usuario_username, usuario_contra = @usuario_contra, usuario_nombre = @usuario_nombre,  usuario_apellidop = @usuario_apellidop, usuario_apellidom = @usuario_apellidom, usuario_fotoperfil = @usuario_fotoperfil, usuario_correo = @usuario_correo, usuario_fnacimiento = @usuario_fnacimiento, usuario_descripcion = @usuario_descripcion, usuario_nombreartist = @usuario_nombreartist WHERE id_usuario = '" + Usuario.id + "'";


                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@usuario_username", txtUsuario.Text);

                cmd.Parameters.AddWithValue("@usuario_contra", txtContra.Text);

                cmd.Parameters.AddWithValue("@usuario_nombre", txtNombre.Text);

                cmd.Parameters.AddWithValue("@usuario_apellidop", txtApellidoP.Text);

                cmd.Parameters.AddWithValue("@usuario_apellidom", txtApellidoM.Text);

                cmd.Parameters.AddWithValue("@usuario_fotoperfil", buffer);

                cmd.Parameters.AddWithValue("@usuario_correo", txtCorreo.Text);

                cmd.Parameters.AddWithValue("@usuario_fnacimiento", fechaNacimientoT.Value.Date);

                cmd.Parameters.AddWithValue("@usuario_descripcion", txtDescripcion.Text);


                cmd.Parameters.AddWithValue("@usuario_nombreartist", txtNombreArtistico.Text);

                cmd.ExecuteNonQuery();



                cn.Close();

                MessageBox.Show("Datos actualizados. Cerrando sesión...");


                Application.Restart();
                
            }
        }

        public void EditarUsuarioFuncion4()
        {
            SqlConnection cn = Form1.GetConnection();

            cn.Open();

            string query = "UPDATE usuario SET usuario_username = @usuario_username, usuario_contra = @usuario_contra, usuario_nombre = @usuario_nombre,  usuario_apellidop = @usuario_apellidop, usuario_apellidom = @usuario_apellidom, usuario_correo = @usuario_correo, usuario_fnacimiento = @usuario_fnacimiento, usuario_descripcion = @usuario_descripcion, usuario_nombreartist = @usuario_nombreartist WHERE id_usuario = '" + Usuario.id + "'";


            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@usuario_username", txtUsuario.Text);

            cmd.Parameters.AddWithValue("@usuario_contra", txtContra.Text);

            cmd.Parameters.AddWithValue("@usuario_nombre", txtNombre.Text);

            cmd.Parameters.AddWithValue("@usuario_apellidop", txtApellidoP.Text);

            cmd.Parameters.AddWithValue("@usuario_apellidom", txtApellidoM.Text);

            cmd.Parameters.AddWithValue("@usuario_correo", txtCorreo.Text);

            cmd.Parameters.AddWithValue("@usuario_fnacimiento", fechaNacimientoT.Value.Date);

            cmd.Parameters.AddWithValue("@usuario_descripcion", txtDescripcion.Text);


            cmd.Parameters.AddWithValue("@usuario_nombreartist", txtNombreArtistico.Text);

            cmd.ExecuteNonQuery();



            cn.Close();

            MessageBox.Show("Datos actualizados. Cerrando sesión...");


            Application.Restart();

            
        }

        // Boton para editar usuario, con validacion y posibles opciones de edicion
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtNombreArtistico.Text == "" || txtContra.Text == "" || txtNombre.Text == "" || txtCorreo.Text == "" || txtApellidoP.Text == "" || txtApellidoM.Text == "" || txtContra.Text == "")
                MessageBox.Show("Debes de llenar todos tus datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);           
            else if (!ValidateUsingEmailAddressAttribute(txtCorreo.Text))
                MessageBox.Show("Tu correo electrónico no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (label1.Text != "" && label2.Text != "")
                    EditarUsuarioFuncion(label1.Text, label2.Text);
                else if (label1.Text == "" && label2.Text != "")
                    EditarUsuarioFuncion2(label2.Text);
                else if (label1.Text != "" && label2.Text == "")
                    EditarUsuarioFuncion3(label1.Text);
                else if (label1.Text == "" && label2.Text == "")
                    EditarUsuarioFuncion4();
            }
            
        }

        // Insertar nueva foto desde los archivos
        private void btnInsertarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "Image | *.jpg;*.png;*.jpeg";

                dlg.ShowDialog();

                label1.Text = dlg.FileName;
                picUsuario.Image = new Bitmap(dlg.FileName);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No seleccionaste ninguna imágen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Insertar nueva foto desde los archivos
        private void btnInsertarPortada_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "Image | *.jpg;*.png;*.jpeg";

                dlg.ShowDialog();

                label2.Text = dlg.FileName;
                picPortada.Image = new Bitmap(dlg.FileName);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No seleccionaste ninguna imágen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Obtener una lista de las canciones del usuario que se va a eliminar
        public void ObtenerCancionParaEliminar(string idUsuario)
        {
            SqlConnection cn = Form1.GetConnection();

            cn.Open();

            string query = "SELECT cancion_audionombre FROM cancion WHERE usuario_id_usuario = '" + idUsuario + "'";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listaAudios.Add(dr["cancion_audionombre"].ToString());
            }

            cn.Close();
        }

        // Eliminar usuario evento click
        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Estás segur@ de que quieres eliminar tu cuenta junto con todos sus datos y canciones?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {


                    SqlConnection cn = Form1.GetConnection();
                    cn.Open();
                    

                    

                    ObtenerCancionParaEliminar(Usuario.id);


                    SqlCommand elimina3 = new SqlCommand("DELETE FROM cancion WHERE usuario_id_usuario=@usuario_id_usuario", cn);
                    elimina3.Parameters.AddWithValue("@usuario_id_usuario", Usuario.id);

                    elimina3.ExecuteNonQuery();

                    Form1 frm1 = new Form1();
                    string path = frm1.PathGlobal();

                    foreach (string cancionAudio in listaAudios)
                    {
                        File.SetAttributes(Path.Combine(path, Path.GetFileName(cancionAudio)), FileAttributes.Normal);
                        File.Delete(Path.Combine(path, Path.GetFileName(cancionAudio)));
                    }




                    SqlCommand elimina4 = new SqlCommand("DELETE FROM enlistar WHERE playlist_playlist_id IN (SELECT playlist_id FROM playlist WHERE usuario_id_usuario = '" + Usuario.id + "')", cn);

                    elimina4.ExecuteNonQuery();

                    SqlCommand elimina2 = new SqlCommand("DELETE FROM playlist WHERE playlist_id IN (SELECT playlist_id FROM playlist WHERE usuario_id_usuario = @usuario_id_usuario)", cn);
                    elimina2.Parameters.AddWithValue("@usuario_id_usuario", Usuario.id);

                    elimina2.ExecuteNonQuery();









                    SqlCommand elimina = new SqlCommand("DELETE FROM colaboracion WHERE usuario_usuario_id = '" + Usuario.id + "'", cn);

                    elimina.ExecuteNonQuery();


                    SqlCommand elimina5 = new SqlCommand("DELETE FROM usuario WHERE id_usuario = '" + Usuario.id + "'", cn);

                    elimina5.ExecuteNonQuery();







                    MessageBox.Show("Cuenta eliminada.");

                    cn.Close();




                    Application.Restart();
                }
            }
            catch (UnauthorizedAccessException)
            {
                
                MessageBox.Show("Hubo un problema al tratar de eliminar tu cuenta. Intentalo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            catch (SqlException)
            {
                MessageBox.Show("Hubo un problema al tratar de eliminar tu cuenta. Intentalo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Checar si se insertan simbolos especiales en un textbox
        private bool HasSpecialChars(string yourString)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (yourString.Contains(item)) return true;
            }

            return false;
        }

        // VALIDACION DE LOS TEXTBOX
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.Text.Length > 29)
                MessageBox.Show("Tu nombre de usuario no puede tener más de 30 carácteres de largo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (HasSpecialChars(e.KeyChar.ToString()))
            {
                MessageBox.Show("No puedes incluir carácteres especiales en tu nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtNombreArtistico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombreArtistico.Text.Length > 29)
                MessageBox.Show("Tu nombre de usuario artístico no puede tener más de 30 carácteres de largo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (HasSpecialChars(e.KeyChar.ToString()))
            {
                MessageBox.Show("No puedes incluir carácteres especiales en tu nombre artístico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HasSpecialChars(e.KeyChar.ToString()))
            {
                MessageBox.Show("No puedes incluir carácteres especiales en tu contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text.Length > 29)
                MessageBox.Show("Tus nombres no pueden tener más de 30 carácteres de largo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (HasSpecialChars(e.KeyChar.ToString()))
            {
                MessageBox.Show("No puedes incluir carácteres especiales en tus nombres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No puedes incluir números en tus nombres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCorreo.Text.Length > 49)
                MessageBox.Show("Tus correo electrónico no puede tener más de 50 carácteres de largo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtApellidoP.Text.Length > 29)
                MessageBox.Show("Tus apellido paterno no puede tener más de 30 carácteres de largo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (HasSpecialChars(e.KeyChar.ToString()))
            {
                MessageBox.Show("No puedes incluir carácteres especiales en tu apellido paterno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No puedes incluir números en tu apellido paterno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtApellidoM.Text.Length > 29)
                MessageBox.Show("Tus apellido paterno no puede tener más de 30 carácteres de largo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (HasSpecialChars(e.KeyChar.ToString()))
            {
                MessageBox.Show("No puedes incluir carácteres especiales en tu apellido materno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No puedes incluir números en tu apellido materno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtApellidoM.Text.Length > 49)
                MessageBox.Show("La descripción de tu perfil no puede ser mayor a 50 carácteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
