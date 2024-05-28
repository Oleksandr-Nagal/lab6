namespace WinFormsApp1;
public partial class Textures : Form
{
    private Main ownerForm;
    public Textures(Main ownerForm)
    {
        InitializeComponent();
        this.ownerForm = ownerForm;
    }
    private void pictureBoxBall1_Click(object sender, EventArgs e)
    {
        ownerForm.Ball.Image = Image.FromFile(@"Ball1.png");
    }

    private void pictureBoxBall2_Click(object sender, EventArgs e)
    {
        ownerForm.Ball.Image = Image.FromFile(@"Ball2.png");
    }

    private void pictureBoxBall3_Click(object sender, EventArgs e)
    {
        ownerForm.Ball.Image = Image.FromFile(@"Ball3.png");
    }

    private void pictureBoxBall4_Click(object sender, EventArgs e)
    {
        ownerForm.Ball.Image = Image.FromFile(@"Ball4.png");
    }
    private void pictureBoxPl1_Click(object sender, EventArgs e)
    {
        ownerForm.Player1.Image = Image.FromFile(@"fon1.png");
    }
    private void pictureBoxPl2_Click(object sender, EventArgs e)
    {
        ownerForm.Player1.Image = Image.FromFile(@"fon2.png");
    }
    private void pictureBoxPl3_Click(object sender, EventArgs e)
    {
        ownerForm.Player1.Image = Image.FromFile(@"fon3.png");
    }
    private void pictureBoxPl4_Click(object sender, EventArgs e)
    {
        ownerForm.Player1.Image = Image.FromFile(@"fon4.png");
    }

    private void pictureBoxPr1_Click(object sender, EventArgs e)
    {
        ownerForm.Player2.Image = Image.FromFile(@"fon1.png");
    }

    private void pictureBoxPr2_Click(object sender, EventArgs e)
    {
        ownerForm.Player2.Image = Image.FromFile(@"fon2.png");
    }

    private void pictureBoxPr3_Click(object sender, EventArgs e)
    {
        ownerForm.Player2.Image = Image.FromFile(@"fon3.png");
    }

    private void pictureBoxPr4_Click(object sender, EventArgs e)
    {
        ownerForm.Player2.Image = Image.FromFile(@"fon4.png");
    }


    private void Textures_Load(object sender, EventArgs e)
    {

    }

    private void pictureBoxLime_Click(object sender, EventArgs e)
    {
        ownerForm.BackColor = Color.Lime;
    }

    private void pictureBoxCyan_Click(object sender, EventArgs e)
    {
        ownerForm.BackColor = Color.Cyan;
    }

    private void pictureBoxMagenta_Click(object sender, EventArgs e)
    {
        ownerForm.BackColor = Color.Magenta;
    }
    private void pictureBoxOrange_Click(object sender, EventArgs e)
    {
        ownerForm.BackColor = Color.Orange;
    }
    private void buttonReset_Click(object sender, EventArgs e)
    {
        ownerForm.Player1.Image = null;
        ownerForm.Player2.Image = null;
        ownerForm.Ball.Image = Image.FromFile(@"Ball.png");
        ownerForm.BackColor = Color.YellowGreen;
    }
    private void buttonExit2_Click(object sender, EventArgs e)
    {
        if (ownerForm.timerPause.Enabled == false)
        {
            ownerForm.timerGame.Start();
            ownerForm.timer.Start();
        }
        this.Close();
        Cursor.Hide();
    }
}
