using System;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace AudioTest
{
    public partial class Form1 : Form
    {
        private SoundPlayer[] audios;
        WindowsMediaPlayerClass player;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            player = new WindowsMediaPlayerClass();
            player.URL = "song.mid";

            audios = new SoundPlayer[5];
            audios[0] = LoadSoundFile("launch1.wav");
            audios[1] = new SoundPlayer();
            audios[1].Stream = Resource1.launch2;
            audios[2] = LoadSoundFile("missed1.wav");
            audios[3] = LoadSoundFile("laser.wav");
            audios[4] = LoadSoundFile("foom.wav");
        }

        private SoundPlayer LoadSoundFile(string path)
        {
            SoundPlayer temp = null;
            try
            {
                temp = new SoundPlayer();
                temp.SoundLocation = path;
                temp.Load();
            }
            catch (Exception)
            {

                MessageBox.Show("No this path {0}", path);
            }
            return temp;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "asterisk")
            {
                SystemSounds.Asterisk.Play();
            }
            else if (button.Name == "beep")
            {
                SystemSounds.Beep.Play();
            }
            else if (button.Name == "exclamation")
            {
                SystemSounds.Exclamation.Play();
            }
            else if (button.Name == "hand")
            {
                SystemSounds.Hand.Play();
            }
            else if (button.Name == "question")
            {
                SystemSounds.Question.Play();
            }
            else if (button.Name == "launch1")
            {
                audios[0].Play();
            }
            else if (button.Name == "launch2")
            {
                audios[1].Play();
            }
            else if (button.Name == "missed1")
            {
                audios[2].Play();
            }
            else if (button.Name == "laser")
            {
                audios[3].Play();
            }
            else if (button.Name == "foom")
            {
                audios[4].Play();
            }
        }
    }
}
