using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KemishMusic
{
    public partial class CancionSelect : UserControl
    {
        public static string id;
        public static event EventHandler ImagenClick;
        public static event EventHandler CancionClick;

        ToolTip tooltip1 = new ToolTip();



        public CancionSelect()
        {
            InitializeComponent();
        }


        private void picCancion_Click(object sender, EventArgs e)
        {
            id = lblID.Text;

            if (ImagenClick != null)
                ImagenClick(this, e);

           
        }

        public void CancionDetalles(Cancion e)
        {

            lblID.Text = e.id;

            id = lblID.Text;

            picCancion.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            cancionNombre.Text = e.nombre;

        }

        private void CancionSelect_Load(object sender, EventArgs e)
        {
            //lblID.Hide();
        }

        private void CancionSelect_Click(object sender, EventArgs e)
        {
        }

        private void picOpciones_Click(object sender, EventArgs e)
        {
            id = lblID.Text;

            if (CancionClick != null)
            {
                CancionClick(this, e);
            }

            
        }

        private void picOpciones_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(picOpciones, "Agregar cancion a la cola.");
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
