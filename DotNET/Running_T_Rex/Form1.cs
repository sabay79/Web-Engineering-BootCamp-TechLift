using System;
using System.Windows.Forms;

namespace Running_T_Rex
{
    public partial class Form1 : Form
    {
        bool jump = false;
        int jumpingSpeed;
        int frc = 12;
        int scoreofthegame = 0;
        int obstSpeed = 10;
        readonly Random random = new Random();
        int pos;
        bool isgameover = false;
        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void ResetGame()
        {
            frc = 12;
            jumpingSpeed = 0;
            jump = false;
            scoreofthegame = 0;
            obstSpeed = 10;
            score.Text = "Score: " + scoreofthegame;
            character.Image = Properties.Resources.runningFlamingo;
            isgameover = false;
            character.Top = 316;
            character.Height = 90;
            character.Width = 60;

            foreach (Control t in this.Controls)
            {
                if (t is PictureBox && (string)t.Tag == "obstacle")
                {
                    pos = this.ClientSize.Width + random.Next(500, 1000) + (t.Width * 10);
                    t.Left = pos;
                }
            }
            gameTimer.Start();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            character.Top += jumpingSpeed;

            score.Text = "Score = " + scoreofthegame;

            if (jump == true && frc < 0)
            { jump = false; }

            if (jump == true)
            {
                jumpingSpeed = -12;
                frc -= 1;
            }
            else
            { jumpingSpeed = 12; }

            if (character.Top > 315 && jump == false)
            {
                frc = 12;
                character.Top = 316;
                jumpingSpeed = 0;
            }

            foreach (Control t in this.Controls)
            {
                if (t is PictureBox && (string)t.Tag == "obstacle")
                {
                    t.Left -= obstSpeed;

                    if (t.Left < -100)
                    {
                        t.Left = this.ClientSize.Width + random.Next(200, 500) + (t.Width * 15);
                        scoreofthegame++;
                    }

                    if (character.Bounds.IntersectsWith(t.Bounds))
                    {
                        gameTimer.Stop();
                        //flyingFlamingo.Enabled= false;

                        character.Image = Properties.Resources.deadFlamigo;
                        character.Top = 334;
                        character.Height = 70;
                        character.Width = 100;

                        score.Text += "   Press T to Restart";
                        isgameover = true;
                    }
                }
            }
            if (scoreofthegame > 5)
            { obstSpeed = 15; }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jump == false)
            { jump = true; }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (jump == true)
            { jump = false; }

            if (e.KeyCode == Keys.T && isgameover == true)
            { ResetGame(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

