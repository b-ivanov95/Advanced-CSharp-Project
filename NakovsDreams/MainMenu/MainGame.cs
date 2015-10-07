using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainMenu.Properties;
using Timer = System.Threading.Timer;

namespace MainMenu
{
    public partial class MainGame : Form
    {
        public int plus = RandomNumber();
        public int sleepPoints = 4;
        public int countOfSheeps = 0;
        public string input = string.Empty;
        public string endGameTextLost =
            "Nakov is angry now and he cant fall asleep. Try again!";
        public string endGameTextWin =
            "Zzz You made Nakov \n fall asleep";
        public MainGame()
        {
            
            InitializeComponent();
          
            points.Location = new Point(570,330);
            currentSheepValue.Text = countOfSheeps + "+" + plus;
            textBox1.KeyUp += TextBoxKeyUp;
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
        private bool BinaryGame()
        {

            int intInput = 0;
            try
            {
                intInput = Convert.ToInt32(input, 2);
            }
            catch
            {
                MessageBox.Show("Invalid Input! You have to input binary number.", "SheepLess",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return false;
            }
            if (countOfSheeps == intInput)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool HexGame()
        {
            int intInput = 0;
            try
            {
                intInput = Convert.ToInt32(input, 16);
            }
            catch
            {
                MessageBox.Show("Invalid Input! You have to input hex number.", "SheepLess",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return false;
            }
            if (countOfSheeps == intInput)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool GameLogic()
        {
            if(sleepPoints/10 == 0) // level 1
            {
                if (BinaryGame())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(sleepPoints/10 == 1) // level 2
            {
                this.pictureBox6.Image = Resources.level1;
                if (HexGame())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(sleepPoints/10 == 2) // level 3
            {
                this.pictureBox6.Image = Resources.level2;
                if(sleepPoints%2==0 )
                {
                    if(BinaryGame())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                if (sleepPoints % 2 == 1)
                {
                    if (HexGame())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;

        }
        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sleepPoints == 0) // check
                {
                    currentSheepValue.Text = endGameTextLost;
                    return;
                }
                if(sleepPoints == 30)
                {
                    currentSheepValue.Text = endGameTextWin;
                    return;
                }
                input = textBox1.Text;
                
                
                if(input == "levelup")
                {
                    sleepPoints+=10;
                    input = Convert.ToString(countOfSheeps + plus, 2);
                }
                if(input == "hintb")
                {
                    hint.Text = Convert.ToString(countOfSheeps + plus, 2);
                    input = hint.Text;
                }
                if (input == "hintx")
                {
                    hint.Text = Convert.ToString(countOfSheeps + plus, 16);
                    input = hint.Text;
                }
                countOfSheeps += plus;
                if(GameLogic())
                {
                    greenTick.Visible = true;
                    sleepPoints++;
           
                    Stopwatch stopwatch = new Stopwatch();

                   
                    stopwatch.Start();
                    while(stopwatch.ElapsedMilliseconds < 300)
                    {
                      
                    }
                    greenTick.Visible = false;
                   
                  




                }
                else
                {
                    sleepPoints--;
                    countOfSheeps -= plus;
                    
                }
                sleepMeter.Value = sleepPoints;
                label1.Text = countOfSheeps.ToString();
                points.Text = sleepPoints.ToString();
                plus = RandomNumber();
                currentSheepValue.Text = countOfSheeps+"+"+plus;
                e.Handled = true;
                textBox1.Text = string.Empty;
            }
        }
        static int RandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 10);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = Resources.ExitFinalShadow;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = Resources.ExitFinal;
        }
    }
}
