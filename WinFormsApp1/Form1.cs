
using System;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private SoundPlayer music;

        public Form1()
        {
            InitializeComponent();
            PlayMusic();
        }

        private void PlayMusic()
        {
            string path = Path.Combine(
                Application.StartupPath,
                "Sounds",
                "background.wav"
            );

            try
            {
                if (File.Exists(path))
                {
                    music = new SoundPlayer(path);
                    music.PlayLooping();
                }
                else
                {
                    MessageBox.Show("Music file not found:\n" + path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Music error: " + ex.Message);
            }
        }

        private void StopMusic()
        {
            if (music != null)
            {
                music.Stop();
                music.Dispose();
                music = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Form2 loadForm = new Form2(this);
            loadForm.Show();
            this.Hide();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Form3 optionsForm = new Form3(this);
            optionsForm.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form4 aboutForm = new Form4(this);
            aboutForm.Show();
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form5 difficultyForm = new Form5(this);
            difficultyForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the game?",
                "Exit Game",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                StopMusic();
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
