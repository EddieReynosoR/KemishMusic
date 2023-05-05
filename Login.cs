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
        SignUp registrarseForm = new SignUp();
       
        
        public Login()
        {
            InitializeComponent();
        }
       

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            Close();
           registrarseForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            string nombreUsuario = txtUsuario.Text;
            string contraUsuario = txtContra.Text;

            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=KemishMusic;Integrated Security=true;");

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
                Usuario.foto = (byte[])reader["usuario_fotoperfil"];
                Usuario.id = reader["id_usuario"].ToString();

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
            }

            cmd.Dispose();
            reader.Close();
            cn.Close();
        }

        private void lblApp_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 frm1 = new Form1();

            frm1.Show();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Hide();

            Form1 frm1 = new Form1();

            frm1.Show();
        }
    }
}
