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
using System.ComponentModel.DataAnnotations;

namespace KemishMusic
{
    public partial class SignUp : Form
    {         
        public SignUp()
        {
            InitializeComponent();

            
        }

        // Agregar foto de perfil
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

        // Validar correo email
        public bool ValidateUsingEmailAddressAttribute(string emailAddress)
        {
            var emailValidation = new EmailAddressAttribute();
            return emailValidation.IsValid(emailAddress);
        }

        // Registro de usuario
        public void Registrarse(string archivoImagen, string archivoPortada)
        {
            if (archivoImagen == "")
                MessageBox.Show("Selecciona una imágen para tu foto de perfil.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (archivoPortada == "")
                MessageBox.Show("Selecciona una imágen para tu foto de portada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
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
                        if (txtUsuario.Text == "" || txtNombreArtistico.Text == "" || txtContra.Text == "" || txtNombre.Text == "" || txtCorreo.Text == "" || txtApellidoP.Text == "" || txtApellidoM.Text == "")
                            MessageBox.Show("Debes de llenar todos tus datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtContra.Text != txtContraConf.Text)
                            MessageBox.Show("Tus contraseñas no coinciden. Confirma tu contraseña de forma correcta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (!ValidateUsingEmailAddressAttribute(txtCorreo.Text))
                            MessageBox.Show("Tu correo electrónico no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
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
            }
            
        }

        // Click boton de registrarse
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse(label1.Text, label2.Text);
        }

        // Elegir foto de portada de tus archivos
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

        // Detectar simbolos especiales en los textbox
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
            else if(Char.IsDigit(e.KeyChar))
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

        // Regresar al Login
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Hide();

            Login login = new Login();

            login.Show();
        }
    }
}
