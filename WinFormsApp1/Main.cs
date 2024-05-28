namespace WinFormsApp1;
public partial class Main : Form
{
    Random rnd = new Random();
    public int speed_horizontal;
    public int speed_vertical;
    public int speed_CPU;
    public int scoreleft, scoreright, MaxScore = 3;
    public int point = 0;
    public int time = 0, timeWon = 0;
    public int X1, Y, X2, Y2, Y1, timex = 0;
    public int pointl = 0, pointr = 0;
    public bool plUp1, plDown1, plUp2, plDown2;
    public int ComboBox = 4;
    public bool Timer;
    public bool CPU = false;
    public int CPULevel = 4;
    public int temp = 0;
    public int MusicBar;

    public int TabClicked = 0;

    public Main()
    {
        InitializeComponent();
        InitializeGame();
    }
    private void InitializeGame()
    {
        Settings settings = new Settings(this);
        MaxScore = Convert.ToInt32(settings.numericUpDownScore.Value);
        Bounds = Screen.PrimaryScreen.Bounds;
        speed_horizontal = GenerateSpeed();
        speed_vertical = GenerateSpeed();
        Y = Height / 2 - 80;
        X1 = 10;
        X2 = Width - 10;
        Y1 = Y;
        Y2 = Y;
        Player1.Location = new Point(X1, Y);
        Player2.Location = new Point(X2, Y);
    }

    private void UpdateScore()
    {
        labelMaxScore.Text = MaxScore.ToString();
    }

    private void CheckBallPlayerCollision()
    {
        if (Ball.Bounds.IntersectsWith(Player1.Bounds) || Ball.Bounds.IntersectsWith(Player2.Bounds))
        {
            HandleBallPlayerCollision();
        }
    }

    private void HandleBallPlayerCollision()
    {
        speed_horizontal *= -1;
        AdjustBallVerticalSpeed();
    }

    private void AdjustBallVerticalSpeed()
    {
        int ballCenterY = Ball.Top + Ball.Height / 2;
        int playerCenterY = Player1.Top + Player1.Height / 2;
        int deltaY = ballCenterY - playerCenterY;
        double speedChangeFactor = 0.1;
        speed_vertical += (int)(deltaY * speedChangeFactor);
        LimitVerticalSpeed();
    }

    private void LimitVerticalSpeed()
    {
        int maxSpeed = 10;
        if (speed_vertical > maxSpeed)
            speed_vertical = maxSpeed;
        if (speed_vertical < -maxSpeed)
            speed_vertical = -maxSpeed;
    }

    private void CheckBallWallCollision()
    {
        if (Ball.Right < Bounds.Left || Ball.Left < Player1.Right - 15 && (Ball.Bottom >= Player1.Top - 10 && Ball.Top < Player1.Top || Ball.Top <= Player1.Bottom + 3 && Ball.Bottom > Player1.Bottom))
        {
            HandleRightWallCollision();
        }
        else if (Ball.Left > Bounds.Right || Ball.Right > Player2.Left + 15 && (Ball.Bottom >= Player1.Top - 10 && Ball.Top < Player1.Top || Ball.Top <= Player1.Bottom + 3 && Ball.Bottom > Player1.Bottom))
        {
            HandleLeftWallCollision();
        }
        else if (Ball.Top <= Bounds.Top || Ball.Bottom >= Bounds.Bottom)
        {
            HandleTopBottomWallCollision();
        }
    }

    private void HandleRightWallCollision()
    {
        ResetGame();
        pointr += 1;
        labelBlue.Visible = true;
        pointright.Text = $"{pointr}";
        scoreright = int.Parse(pointright.Text);
        StopGame();
        timerPause.Enabled = true;
    }

    private void HandleLeftWallCollision()
    {
        ResetGame();
        pointl += 1;
        labelRed.Visible = true;
        pointleft.Text = $"{pointl}";
        scoreleft = int.Parse(pointleft.Text);
        StopGame();
        timerPause.Enabled = true;
        AdjustCPULevel();
    }

    private void AdjustCPULevel()
    {
        temp++;
        if (temp == 4)
        {
            if (CPULevel != 0)
                CPULevel -= 1;
            temp = 0;
        }
    }

    private void HandleTopBottomWallCollision()
    {
        speed_vertical *= -1;
    }

    private void MoveBall()
    {
        Ball.Left += speed_horizontal;
        Ball.Top += speed_vertical;
    }

    private void MoveCPU()
    {
        if (CPU == true)
        {
            Player2.Location = new Point(X2, Y2);
            if (Player2.Top > 0 && Player2.Bottom < Height)
            {
                if (speed_vertical < 0)
                    speed_CPU = speed_vertical + CPULevel;
                else
                    speed_CPU = speed_vertical - CPULevel;
            }
            if (Player2.Top <= 0)
                speed_CPU *= -1;
            if (Player2.Bottom >= Height)
                speed_CPU *= -1;
            Y2 += speed_CPU;
        }
    }

    private void CheckGameEnd()
    {
        if (scoreleft == MaxScore)
        {
            RedWon.Visible = true;
            StopGame();
            timerWon.Start();
        }
        else if (scoreright == MaxScore)
        {
            BlueWon.Visible = true;
            StopGame();
            timerWon.Start();
        }
    }

    private void MovePlayers()
    {
        if (plUp1 == true && Y1 > 0)
        {
            Y1 -= 15;
            Player1.Location = new Point(X1, Y1);
        }
        if (plDown1 == true && Y1 < Height - 160)
        {
            Y1 += 15;
            Player1.Location = new Point(X1, Y1);
        }
        if (CPU == false)
        {
            if (plUp2 == true && Y2 > 0)
            {
                Y2 -= 15;
                Player2.Location = new Point(X2, Y2);
            }
            if (plDown2 == true && Y2 < Height - 160)
            {
                Y2 += 15;
                Player2.Location = new Point(X2, Y2);
            }
        }
    }

    private void timerGame_Tick(object sender, EventArgs e)
    {
        UpdateScore();
        if (timerPause.Enabled == false)
        {
            CheckBallPlayerCollision();
            CheckBallWallCollision();
            MoveBall();
            MoveCPU();
            CheckGameEnd();
            MovePlayers();
        }
    }

    private void Main_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.W) { plUp1 = true; }
        if (e.KeyCode == Keys.S) { plDown1 = true; }
        if (e.KeyCode == Keys.Up) { plUp2 = true; }
        if (e.KeyCode == Keys.Down) { plDown2 = true; }
        if (timerPause.Enabled == false)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (TabClicked % 2 == 0)
                {
                    StopGame();
                }
                else
                {
                    timerGame.Start();
                    timer.Start();
                }

                TabClicked++;
            }

            if (e.KeyCode == Keys.F)
            {
                Settings settings = new Settings(this);
                settings.Owner = this;

                StopGame();
                settings.Show();
                Cursor.Show();
            }
            if (e.KeyCode == Keys.G)
            {
                Textures textures = new Textures(this);
                textures.Owner = this;

                StopGame();
                textures.Show();
                Cursor.Show();
            }
        }

        if (e.KeyCode == Keys.Escape)
        {
            Close(); Cursor.Show();

        }
    }
    private void Main_Load(object sender, EventArgs e)
    {

    }
    private void timer_Tick(object sender, EventArgs e)
    {
        timex++;
        labelTimer.Text = Convert.ToString(timex) + " sec";
    }
    private void Main_KeyUp(object sender, KeyEventArgs e)
    {
        plUp1 = false;
        plDown1 = false;
        plUp2 = false;
        plDown2 = false;
    }
    private void Main_FormClosed(object sender, FormClosedEventArgs e)
    {
        Menu menu = new Menu();
        menu.Show(); Cursor.Show();

    }
    private void timerWon_Tick(object sender, EventArgs e)
    {
        timeWon++;
        if (timeWon == 5)
        {
            Close();
        }
    }
    private int GenerateSpeed()
    {
        int speed;
        do
        {
            speed = rnd.Next(-10, 10);
        } while (speed <= 5 && speed >= -5);
        return speed;
    }
    private void ResetGame()
    {
        Y1 = Y2 = Height / 2 - 80;
        Ball.Location = new Point((Width / 2), (Height / 2));
        Player1.Location = new Point(X1, Y1);
        Player2.Location = new Point(X2, Y2);
        speed_horizontal = GenerateSpeed();
        speed_vertical = GenerateSpeed();
    }
    private void StopGame()
    {
        timer.Enabled = false;
        timerGame.Enabled = false;
    }

    private void timerPause_Tick(object sender, EventArgs e)
    {
        time++;
        if (time == 2)
        {
            labelRed.Visible = false;
            labelBlue.Visible = false;
            timer.Enabled = true;
            timex = -1;
            timerGame.Enabled = true;
            time = 0;
            timerPause.Enabled = false;
        }
    }
}
