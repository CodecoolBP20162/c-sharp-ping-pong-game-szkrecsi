using System;
using System.Drawing;
using System.Windows.Forms;

namespace PongGame
{
    public partial class Form1 : Form
    {
        public int points = 0;
        public int speed_left = 3;
        public int speed_top = 3;
        
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();                               

            this.FormBorderStyle = FormBorderStyle.None; //remove any border
            this.Bounds = Screen.PrimaryScreen.Bounds;   //make it fullscreen

            board.Top = gameArea.Bottom - (gameArea.Bottom / 10); //set the position of the board
            gameOverLabel.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); //Quit
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            board.Left = Cursor.Position.X - (board.Width / 2); //set board to center
            ball.Left += speed_left; //move the ball
            ball.Top += speed_top;

            if (ball.Bottom >= board.Top && ball.Bottom <= board.Bottom && ball.Left >= board.Left && ball.Right <= board.Right)
            { 
                speed_top += 1;
                speed_left += 1;
                speed_top = -speed_top;
                points += 1;
                pointsLabel.Text = points.ToString();

                Random r = new Random();
                gameArea.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }

            if (ball.Left <= gameArea.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= gameArea.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= gameArea.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= gameArea.Bottom)
            {
                timer1.Enabled = false; //gameOver
                gameOverLabel.Visible = true;
            }

            if (points >= 5)
            {
                Size sizeAt5Points = new Size(240, 10);
                board.Size = sizeAt5Points;
            }

            if (points >= 10)
            {
                Size sizeAt10Points = new Size(200, 10);
                board.Size = sizeAt10Points;
            }

            if (points >= 15)
            {
                Size sizeAt15Points = new Size(140, 10);
                board.Size = sizeAt15Points;
            }

            if (points >= 20)
            {
                Size sizeAt20Points = new Size(70, 10);
                board.Size = sizeAt20Points;
            }

            if (ball.Bounds.IntersectsWith(brick1.Bounds))
            {
                brick1.BackColor = Color.Lime;
                speed_top = -speed_top;
                points += 3;
                pointsLabel.Text = points.ToString();
            }

            if (ball.Bounds.IntersectsWith(brick2.Bounds))
            {
                brick2.BackColor = Color.Lime;
                speed_top = -speed_top;
                points += 3;
                pointsLabel.Text = points.ToString();
            }

            if (ball.Bounds.IntersectsWith(brick3.Bounds))
            {
                brick3.BackColor = Color.Lime;
                speed_top = -speed_top;
                points += 3;
                pointsLabel.Text = points.ToString();
            }

            if (ball.Bounds.IntersectsWith(brick4.Bounds))
            {
                brick4.BackColor = Color.Lime;
                speed_top = -speed_top;
                points += 3;
                pointsLabel.Text = points.ToString();
            }
        }
    }
}