
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        private Form1 mainMenu;

        public Form3(Form1 menu)
        {
            InitializeComponent();
            mainMenu = menu;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            trackMusic.Minimum = 0;
            trackMusic.Maximum = 100;
            trackMusic.Value = 70;

            trackSfx.Minimum = 0;
            trackSfx.Maximum = 100;
            trackSfx.Value = 70;

            lblMusic.Text = "Music";
            lblSFX.Text = "Sfx";
        }

        private void trackMusic_Scroll(object sender, EventArgs e)
        {
            lblMusic.Text = "Music";
        }

        private void trackSfx_Scroll(object sender, EventArgs e)
        {
            lblSFX.Text = "Sfx";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            mainMenu.Show();
            base.OnFormClosed(e);
        }
    }
}
