using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainMenu;

namespace MainMenu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.StartGame.BackgroundImage = (Properties.Resources.StartGameFinalShadow);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.StartGame.BackgroundImage = (Properties.Resources.StartGameFinal);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = (Properties.Resources.InstructionsFinalShadow);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = (Properties.Resources.InstructionsFinal);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox5.BackgroundImage = (Properties.Resources.HIghscoresFinalShadow);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox5.BackgroundImage = (Properties.Resources.HIghscoresFinal);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox6.BackgroundImage = (Properties.Resources.ExitFinalShadow);

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox6.BackgroundImage = (Properties.Resources.ExitFinal);
        }
        //Method for running the Instructions form, later loaded in a new Thread
        public void InitInstr()
        {
            Application.Run(new Instructions());
        }

        public void InitMainGame() 
        {

            Application.Run(new MainGame());
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // starting new Thread in order to load Instructions Form
            System.Threading.Thread i = new System.Threading.Thread(new System.Threading.ThreadStart(InitInstr));
            this.Close();
            i.Start();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            // starting new Thread in order to load main Game Form
            System.Threading.Thread i = new System.Threading.Thread(new System.Threading.ThreadStart(InitMainGame));
            this.Close();
            i.Start();
        }

        private void StartGame_MouseEnter(object sender, EventArgs e)
        {
            this.StartGame.BackgroundImage = (Properties.Resources.StartGameFinalShadow);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = (Properties.Resources.InstructionsFinalShadow);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox5.BackgroundImage = (Properties.Resources.HIghscoresFinalShadow);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox6.BackgroundImage = (Properties.Resources.ExitFinalShadow);
        }

        
    }
}
