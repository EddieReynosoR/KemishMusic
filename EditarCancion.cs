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

namespace KemishMusic
{
    public partial class EditarCancion : Form
    {
        public EditarCancion()
        {
            InitializeComponent();
        }

        private void EditarCancion_Load(object sender, EventArgs e)
        {
            DetallesCancion();
            RellenarComboBoxColab();
            DetallesColaborador();
            MostrarColabs();
        }

        public void RellenarComboBoxColab()
        {
            SqlConnection cn = Form1.GetConnection();

            cn.Open();

            string query = "SELECT id_usuario, usuario_nombreartist FROM usuario WHERE NOT EXISTS( SELECT id_usuario, usuario_nombreartist FROM usuario INNER JOIN colaboracion on colaboracion.usuario_usuario_id != id_usuario INNER JOIN cancion on cancion_id = colaboracion.cancion_cancion_id WHERE cancion.cancion_id = '"+CancionSelect.id+"' AND id_usuario !=  colaboracion.usuario_usuario_id) AND id_usuario != '"+Usuario.id+"' GROUP BY id_usuario, usuario_nombreartist";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               cmbColabsEditar.Items.Add(dr["id_usuario"].ToString() + " " + dr["usuario_nombreartist"].ToString());
            }

            cn.Close();
        }

        string cancionAnteior;
        string nombreCancion;
        
        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.ReproducirCancion(CancionSelect.id);

            txtNombreCancionEditar.Text = cancion.nombre;

            nombreCancion = txtNombreCancionEditar.Text;
            txtAudioEditar.Text = cancion.audio;

            cancionAnteior = cancion.audio;

            picCancionEditar.Image = (Bitmap)new ImageConverter().ConvertFrom(cancion.imagen);
        }
        public void DetallesColaborador()
        {
            Artista colab = new Artista();
            colab.getListaColab(CancionSelect.id);
        }
        public void MostrarColabs()
        {
            foreach (Artista colab in Artista.lista2)
            {
                ColaboradoresEdit editColab = new ColaboradoresEdit();

                editColab.ColabDetalles(colab);


                editColab.Dock = DockStyle.Top;
                panelColaboradoresEdit.Controls.Add(editColab);
            }
        }

        private void btnInsertarColaborador_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO colaboracion (cancion_cancion_id, usuario_usuario_id) VALUES (@cancion_cancion_id, @usuario_usuario_id)";

            if (cmbColabsEditar.SelectedIndex == -1)
                MessageBox.Show("No se ha seleccionado a ningún artista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                using (SqlConnection cn = Form1.GetConnection())
                {
                    string idColab = cmbColabsEditar.SelectedItem.ToString().Split()[0];
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@cancion_cancion_id", CancionSelect.id);

                    cmd.Parameters.AddWithValue("@usuario_usuario_id", idColab);



                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                DialogResult result = MessageBox.Show("Se registro la nueva colaboración con éxito. Cambios guardados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }

        private void btnSeleccionarAudio_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.ShowDialog();

                txtAudioEditar.Text = dlg.FileName;

                btnEditarCancion.Enabled = true;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No seleccionaste ningun archivo de audio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "Image | *.jpg;*.png;*.jpeg";

                dlg.ShowDialog();

                lblRutaImagen.Text = dlg.FileName;

                picCancionEditar.Image = new Bitmap(dlg.FileName);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No seleccionaste ninguna imágen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void EditarCancionFuncion(string archivoAudio, string archivoImagen)
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

                    guardar.nombre = txtNombreCancionEditar.Text;
                    guardar.audio = nombreCancion;


                    guardar.imagen = buffer;

                    guardar.fecha = DateTime.Now.Date.ToString();




                    string query = "UPDATE cancion SET cancion_nombre = @cancion_nombre, cancion_imagen = @cancion_imagen, cancion_audionombre = @cancion_audionombre, cancion_fechaestreno = @cancion_fechaestreno WHERE cancion_id ='" + CancionSelect.id + "'";

                    //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                    //stream.CopyTo(fileStream);

                    //fileStream.Dispose();

                    using (SqlConnection cn = Form1.GetConnection())
                    {

                        SqlCommand cmd = new SqlCommand(query, cn);

                        cn.Open();


                        cmd.Parameters.AddWithValue("@cancion_nombre", guardar.nombre);

                        cmd.Parameters.AddWithValue("@cancion_imagen", guardar.imagen);

                        cmd.Parameters.AddWithValue("@cancion_audionombre", guardar.audio);

                        cmd.Parameters.AddWithValue("@cancion_fechaestreno", DateTime.Now.Date);


                        cmd.ExecuteNonQuery();


                        
                    }

                    
                }
                

                
            }
            string eliminarArchivoAnterior = frm1.PathGlobal();

            File.SetAttributes(Path.Combine(eliminarArchivoAnterior, Path.GetFileName(cancionAnteior)), FileAttributes.Normal);
            File.Delete(Path.Combine(eliminarArchivoAnterior, Path.GetFileName(cancionAnteior)));

            string path = frm1.PathGlobal();

            
            File.Copy(@archivoAudio, Path.Combine(path, Path.GetFileName(archivoAudio)), true);
            File.SetAttributes(Path.Combine(path, Path.GetFileName(archivoAudio)), FileAttributes.Normal);
            


            DialogResult dialog = MessageBox.Show("Canción editada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialog == DialogResult.OK)
            {
                Application.Restart();
            }
            
        }


        public void EditarCancionFuncion2(string archivoAudio)
        {
            Form1 frm1 = new Form1();
            
            using (Stream stream2 = File.OpenRead(archivoAudio))
            {
                FileStream fs = stream2 as FileStream;

                







                

                string extn = new FileInfo(archivoAudio).Extension;

                string nombreCancion = Path.GetFileName(archivoAudio);

                Cancion guardar = new Cancion();

                guardar.nombre = txtNombreCancionEditar.Text;
                guardar.audio = nombreCancion;


                guardar.fecha = DateTime.Now.Date.ToString();




                string query = "UPDATE cancion SET cancion_nombre = @cancion_nombre, cancion_audionombre = @cancion_audionombre, cancion_fechaestreno = @cancion_fechaestreno WHERE cancion_id ='" + CancionSelect.id + "'";

                //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                //stream.CopyTo(fileStream);

                //fileStream.Dispose();

                using (SqlConnection cn = Form1.GetConnection())
                {

                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();


                    cmd.Parameters.AddWithValue("@cancion_nombre", guardar.nombre);

                    cmd.Parameters.AddWithValue("@cancion_audionombre", guardar.audio);

                    cmd.Parameters.AddWithValue("@cancion_fechaestreno", DateTime.Now.Date);


                    cmd.ExecuteNonQuery();



                }
                
            }




            string eliminarArchivoAnterior = frm1.PathGlobal();

            File.SetAttributes(Path.Combine(eliminarArchivoAnterior, Path.GetFileName(cancionAnteior)), FileAttributes.Normal);
            File.Delete(Path.Combine(eliminarArchivoAnterior, Path.GetFileName(cancionAnteior)));

            string path = frm1.PathGlobal();


            File.Copy(@archivoAudio, Path.Combine(path, Path.GetFileName(archivoAudio)), true);
            File.SetAttributes(Path.Combine(path, Path.GetFileName(archivoAudio)), FileAttributes.Normal);



            DialogResult dialog = MessageBox.Show("Canción editada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialog == DialogResult.OK)
            {
                Application.Restart();
            }


            
            
        }

        public void EditarCancionFuncion3()
        {

            Cancion guardar = new Cancion();

            guardar.nombre = txtNombreCancionEditar.Text;


            guardar.fecha = DateTime.Now.Date.ToString();




            string query = "UPDATE cancion SET cancion_nombre = @cancion_nombre, cancion_fechaestreno = @cancion_fechaestreno WHERE cancion_id ='" + CancionSelect.id + "'";

            //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            //stream.CopyTo(fileStream);

            //fileStream.Dispose();

            using (SqlConnection cn = Form1.GetConnection())
            {

                SqlCommand cmd = new SqlCommand(query, cn);

                cn.Open();


                cmd.Parameters.AddWithValue("@cancion_nombre", guardar.nombre);


                cmd.Parameters.AddWithValue("@cancion_fechaestreno", DateTime.Now.Date);


                cmd.ExecuteNonQuery();



            }
            



            DialogResult dialog = MessageBox.Show("Canción editada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialog == DialogResult.OK)
            {
                Application.Restart();
            }
            else
                Application.Restart();
        }

        public void EditarCancionFuncion4(string archivoImagen)
        {
            Form1 frm1 = new Form1();
            using (Stream stream = File.OpenRead(archivoImagen))
            {
                

                byte[] buffer = new byte[stream.Length];







                stream.Read(buffer, 0, buffer.Length);


                Cancion guardar = new Cancion();

                guardar.nombre = txtNombreCancionEditar.Text;


                guardar.imagen = buffer;

                guardar.fecha = DateTime.Now.Date.ToString();




                string query = "UPDATE cancion SET cancion_nombre = @cancion_nombre, cancion_imagen = @cancion_imagen, cancion_fechaestreno = @cancion_fechaestreno WHERE cancion_id ='" + CancionSelect.id + "'";

                //var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                //stream.CopyTo(fileStream);

                //fileStream.Dispose();

                using (SqlConnection cn = Form1.GetConnection())
                {

                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();


                    cmd.Parameters.AddWithValue("@cancion_nombre", guardar.nombre);

                    cmd.Parameters.AddWithValue("@cancion_imagen", guardar.imagen);


                    cmd.Parameters.AddWithValue("@cancion_fechaestreno", DateTime.Now.Date);


                    cmd.ExecuteNonQuery();



                }

                DialogResult dialog = MessageBox.Show("Canción editada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dialog == DialogResult.OK)
                {
                    Application.Restart();
                }
                else
                    Application.Restart();

            }

            
        }


        private void btnEditarCancion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCancionEditar.Text == "")
                    MessageBox.Show("El nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtAudioEditar.Text == "")
                    MessageBox.Show("No se ha seleccionado ningún audio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro que quieres guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (lblRutaImagen.Text != "" && txtAudioEditar.Text != cancionAnteior)
                            EditarCancionFuncion(txtAudioEditar.Text, lblRutaImagen.Text);
                        else if (lblRutaImagen.Text == "" && txtAudioEditar.Text != cancionAnteior)
                            EditarCancionFuncion2(txtAudioEditar.Text);
                        else if (txtNombreCancionEditar.Text != nombreCancion && lblRutaImagen.Text == "" && txtAudioEditar.Text == cancionAnteior)
                            EditarCancionFuncion3();
                        else if (lblRutaImagen.Text != "" && txtAudioEditar.Text == cancionAnteior)
                            EditarCancionFuncion4(lblRutaImagen.Text);
                        else
                            MessageBox.Show("No hay cambios realizados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Hubo un problema al tratar de editar la canción. Intentalo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarCancion_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Estás segur@ de que quieres eliminar esta canción?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {

                    SqlConnection cn = Form1.GetConnection();
                    cn.Open();

                    SqlCommand elimina3 = new SqlCommand("DELETE FROM enlistar WHERE cancion_cancion_id=@cancion_cancion_id", cn);
                    elimina3.Parameters.AddWithValue("@cancion_cancion_id", CancionSelect.id);

                    elimina3.ExecuteNonQuery();

                    SqlCommand elimina2 = new SqlCommand("DELETE FROM cancion WHERE cancion_id=@cancion_id", cn);
                    elimina2.Parameters.AddWithValue("@cancion_id", CancionSelect.id);

                    elimina2.ExecuteNonQuery();

                    SqlCommand elimina = new SqlCommand("DELETE FROM colaboracion WHERE cancion_cancion_id=@cancion_cancion_id", cn);
                    elimina.Parameters.AddWithValue("@cancion_cancion_id", CancionSelect.id);

                    elimina.ExecuteNonQuery();

                    Form1 frm1 = new Form1();
                    string path = frm1.PathGlobal();

                    File.SetAttributes(Path.Combine(path, Path.GetFileName(txtAudioEditar.Text)), FileAttributes.Normal);
                    File.Delete(Path.Combine(path, Path.GetFileName(txtAudioEditar.Text)));

                    MessageBox.Show("Canción eliminada.");

                    cn.Close();




                    Application.Restart();
                }

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Hubo un problema al tratar de eliminar la canción. Intentalo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelColaboradoresEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAudioEditar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
