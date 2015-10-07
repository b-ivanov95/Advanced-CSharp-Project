using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainMenu.Properties;

namespace MainMenu
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {

            }
            else
            {
                timer1.Stop();
            }
        }

        private void pictureBox2_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // starting new Thread in order to load Instructions Form
            System.Threading.Thread i = new System.Threading.Thread(new System.Threading.ThreadStart(BackToMain));
            this.Close();
            i.Start();
        }

        private void BackToMain()
        {
            Application.Run(new MainMenu());
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Resources.ExitFinalShadow;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Resources.ExitFinal;
        }
    }
}
