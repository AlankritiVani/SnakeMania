using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeMania
{
    public partial class Form1 : Form
    {
        List<Point> snake = new List<Point>();
        int foodX = 100;
        int foodY = 100;
        Direction direction = Direction.Right;

        public Form1()
        {
            InitializeComponent();
            snake.Add(new Point(50, 50));
        }

        private void mainGame_Paint(object sender, PaintEventArgs e)
        {
            foreach (Point point in snake) {
                e.Graphics.FillEllipse(new SolidBrush(Color.Black), point.x, point.y, 10, 10);
            }

            e.Graphics.FillEllipse(new SolidBrush(Color.Red), foodX, foodY, 10, 10);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Point head = snake[snake.Count - 1];
            
            switch (direction)
            {
                case Direction.Right:
                    snake.Add(new Point(head.x + 10, head.y));
                    break;
                case Direction.Left:
                    snake.Add(new Point(head.x - 10, head.y));
                    break;
                case Direction.Up:
                    snake.Add(new Point(head.x, head.y - 10));
                    break;
                case Direction.Down:
                    snake.Add(new Point(head.x, head.y + 10));
                    break;

            }

            if(head.x == foodX && head.y == foodY)
            {
                Random random = new Random();
                foodX = random.Next(mainGame.Width / 10) * 10;
                foodY = random.Next(mainGame.Height / 10) * 10;
                Tscore.Text = (snake.Count - 1).ToString();
            } else {
                snake.RemoveAt(0);
            }

            if(snake.GroupBy(point => point).Any(g => g.Count() > 1))
            {
                GameOver();
            }

            if (head.x < 0 || head.x > mainGame.Width || head.y < 0 || head.y > mainGame.Height)
            {
                GameOver();
            }

            mainGame.Refresh();
        }

        private void GameOver()
        {
            gameTimer.Enabled = false;
            lblGameOver.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if((direction == Direction.Up || direction == Direction.Down) && (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right))
            {
                return;
            }

            if((direction == Direction.Left || direction == Direction.Right) && (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down))
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Down:
                    direction = Direction.Down;
                    break;
                case Keys.Up:
                    direction = Direction.Up;
                    break;
                case Keys.Left:
                    direction = Direction.Left;
                    break;
                case Keys.Right:
                    direction = Direction.Right;
                    break;
            }
        }

    }
}
