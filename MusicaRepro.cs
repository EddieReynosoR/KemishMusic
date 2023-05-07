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
    public partial class MusicaRepr : UserControl
    {
        public static string id;
        public static event EventHandler CancionClick;

        public MusicaRepr()
        {
            InitializeComponent();
        }

        public void CancionDetalles(Cancion e)
        {

            lblID.Text = e.id;

            id = lblID.Text;

            picCancionRep.Image = (Bitmap)new ImageConverter().ConvertFrom(e.imagen);

            lblNombreCancion.Text = e.nombre;

        }
        private void MusicaRepro_Load(object sender, EventArgs e)
        {

        }

        private void MusicaRepro_Click(object sender, EventArgs e)
        {
            
        }

        private void lblNombreCancion_Click(object sender, EventArgs e)
        {

        }

        private void MusicaRepro_MouseHover(object sender, EventArgs e)
        {
            MusicaRepro.BackColor = Color.Gray;
        }

        private void MusicaRepro_MouseLeave(object sender, EventArgs e)
        {
            MusicaRepro.BackColor = Color.LightGray;
        }

        private void MusicaRepro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MusicaRepro_Click_1(object sender, EventArgs e)
        {
            id = lblID.Text;
            if (CancionClick != null)
            {
                CancionClick(this, e);
            }
        }
    }
}
