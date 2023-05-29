﻿using System;
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

        Login loginForm = new Login();
        SignUp registrarForm = new SignUp();

        // public Queue<Cancion> colaCanciones = new Queue<Cancion>();

        public static LinkedList<Cancion> colaCanciones = new LinkedList<Cancion>();
        public static LinkedListNode<Cancion> cancionSiguiente;

        public static List<string> listaAudios = new List<string>();

        //ggs



        private bool isClicked = true;
        public Form1()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();

            leftBorderBtn.Size = new Size(7, 45);

            panelMenu.Controls.Add(leftBorderBtn);

            CancionSelect.ImagenClick += new EventHandler(Clicked);

            VerContenidoPlaylist.PlaylistClick += new EventHandler(Clicked2);
            // musicPlayer = new SoundPlayer(filepath);

            CancionSelect.CancionClick += new EventHandler(CancionClick);

            CancionSelect.AgregarFila += new EventHandler(AgregarAFila);

            MusicaRepr.CancionClick += new EventHandler(ClickPanelRep);

            ArtistaCard.ClickArtista += new EventHandler(ClickCartaArtista);

            PlaylistControl.ClickPlaylist += new EventHandler(ClickCartaPlaylist);

            // player.PlayStateChange += TerminarCancion();


        }

        /* ** CAMBIE EL SIGUIENTE DIRECTORIO DE DATOS PARA PODER ENLAZARSE CON LA BASE DE DATOS ** */
        public static SqlConnection GetConnection()
        {
            //new SqlConnection(@"Data Source=LAPTOP-QS54F2AD\MSSQLSERVER01;Database=KemishMusic;Integrated Security=true;");
            return new SqlConnection(@"Data Source = YAHIR\SQLEXPRESS; Initial Catalog = KemishMusic; Integrated Security = True"); 
        }
        public void TerminarCancion(object senver, WMPLib._WMPOCXEvents_PlayStateChangeEventHandler e)
        {

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

        public string PathGlobal()
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Canciones\\";

            return path;
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
        }
        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {


            if (isClicked)
            {




                string path = getPath("BRRR.mp3");


                runAudio(path);
                // runAudio("C:\\Users\\yyyah\\OneDrive\\Escritorio\\Canciones\\BRRR.wav");

                Image brr = new Bitmap(Properties.Resources.anuel_aa_las_leyendas_nunca_mueren_2_portada);
                //pbBar.Image = brr;

                //      isClicked = false;
                //   }
                //   else
                //   {
                //stopAudio();

                //   isClicked = true;
                //     }


            }
        }

            private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
            {

            }

            public void runAudio(string filepath)
            {
                guna2TrackBar2.Value = 50;
                player.settings.volume = guna2TrackBar2.Value;

                player.URL = getPath(filepath);
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
               // pbBar.Image = amg;

                //  isClicked = false;
                //  }
                // else
                // {
                //stopAudio();

                //   isClicked = true;
                // }
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
                picMostrarCola.Enabled = true;
                panelCancionesHome.Visible = true;

                ActivateButton(sender, RGBColors.color1);
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                panelCancionesHome.Visible = false;
                // panelDesktop.Controls.Clear();
                picMostrarCola.Enabled = false;
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new Formularios.Playlist());
            }

            private void gunaPictureBox1_Click(object sender, EventArgs e)
            {

            }

            bool segundaPantalla = false;
            private void pbBar_Click(object sender, EventArgs e)
            {
                //OpenChildForm(new Formularios.Reproduccion());

                if (!segundaPantalla)
                {
                    guna2Panel1.BackColor = Color.Transparent;
                    guna2Panel1.FillColor = Color.Transparent;

                    guna2Panel1.Dock = DockStyle.Top;

                    panelReproduccion.Height = 683;

                    pbBar.Location = new Point(52, 576);
                    guna2TrackBar1.Location = new Point(387, 580);
                    btnPausaPlay.Location = new Point(738, 610);
                lblNombreCancion.Location = new Point(149, 610);
                lblNombreCancion.Font = new Font("Circular Std Book", 20, FontStyle.Bold);
                guna2TrackBar2.Location = new Point(899, 623);

                    panelReproduccion.BackColor = Color.Transparent;
                    panelReproduccion.BackgroundImage = Properties.Resources._330634344_1228671984728501_5317193639878804641_n;
                    panelReproduccion.BackgroundImageLayout = ImageLayout.Center;



                    panelMenu.Visible = false;
                    panelDesktop.Visible = false;

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
                lblNombreCancion.Location = new Point(149, 28);
                lblNombreCancion.Font = new Font("Circular Std Book", 10, FontStyle.Bold);
                    guna2TrackBar2.Location = new Point(899, 68);

                    panelMenu.Visible = true;
                    panelDesktop.Visible = true;


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
                Reset();
            }

            private void guna2Panel1_Paint(object sender, PaintEventArgs e)
            {

            }

        public void ObtenerCancionAudioGuardado()
        {
            SqlConnection cn = GetConnection();

            cn.Open();

            string query = "SELECT cancion_audionombre FROM cancion";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listaAudios.Add(dr["cancion_audionombre"].ToString());
            }

            cn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            ObtenerCancionAudioGuardado();

            string path = PathGlobal();

            foreach (string cancion in listaAudios)
            {
                File.SetAttributes(Path.Combine(path, Path.GetFileName(cancion)), FileAttributes.Normal);

            } 
            */

            DetallesCancion();
            CartasCancion();


            if (Usuario.usuario != null)
            {
                btnNav.Text = Usuario.usuario;

                btnIniciarSesion.Visible = false;
                btnRegistrarse.Visible = false;
                btnSearch.Enabled = true;
                iconButton1.Enabled = true;

                btnCancion.Enabled = true;
                btnCerrarSesion.Visible = true;

                btnVerPerfil.Visible = true;
            }
            else
            {
                btnNav.Text = "Sesión no iniciada";
                btnIniciarSesion.Visible = true;
                btnRegistrarse.Visible = true;

                iconButton1.Enabled = false;
                btnCancion.Enabled = false;
                btnSearch.Enabled = false;

                btnCerrarSesion.Visible = false;
                btnVerPerfil.Visible = false;
            }

            btnAgregar.Visible = false;
        }

        int i;
        public void CartasCancion()
        {
            if (Cancion.lista.Count == 0)
                lblMensaje.Visible = true;
            else
            {
                lblMensaje.Visible = false;
                foreach (Cancion cancion in Cancion.lista)
                {
                    i++;
                    CancionSelect carta = new CancionSelect();


                    carta.CancionDetalles(cancion);



                    carta.Dock = DockStyle.Left;
                    panelCancionesHome.Controls.Add(carta);
                }
            }
        }

        private void timerBarraMusic_Tick(object sender, EventArgs e)
        {

            int X = guna2TrackBar1.Location.X;
            int Y = guna2TrackBar1.Location.Y;

            int XImg = pbBar.Location.X;
            int YImg = pbBar.Location.Y;

            int XBtn = btnPausaPlay.Location.X;
            int YBtn = btnPausaPlay.Location.Y;

            int XNombre = lblNombreCancion.Location.X;
            int YNombre = lblNombreCancion.Location.Y;

            int X2 = guna2TrackBar2.Location.X;
            int Y2 = guna2TrackBar2.Location.Y;
            guna2TrackBar1.Location = new Point(X -= 6, Y -= 1);
            guna2TrackBar1.Width += 5;

            pbBar.Width += 3;
            pbBar.Height += 3;

            pbBar.Location = new Point(XImg, YImg -= 7);

            btnPausaPlay.Location = new Point(XBtn -= 3, YBtn -= 1);

            lblNombreCancion.Location = new Point(XNombre += 5, YNombre -= 3);

            guna2TrackBar2.Location = new Point(X2 -= 2, Y2 -= 1);

            if (guna2TrackBar1.Location.X == 10 || guna2TrackBar1.Location.Y == 535)
            {
                timerBarraMusic.Stop();
            }


        }
        
        

        public void DetallesCancion()
        {
            Cancion cancion = new Cancion();
            cancion.getList();
        }

        public void SeleccionarNombreArtista(string idArtista)
        {
            SqlConnection cn = GetConnection();

            cn.Open();

            string query = "SELECT usuario.usuario_nombreartist FROM cancion INNER JOIN usuario on id_usuario = cancion.usuario_id_usuario WHERE cancion.cancion_id = '"+idArtista+"'";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lblColab.Text += dr["usuario_nombreartist"].ToString();
            }

            cn.Close();
        }

        public void SeleccionarColab(string idColab)
        {
            SqlConnection cn = GetConnection();

            cn.Open();

            string query = "SELECT usuario.usuario_nombreartist FROM cancion INNER JOIN colaboracion on colaboracion.cancion_cancion_id = cancion_id INNER JOIN usuario on id_usuario = colaboracion.usuario_usuario_id WHERE cancion.cancion_id = '"+idColab+"'";


            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lblColab.Text += ", " + dr["usuario_nombreartist"].ToString();
            }

            cn.Close();
        }

        public void Clicked(object sender, EventArgs e)
        {
            colaCanciones.Clear();
            panelMusicaRe.Controls.Clear();



            timerReproduccion.Enabled = true;

            Cancion obtener = new Cancion();

            obtener.ReproducirCancion(CancionSelect.id);



            colaCanciones.AddFirst(obtener);
            cancionSiguiente = colaCanciones.First;

            lblColab.Text = "";

            lblNombreCancion.Text = obtener.nombre;

            SeleccionarNombreArtista(obtener.id);
            SeleccionarColab(obtener.id);

            pbBar.Image = (Bitmap)new ImageConverter().ConvertFrom(obtener.imagen);






            runAudio(obtener.audio);


            


            

        }

        public void Clicked2(object sender, EventArgs e)
        {
            panelMusicaRe.Controls.Clear();


            timerReproduccion.Enabled = true;

            
            cancionSiguiente = colaCanciones.First;

            lblColab.Text = "";

            lblNombreCancion.Text = cancionSiguiente.Value.nombre;

            SeleccionarNombreArtista(cancionSiguiente.Value.id);
            SeleccionarColab(cancionSiguiente.Value.id);

            pbBar.Image = (Bitmap)new ImageConverter().ConvertFrom(cancionSiguiente.Value.imagen);






            runAudio(cancionSiguiente.Value.audio);







        }



        public void ClickPanelRep(object sender, EventArgs e)
        {
            
            Cancion obtener = new Cancion();

            obtener.ReproducirCancion(MusicaRepr.id);


            LinkedListNode<Cancion> cancion = colaCanciones.Find(obtener);

            cancionSiguiente = cancion;

            RefreshCola();

            pbBar.Image = (Bitmap)new ImageConverter().ConvertFrom(cancionSiguiente.Value.imagen);


            runAudio(cancionSiguiente.Value.audio);




        }

        public void CancionClick(object sender, EventArgs e)
        {

            if (colaCanciones.Count != 0)
            {
                Cancion obtener = new Cancion();

                obtener.ReproducirCancion(CancionSelect.id);




                MusicaRepr panel = new MusicaRepr();

                if (!colaCanciones.Any(o => o.id == CancionSelect.id))
                {

                    colaCanciones.AddAfter(cancionSiguiente, obtener);

                    panelMusicaRe.Controls.Clear();




                }
            }

            
            



        }

        public void AgregarAFila(object sender, EventArgs e)
        {
            if(colaCanciones.Count != 0)
            {
                Cancion obtener = new Cancion();

                obtener.ReproducirCancion(CancionSelect.id);




                MusicaRepr panel = new MusicaRepr();

                if (!colaCanciones.Any(o => o.id == CancionSelect.id))
                {


                    colaCanciones.AddLast(obtener);

                    panelMusicaRe.Controls.Clear();
                }
            }
            
        }


        private void cancionSelect1_Load(object sender, EventArgs e)
        {

        }

        private void cancionSelect1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancion_Click(object sender, EventArgs e)
        {
            panelCancionesHome.Visible = false;
            // panelDesktop.Controls.Clear();
            picMostrarCola.Enabled = false;
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Formularios.CancionesShow());
        }


        bool visible = false;
        private void btnNav_Click(object sender, EventArgs e)
        {
            if (visible == false)
            {
                panelOpciones.Visible = true;
                visible = true;
            }
            else
            {
                panelOpciones.Visible = false;
                visible = false;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            loginForm.Show();


            Hide();

        }

        

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            registrarForm.Show();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Usuario.id = null;
            Usuario.usuario = null;
            Usuario.foto = null;

            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Usuario.id = null;
            Usuario.usuario = null;
            Usuario.foto = null;

            

            Application.Restart();
        }

        bool MostrarPanelRepro = false;

        
        private void picMostrarCola_Click(object sender, EventArgs e)
        {
            RefreshCola();
            if (!MostrarPanelRepro)
            {
                panelMusicaRe.Visible = true;
                picMostrarCola.Image = Properties.Resources._4419531;


                MostrarPanelRepro = true;
            }
            else
            {
                panelMusicaRe.Visible = false;
                picMostrarCola.Image = Properties.Resources._4419530;

                MostrarPanelRepro = false;
            }
        }


        private void timerReproduccion_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {

                // colaCanciones.Dequeue()

                

                label3.Text = colaCanciones.Count().ToString();


                LinkedListNode<Cancion> cancionNext = cancionSiguiente.Next;

                if (cancionNext != null)
                {
                    cancionSiguiente = cancionNext;

                    RefreshCola();

                    Cancion obtener = cancionNext.Value;

                    lblNombreCancion.Text = "";
                    lblNombreCancion.Text = obtener.nombre;

                    lblColab.Text = "";
                    SeleccionarNombreArtista(obtener.id);
                    SeleccionarColab(obtener.id);


                    pbBar.Image = (Bitmap)new ImageConverter().ConvertFrom(obtener.imagen);



                    runAudio(obtener.audio);
                }

                else
                {
                    cancionSiguiente = colaCanciones.First;

                    RefreshCola();

                    Cancion obtener = cancionSiguiente.Value;


                    lblNombreCancion.Text = "";
                    lblNombreCancion.Text = obtener.nombre;

                    lblColab.Text = "";
                    SeleccionarNombreArtista(obtener.id);
                    SeleccionarColab(obtener.id);


                    pbBar.Image = (Bitmap)new ImageConverter().ConvertFrom(obtener.imagen);



                    runAudio(obtener.audio);
                }
                    



                
                    
                


                
                    

            }
        }

        public void RefreshCola()
        {

            if (colaCanciones.Count == 0)
                lblMensajeCola.Visible = true;
            else
            {
                panelMusicaRe.Controls.Clear();
                foreach (Cancion cancion in colaCanciones.Reverse())
                {
                    MusicaRepr panel = new MusicaRepr();
                    panel.CancionDetalles(cancion);


                    panel.Dock = DockStyle.Top;
                    panelMusicaRe.Controls.Add(panel);
                }
            }
            
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            panelCancionesHome.Visible = false;
            // panelDesktop.Controls.Clear();
            picMostrarCola.Enabled = false;
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Formularios.Crear_Playlist());
            // btnAgregar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.AgregarCanciones());
        }
        
         

       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            


            if (cancionSiguiente.Previous != null)
            {
                LinkedListNode<Cancion> cancionNext = cancionSiguiente.Previous;
                cancionSiguiente = cancionNext;

                RefreshCola();
                Cancion obtener = cancionNext.Value;

                lblColab.Text = "";
                SeleccionarNombreArtista(obtener.id);
                SeleccionarColab(obtener.id);

                lblNombreCancion.Text = obtener.nombre;
                pbBar.Image = (Bitmap)new ImageConverter().ConvertFrom(obtener.imagen);



                runAudio(obtener.audio);
            }
            else
            {
                cancionSiguiente = colaCanciones.First;
                Cancion obtener = cancionSiguiente.Value;

                RefreshCola();

                lblColab.Text = "";
                SeleccionarNombreArtista(obtener.id);
                SeleccionarColab(obtener.id);

                lblNombreCancion.Text = obtener.nombre;
                pbBar.Image = (Bitmap)new ImageConverter().ConvertFrom(obtener.imagen);



                runAudio(obtener.audio);
            }
                






            

        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            
            label3.Text = colaCanciones.Count().ToString();


            

            if (cancionSiguiente.Next != null)
            {


                LinkedListNode<Cancion> cancionNext = cancionSiguiente.Next;

                cancionSiguiente = cancionNext;

                RefreshCola();
              

                Cancion obtener = cancionNext.Value;

                lblColab.Text = "";
                SeleccionarNombreArtista(obtener.id);
                SeleccionarColab(obtener.id);

                lblNombreCancion.Text = obtener.nombre;
                pbBar.Image = (Bitmap)new ImageConverter().ConvertFrom(obtener.imagen);



                runAudio(obtener.audio);
            }              
            else
            {
                cancionSiguiente = colaCanciones.First;
                Cancion obtener = cancionSiguiente.Value;

                RefreshCola();

                lblColab.Text = "";
                SeleccionarNombreArtista(obtener.id);
                SeleccionarColab(obtener.id);

                lblNombreCancion.Text = obtener.nombre;
                pbBar.Image = (Bitmap)new ImageConverter().ConvertFrom(obtener.imagen);



                runAudio(obtener.audio);
            }





           

            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // ActivateButton(sender, RGBColors.color1);
            verArtista.id = Usuario.id;
            verArtista.usuario = Usuario.usuario;
            verArtista.nombreArtistico = Usuario.nombreArtistico;
            verArtista.descripcion = Usuario.descripcion;
            verArtista.foto = Usuario.foto;
            verArtista.fotoPortada = Usuario.fotoPortada;

            OpenChildForm(new Perfil());
        }

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            panelCancionesHome.Visible = false;

            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Buscar());
        }

        public void ClickCartaArtista(object sender, EventArgs e)
        {
            Artista artista = new Artista();
            artista.getArtista(ArtistaCard.id);

            verArtista.id = artista.id;
            verArtista.usuario = artista.usuario;
            verArtista.nombreArtistico = artista.nombreArtistico;
            verArtista.descripcion = artista.descripcion;
            verArtista.foto = artista.foto;
            verArtista.fotoPortada = artista.fotoPortada;

            OpenChildForm(new Perfil());
        }

        public void ClickCartaPlaylist(object sender, EventArgs e)
        {
            

            OpenChildForm(new VerContenidoPlaylist());
        }

        private void panelCancionesHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMusicaRe_VisibleChanged(object sender, EventArgs e)
        {
            if (colaCanciones.Count == 0)
                lblMensajeCola.Visible = true;
            else
                lblMensajeCola.Visible = false;
        }
    }
}
    

