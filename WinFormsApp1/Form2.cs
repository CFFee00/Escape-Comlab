
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private Form1 mainMenu;

        public Form2(Form1 menu)
        {
            InitializeComponent();
            mainMenu = menu;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }
    }
}
