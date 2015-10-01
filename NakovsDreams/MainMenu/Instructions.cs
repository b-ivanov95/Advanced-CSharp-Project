using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }
        public void InitMainMenu()
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
    }
}
