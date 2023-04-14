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




        public CancionSelect()
        {
            InitializeComponent();
        }


        private void picCancion_Click(object sender, EventArgs e)
        {
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

        }

        private void CancionSelect_Click(object sender, EventArgs e)
        {
        }
    }
}
