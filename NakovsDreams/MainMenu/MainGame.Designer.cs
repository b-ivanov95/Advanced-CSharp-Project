namespace MainMenu
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.currentSheepValue = new System.Windows.Forms.Label();
            this.SheepCountLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.redCross = new System.Windows.Forms.PictureBox();
            this.greenTick = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hint = new System.Windows.Forms.Label();
            this.sleepMeter = new System.Windows.Forms.ProgressBar();
            this.points = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // currentSheepValue
            // 
            this.currentSheepValue.AutoSize = true;
            this.currentSheepValue.BackColor = System.Drawing.Color.White;
            this.currentSheepValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSheepValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(112)))));
            this.currentSheepValue.Location = new System.Drawing.Point(265, 302);
            this.currentSheepValue.Name = "currentSheepValue";
            this.currentSheepValue.Size = new System.Drawing.Size(154, 29);
            this.currentSheepValue.TabIndex = 2;
            this.currentSheepValue.Text = "sheep value";
            this.currentSheepValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // SheepCountLabel
            // 
            this.SheepCountLabel.AutoSize = true;
            this.SheepCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheepCountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SheepCountLabel.Location = new System.Drawing.Point(182, 126);
            this.SheepCountLabel.Name = "SheepCountLabel";
            this.SheepCountLabel.Size = new System.Drawing.Size(147, 25);
            this.SheepCountLabel.TabIndex = 4;
            this.SheepCountLabel.Text = "Sheep count: ";
            this.SheepCountLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(346, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(182, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Next sheep value:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(112)))));
            this.textBox1.Location = new System.Drawing.Point(419, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 30);
            this.textBox1.TabIndex = 9;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::MainMenu.Properties.Resources.level0;
            this.pictureBox6.Location = new System.Drawing.Point(471, 345);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(234, 67);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // redCross
            // 
            this.redCross.BackColor = System.Drawing.Color.Transparent;
            this.redCross.Image = global::MainMenu.Properties.Resources.XResized;
            this.redCross.Location = new System.Drawing.Point(579, 176);
            this.redCross.Name = "redCross";
            this.redCross.Size = new System.Drawing.Size(60, 54);
            this.redCross.TabIndex = 11;
            this.redCross.TabStop = false;
            this.redCross.Visible = false;
            // 
            // greenTick
            // 
            this.greenTick.BackColor = System.Drawing.Color.Transparent;
            this.greenTick.Image = global::MainMenu.Properties.Resources.greenTickSmall;
            this.greenTick.Location = new System.Drawing.Point(579, 176);
            this.greenTick.Name = "greenTick";
            this.greenTick.Size = new System.Drawing.Size(60, 54);
            this.greenTick.TabIndex = 10;
            this.greenTick.TabStop = false;
            this.greenTick.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::MainMenu.Properties.Resources.smallSheep;
            this.pictureBox5.Location = new System.Drawing.Point(377, 120);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 40);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::MainMenu.Properties.Resources.ExitFinal;
            this.pictureBox4.Location = new System.Drawing.Point(576, 701);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(166, 56);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MainMenu.Properties.Resources.cooltext139703391011097;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(730, 82);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::MainMenu.Properties.Resources.cartoon_thought_bubble_mdsmaller;
            this.pictureBox2.Location = new System.Drawing.Point(216, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 152);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox2_LoadCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::MainMenu.Properties.Resources.backgroundFinal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 498);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hint
            // 
            this.hint.AccessibleName = "";
            this.hint.AutoSize = true;
            this.hint.Location = new System.Drawing.Point(494, 127);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(0, 17);
            this.hint.TabIndex = 14;
            // 
            // sleepMeter
            // 
            this.sleepMeter.Location = new System.Drawing.Point(570, 304);
            this.sleepMeter.MarqueeAnimationSpeed = 30;
            this.sleepMeter.Maximum = 30;
            this.sleepMeter.Name = "sleepMeter";
            this.sleepMeter.Size = new System.Drawing.Size(135, 23);
            this.sleepMeter.TabIndex = 15;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Location = new System.Drawing.Point(118, 356);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(0, 17);
            this.points.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(468, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "progress:";
            // 
            // MainGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(49)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(754, 760);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.points);
            this.Controls.Add(this.sleepMeter);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.redCross);
            this.Controls.Add(this.greenTick);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.SheepCountLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.currentSheepValue);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nakov\'s Dreams";
            this.Load += new System.EventHandler(this.MainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label currentSheepValue;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label SheepCountLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox greenTick;
        private System.Windows.Forms.PictureBox redCross;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.ProgressBar sleepMeter;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label label3;
    }
}