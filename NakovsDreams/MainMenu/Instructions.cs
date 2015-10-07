using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainMenu.Properties;

namespace MainMenu
{
    public partial class Instructions : Form
    {
        private int clicksCounter = 0;
        private Bitmap [] images = new Bitmap[4];
        
        public Instructions()
        {
            InitializeComponent();
            pictureBox5.Visible = false;
           
            images[0] = Resources.Instructions1;
            images[1] = Resources.Instructions2;
            images[2] = Resources.Instructions3;
            images[3] = Resources.Instructions4;
           


        }
        public void InitMainMenu()
        {
            Application.Run(new MainMenu());
        }

        public void BackToMain()
        {
            Application.Run(new MainMenu());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = (Properties.Resources.ExitFinalShadow);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = (Properties.Resources.ExitFinal);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread i = new System.Threading.Thread(new System.Threading.ThreadStart(InitMainMenu));
            this.Close();
            i.Start();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            if (clicksCounter < images.Length - 1)
            { clicksCounter++; }
            

            this.pictureBox3.Image = images[clicksCounter];
           
            
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = Resources.right;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = Resources.rightThin;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox5.BackgroundImage = Resources.left;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Resources.leftThin;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (clicksCounter > 0)
            {
                clicksCounter--;
            }



            this.pictureBox3.Image = images[clicksCounter];
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = Resources.ExitFinalShadow;

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = Resources.ExitFinal;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // starting new Thread in order to load MainMenu Form
            System.Threading.Thread i = new System.Threading.Thread(new System.Threading.ThreadStart(BackToMain));
            this.Close();
            i.Start();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = Resources.ExitFinalShadow;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = Resources.right;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox5.BackgroundImage = Resources.left;
        }
    }
}
