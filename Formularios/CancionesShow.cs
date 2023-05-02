using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KemishMusic.Formularios
{
    public partial class CancionesShow : Form
    {
        public CancionesShow()
        {
            InitializeComponent();
        }

        private void CancionesShow_Load(object sender, EventArgs e)
        {
            DetallesCancion();
            CartasCancion();
        }
        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getList();
        }
        int i;
        public void CartasCancion()
        {
            foreach (Cancion cancion in Cancion.lista)
            {
                i++;
                CancionSelect carta = new CancionSelect();

                carta.CancionDetalles(cancion);


                carta.Dock = DockStyle.Left;
                panelCancion.Controls.Add(carta);
            }
        }
    }
}
