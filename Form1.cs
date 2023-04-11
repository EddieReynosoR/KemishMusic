using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using System.IO;

namespace KemishMusic
{
    public partial class Form1 : Form
    {
        SoundPlayer musicPlayer = new SoundPlayer();

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        //Almacena el hijo actual (Form)
        private Form currentChildForm;

        //ggs



        private bool isClicked = true;
        public Form1()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();

            leftBorderBtn.Size = new Size(7, 45);

            panelMenu.Controls.Add(leftBorderBtn);


            // musicPlayer = new SoundPlayer(filepath);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            //public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            //Condicion diferente a nulo
            if (senderBtn != null)
            {
                //Se llama primero a este método para desactivar el
                //Boton anterior
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                //Cambiar el color de fondo del boton y el texto
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                //Se alinea el texto al centro
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //Cambiamos la relacion de la imagen con le texto
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Icono a la derecha
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //El icono de la barra de titulo cambie al icono del 
                //boton seleccionado y el color
                
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Se regresa la configuración por defecto del boton
                currentBtn.BackColor = Color.FromArgb(217, 217, 217);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public string getPath(string cancion)
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Canciones\\" + cancion;

            return path;
        }
        private void OpenChildForm(Form childForm)
        {
            //Condición para abrir solo un formulario
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //Se indica que no es formulario de nivel superior
            childForm.TopLevel = false;
            //Se quitan los bordes
            childForm.FormBorderStyle = FormBorderStyle.None;
            //Llenar el contenedor
            childForm.Dock = DockStyle.Fill;
            //Agregamos el formulario hijo a los
            //controles del panel Desktop
            //y asosciamos los datos del formulario
            //al panel
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Reset()
        {
            //Deshabilita el boton al dar clic en el logo
            DisableButton();
            leftBorderBtn.Visible = false;
            //Regresa el icono del panel de titulo al 
            //inicial con los valores por defecto
            btnHome.IconChar = IconChar.Home;
            btnHome.IconColor = Color.Black;
            btnHome.Text = "Home";
            panelMenu.Visible = true;
            panelReproduccion.Visible = true;
            txtSearch.Visible = true;
        }
        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {


            if (isClicked)
            {




                string path = getPath("BRRR.wav");


                runAudio(path);
                // runAudio("C:\\Users\\yyyah\\OneDrive\\Escritorio\\Canciones\\BRRR.wav");

                Image brr = new Bitmap(Properties.Resources.anuel_aa_las_leyendas_nunca_mueren_2_portada);
                pbBar.Image = brr;

                isClicked = false;
            }
            else
            {
                stopAudio();

                isClicked = true;
            }

            
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void runAudio(string filepath)
        {
            guna2TrackBar2.Value = 50;

            player.settings.volume = guna2TrackBar2.Value;

            player.URL = filepath;
            player.controls.play();
        }

        private void stopAudio()
        {
            player.controls.pause();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            

            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2TrackBar1.Maximum = (int)player.controls.currentItem.duration;

                guna2TrackBar1.Value = (int)player.controls.currentPosition;

                TimeSpan tiempo = TimeSpan.FromMinutes((int)player.controls.currentPosition);

                TimeSpan tiempoTotal = TimeSpan.FromMinutes((int)player.controls.currentItem.duration);

                string formatoTiempo = string.Format("{0:00}:{1:00}", tiempo.Hours, tiempo.Minutes);

                string formatoTiempoTotal = string.Format("{0:00}:{1:00}", tiempoTotal.Hours, tiempoTotal.Minutes);
                label1.Text = formatoTiempo;

                label2.Text = formatoTiempoTotal;
            }
        }

        

       

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {             
                player.controls.currentPosition = guna2TrackBar1.Value;

                label1.Text = player.controls.currentPositionString;


                
            }
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            if (isClicked)
            {
                string path = getPath("AMG.mp3");


                runAudio(path);
                // runAudio("C:\\Users\\yyyah\\OneDrive\\Escritorio\\Canciones\\AMG.mp3");

                Image amg = new Bitmap(Properties.Resources.AMG);
                pbBar.Image = amg;

                isClicked = false;
            }
            else
            {
                stopAudio();

                isClicked = true;
            }
        }


        bool isPaused = false;
        private void btnPausaPlay_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                player.controls.pause();
                btnPausaPlay.Image = Properties.Resources._375;

                isPaused = true;
            }
            else
            {
                player.controls.play();
                btnPausaPlay.Image = Properties.Resources._16427;

                isPaused = false;
            }
        }

        private void guna2TrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                player.settings.volume = guna2TrackBar2.Value;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Formularios.Playlist());
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool segundaPantalla = false;
        private void pbBar_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new Formularios.Reproduccion());

            if (!segundaPantalla)
            {
                guna2Panel1.BackColor = Color.Transparent;
                guna2Panel1.FillColor = Color.Transparent;

                guna2Panel1.Dock = DockStyle.Top;

                panelReproduccion.Height = 683;

                pbBar.Location = new Point(52, 576);
                guna2TrackBar1.Location = new Point(387, 580);
                btnPausaPlay.Location = new Point(738, 610);
                guna2TrackBar2.Location = new Point(899, 623);

                panelReproduccion.BackColor = Color.Transparent;
                panelReproduccion.BackgroundImage = Properties.Resources._330634344_1228671984728501_5317193639878804641_n;
                panelReproduccion.BackgroundImageLayout = ImageLayout.Center;



                panelMenu.Visible = false;
                panelDesktop.Visible = false;
                txtSearch.Visible = false;

                segundaPantalla = true;

                timerBarraMusic.Start();
            }
            else
            {
                guna2Panel1.BackColor = Color.White;
                guna2Panel1.FillColor = Color.White;
                panelReproduccion.Height = 128;
                panelReproduccion.BackColor = Color.DarkGray;

                guna2Panel1.Dock = DockStyle.Top;

                pbBar.Location = new Point(52, 21);

                guna2TrackBar1.Width = 787;

                pbBar.Height = 90;
                pbBar.Width = 90;

                guna2TrackBar1.Location = new Point(387, 25);
                btnPausaPlay.Location = new Point(738, 56);
                guna2TrackBar2.Location = new Point(899, 68);

                panelMenu.Visible = true;
                panelDesktop.Visible = true;
                txtSearch.Visible = true;


                panelReproduccion.BackgroundImage = null;

                segundaPantalla = false;

                timerBarraMusic.Stop();
            }

            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();

                panelReproduccion.Height = 128;
            }
            else
            {
                panelReproduccion.Height = 128;
            }
            btnHomeRepro.Visible = false;
            Reset();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHomeRepro.Visible = false;
        }

        private void timerBarraMusic_Tick(object sender, EventArgs e)
        {
            
            int X = guna2TrackBar1.Location.X;
            int Y = guna2TrackBar1.Location.Y;

            int XImg = pbBar.Location.X;
            int YImg = pbBar.Location.Y;

            int XBtn = btnPausaPlay.Location.X;
            int YBtn = btnPausaPlay.Location.Y;

            int X2 = guna2TrackBar2.Location.X;
            int Y2 = guna2TrackBar2.Location.Y;
            guna2TrackBar1.Location = new Point(X -= 6, Y -= 1);
            guna2TrackBar1.Width += 5;

            pbBar.Width += 3;
            pbBar.Height += 3;

            pbBar.Location = new Point(XImg, YImg -= 7);

            btnPausaPlay.Location = new Point(XBtn -= 3, YBtn -= 1);

            guna2TrackBar2.Location = new Point(X2 -= 2, Y2 -= 1);

            if (guna2TrackBar1.Location.X == 10 || guna2TrackBar1.Location.Y == 535)
            {
                timerBarraMusic.Stop();
            }
            
            
        }
    }
}
