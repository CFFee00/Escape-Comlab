
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private Form1 mainMenu;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Form1 menu) : this()
        {
            mainMenu = menu;
        }

        private void lblObjective_Click(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (mainMenu != null)
            {
                mainMenu.Show();
            }

            base.OnFormClosed(e);
        }

        private void lblMembers_Click(object sender, EventArgs e)
        {

        }
    }
}
