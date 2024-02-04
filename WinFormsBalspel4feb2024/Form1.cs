namespace WinFormsBalspel4feb2024
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Color backColor;
        private PlayerBall playerBall = new PlayerBall(10, 10, 0, 0);
        private Ball ball1 = new Ball(4, 4, 1, 0);
        private Ball ball2 = new Ball(9, 2, 0, 1);
        private Ball ball3 = new Ball(15, 17, -1, 0);
        private Ball ball4 = new Ball(12, 3, -1, -1);

        public Form1()
        {
            InitializeComponent();

            //Console.CursorVisible = false;
            //Console.WindowHeight = 20;
            //Console.WindowWidth = 30;
            this.ClientSize = new Size(20 * 10, 30 * 10);
            this.backColor = this.BackColor;

            this.g = this.CreateGraphics();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Console.Clear();
            g.Clear(backColor);

            // Balls
            ball1.Update(this.ClientSize);
            ball2.Update(this.ClientSize);
            ball3.Update(this.ClientSize);
            ball4.Update(this.ClientSize);
            ball1.Draw(g);
            ball2.Draw(g);
            ball3.Draw(g);
            ball4.Draw(g);

            //// SpelerBal
            //if (Console.KeyAvailable)
            //{
            //    var key = Console.ReadKey();
            //    playerBall.ChangeVelocity(key);
            //}

            playerBall.Update(this.ClientSize);
            playerBall.Draw(g);

            // Check collisions
            if (Ball.CheckHit(ball1, playerBall) || Ball.CheckHit(ball2, playerBall) || Ball.CheckHit(ball3, playerBall) || Ball.CheckHit(ball4, playerBall))
            {
                g.Clear(backColor);
                g.DrawString("Gewonnen!", this.Font, Brushes.Black, 0, 0);
                timer1.Stop();
                //Console.Clear();
                //Console.WriteLine("Gewonnen!");
                //Console.ReadLine();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            playerBall.ChangeVelocity(e.KeyCode);
        }
    }
}
