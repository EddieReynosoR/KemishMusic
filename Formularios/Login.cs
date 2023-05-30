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
    public partial class Login : Form
    {
        // Instancia al form de registro
        SignUp registrarseForm = new SignUp();
       
        
        public Login()
        {
            InitializeComponent();
        }
       
        
        // Inicio de sesion usando la base de datos
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            string nombreUsuario = txtUsuario.Text;
            string contraUsuario = txtContra.Text;


            
            SqlConnection cn = Form1.GetConnection();
            cn.Open();

            string query = "SELECT * FROM usuario WHERE usuario_username = '" + nombreUsuario + "' AND usuario_contra = '" + contraUsuario + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            DataTable dtable = new DataTable();

            sda.Fill(dtable);

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = query;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Usuario.usuario = reader["usuario_username"].ToString();
                Usuario.contra = reader["usuario_contra"].ToString();
                Usuario.nombre = reader["usuario_nombre"].ToString();
                Usuario.apellidop = reader["usuario_apellidop"].ToString();
                Usuario.apellidom = reader["usuario_apellidom"].ToString();
                Usuario.correo = reader["usuario_correo"].ToString();
                Usuario.fechaNacimiento = (DateTime)reader["usuario_fnacimiento"];
                Usuario.foto = (byte[])reader["usuario_fotoperfil"];
                Usuario.id = reader["id_usuario"].ToString();
                Usuario.fotoPortada = (byte[])reader["usuario_fportada"];
                Usuario.descripcion = reader["usuario_descripcion"].ToString();
                Usuario.nombreArtistico = reader["usuario_nombreartist"].ToString();

            }
            
            if (dtable.Rows.Count > 0)
            {
                MessageBox.Show("Datos correctos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                frm1.Show();
                   
            }
            else
            {
                MessageBox.Show("Datos incorrectos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Restart();
            }

            cmd.Dispose();
            reader.Close();
            cn.Close();
        }

        // Mostrar formulario de registro si es que se necesita
        private void lblApp_Click(object sender, EventArgs e)
        {
            Hide();
            SignUp registrarse = new SignUp();

            registrarse.Show();
        }

        // Salir de la app
        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Mostrar y ocultar password
        private void chkMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContra.Checked)
                txtContra.PasswordChar = '\0';
            else
                txtContra.PasswordChar = '*';
        }

        // Si se presiona ENTER, salta al siguiente textbox
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtContra.Focus();
        }

        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(this, new EventArgs());
        }

        
    }
}
