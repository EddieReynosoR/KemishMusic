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

namespace KemishMusic
{
    public partial class Form1 : Form
    {
        SoundPlayer musicPlayer = new SoundPlayer();

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();


//ggs



        private bool isClicked = true;
        public Form1()
        {
            InitializeComponent();

            
            // musicPlayer = new SoundPlayer(filepath);
        }

        
        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

           
            if (isClicked)
            {
                runAudio(@"C:\Users\Eddie\Desktop\KemishMusic\Canciones\BRRR.wav");

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
                runAudio(@"C:\Users\Eddie\Desktop\KemishMusic\Canciones\AMG.mp3");

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
    }
}
