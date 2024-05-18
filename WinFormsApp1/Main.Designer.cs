namespace WinFormsApp1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Player1 = new PictureBox();
            Ball = new PictureBox();
            timerGame = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            labelTimermain = new Label();
            Player2 = new PictureBox();
            pointleft = new Label();
            pointright = new Label();
            labelRed = new Label();
            labelBlue = new Label();
            timerPause = new System.Windows.Forms.Timer(components);
            labelTimer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            RedWon = new Label();
            BlueWon = new Label();
            timerWon = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            labelMaxScore = new Label();
            ((System.ComponentModel.ISupportInitialize)Player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2).BeginInit();
            SuspendLayout();
            // 
            // Player1
            // 
            Player1.BackColor = Color.Red;
            Player1.BackgroundImageLayout = ImageLayout.Center;
            Player1.Location = new Point(10, 296);
            Player1.Name = "Player1";
            Player1.Size = new Size(21, 160);
            Player1.TabIndex = 0;
            Player1.TabStop = false;
            // 
            // Ball
            // 
            Ball.Anchor = AnchorStyles.None;
            Ball.BackColor = Color.Transparent;
            Ball.BackgroundImageLayout = ImageLayout.None;
            Ball.Image = (Image)resources.GetObject("Ball.Image");
            Ball.InitialImage = null;
            Ball.Location = new Point(390, 363);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.SizeMode = PictureBoxSizeMode.StretchImage;
            Ball.TabIndex = 1;
            Ball.TabStop = false;
            // 
            // timerGame
            // 
            timerGame.Enabled = true;
            timerGame.Interval = 10;
            timerGame.Tick += timerGame_Tick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tw Cen MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(362, 7);
            label1.Name = "label1";
            label1.Size = new Size(118, 47);
            label1.TabIndex = 2;
            label1.Text = "Score:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTimermain
            // 
            labelTimermain.AutoSize = true;
            labelTimermain.BackColor = Color.Transparent;
            labelTimermain.Font = new Font("Tw Cen MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimermain.Location = new Point(51, 21);
            labelTimermain.Name = "labelTimermain";
            labelTimermain.Size = new Size(123, 47);
            labelTimermain.TabIndex = 4;
            labelTimermain.Text = "Timer:";
            labelTimermain.Visible = false;
            // 
            // Player2
            // 
            Player2.Anchor = AnchorStyles.Right;
            Player2.BackColor = Color.Blue;
            Player2.Location = new Point(750, 296);
            Player2.Name = "Player2";
            Player2.Size = new Size(21, 160);
            Player2.TabIndex = 6;
            Player2.TabStop = false;
            // 
            // pointleft
            // 
            pointleft.Anchor = AnchorStyles.Top;
            pointleft.AutoSize = true;
            pointleft.BackColor = Color.Transparent;
            pointleft.Font = new Font("Tw Cen MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            pointleft.ForeColor = Color.Red;
            pointleft.Location = new Point(362, 54);
            pointleft.Name = "pointleft";
            pointleft.Size = new Size(41, 47);
            pointleft.TabIndex = 7;
            pointleft.Text = "0";
            // 
            // pointright
            // 
            pointright.Anchor = AnchorStyles.Top;
            pointright.AutoSize = true;
            pointright.BackColor = Color.Transparent;
            pointright.Font = new Font("Tw Cen MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            pointright.ForeColor = Color.Blue;
            pointright.Location = new Point(438, 54);
            pointright.Name = "pointright";
            pointright.Size = new Size(41, 47);
            pointright.TabIndex = 8;
            pointright.Text = "0";
            // 
            // labelRed
            // 
            labelRed.Anchor = AnchorStyles.Top;
            labelRed.AutoSize = true;
            labelRed.BackColor = Color.Transparent;
            labelRed.Font = new Font("Tw Cen MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelRed.ForeColor = Color.Red;
            labelRed.Location = new Point(294, 113);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(270, 47);
            labelRed.TabIndex = 9;
            labelRed.Text = "Player1 Scores!";
            labelRed.TextAlign = ContentAlignment.MiddleCenter;
            labelRed.Visible = false;
            // 
            // labelBlue
            // 
            labelBlue.Anchor = AnchorStyles.Top;
            labelBlue.AutoSize = true;
            labelBlue.BackColor = Color.Transparent;
            labelBlue.Font = new Font("Tw Cen MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelBlue.ForeColor = Color.Blue;
            labelBlue.Location = new Point(294, 113);
            labelBlue.Name = "labelBlue";
            labelBlue.Size = new Size(270, 47);
            labelBlue.TabIndex = 10;
            labelBlue.Text = "Player2 Scores!";
            labelBlue.TextAlign = ContentAlignment.MiddleCenter;
            labelBlue.Visible = false;
            // 
            // timerPause
            // 
            timerPause.Interval = 1000;
            timerPause.Tick += timerPause_Tick;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.BackColor = Color.Transparent;
            labelTimer.Font = new Font("Tw Cen MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimer.Location = new Point(181, 21);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(104, 47);
            labelTimer.TabIndex = 11;
            labelTimer.Text = "0 sec";
            labelTimer.Visible = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // RedWon
            // 
            RedWon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RedWon.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            RedWon.ForeColor = Color.Red;
            RedWon.Location = new Point(63, 287);
            RedWon.Name = "RedWon";
            RedWon.Size = new Size(641, 135);
            RedWon.TabIndex = 12;
            RedWon.Text = "Player1 WON";
            RedWon.TextAlign = ContentAlignment.MiddleCenter;
            RedWon.Visible = false;
            // 
            // BlueWon
            // 
            BlueWon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BlueWon.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            BlueWon.ForeColor = Color.Blue;
            BlueWon.Location = new Point(46, 260);
            BlueWon.Name = "BlueWon";
            BlueWon.Size = new Size(698, 188);
            BlueWon.TabIndex = 13;
            BlueWon.Text = "Player2 WON";
            BlueWon.TextAlign = ContentAlignment.MiddleCenter;
            BlueWon.Visible = false;
            // 
            // timerWon
            // 
            timerWon.Interval = 1000;
            timerWon.Tick += timerWon_Tick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.Location = new Point(486, 7);
            label2.Name = "label2";
            label2.Size = new Size(192, 47);
            label2.TabIndex = 14;
            label2.Text = "MaxScore:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // labelMaxScore
            // 
            labelMaxScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelMaxScore.AutoSize = true;
            labelMaxScore.Font = new Font("Tw Cen MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelMaxScore.ImageAlign = ContentAlignment.TopRight;
            labelMaxScore.Location = new Point(675, 7);
            labelMaxScore.Name = "labelMaxScore";
            labelMaxScore.Size = new Size(62, 47);
            labelMaxScore.TabIndex = 15;
            labelMaxScore.Text = "10";
            labelMaxScore.TextAlign = ContentAlignment.TopRight;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 753);
            Controls.Add(labelMaxScore);
            Controls.Add(label2);
            Controls.Add(BlueWon);
            Controls.Add(RedWon);
            Controls.Add(Ball);
            Controls.Add(labelTimer);
            Controls.Add(labelBlue);
            Controls.Add(labelRed);
            Controls.Add(pointright);
            Controls.Add(pointleft);
            Controls.Add(Player2);
            Controls.Add(labelTimermain);
            Controls.Add(label1);
            Controls.Add(Player1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Main";
            ShowInTaskbar = false;
            Text = "Ping-Pong";
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            KeyDown += Main_KeyDown;
            KeyUp += Main_KeyUp;
            ((System.ComponentModel.ISupportInitialize)Player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label pointleft;
        private Label pointright;
        private Label labelRed;
        private Label labelBlue;
        public System.Windows.Forms.Timer timerGame;
        public System.Windows.Forms.Timer timerPause;
        public System.Windows.Forms.Timer timer;
        public Label labelTimermain;
        public Label labelTimer;
        private Label RedWon;
        private Label BlueWon;
        private System.Windows.Forms.Timer timerWon;
        private Label label2;
        public Label labelMaxScore;
        public PictureBox Ball;
        public PictureBox Player1;
        public PictureBox Player2;
    }
}