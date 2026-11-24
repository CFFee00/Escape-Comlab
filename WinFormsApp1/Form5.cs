
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        private Form1 mainMenu;

        public Form5(Form1 menu)
        {
            InitializeComponent();
            mainMenu = menu;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Form6 game = new Form6(mainMenu, "Easy");
            game.Show();
            this.Close();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Form6 game = new Form6(mainMenu, "Normal");
            game.Show();
            this.Close();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Form6 game = new Form6(mainMenu, "Hard");
            game.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }
    }
}
