namespace WinFormsBalspel4feb2024
{
    internal class Ball
    {
        private int radius = 10;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        private int x = 0;
        private int y = 0;

        protected int vx = 0;
        protected int vy = 0;

        protected char drawChar = 'O';

        protected ConsoleColor drawColor = ConsoleColor.Red;
        protected Color color = Color.Red;

        public Ball(int xin, int yin, int vxin, int vyin)
        {
            x = xin;
            y = yin;
            vx = vxin;
            vy = vyin;
        }

        /// <summary>
        /// We maken een klasse Ball die via Update en Draw zichzelf over het consolescherm beweegt
        /// </summary>
        public void Update()
        {
            x += vx;
            y += vy;
            if (x >= Console.WindowWidth || x < 0)
            {
                vx *= -1;
                x += vx;
            }
            if (y >= Console.WindowHeight || y < 0)
            {
                vy *= -1;
                y += vy;
            }
        }

        public void Update(Size clientSize)
        {
            x += vx;
            y += vy;
            if (x >= (clientSize.Width - radius) || x < 0)
            {
                vx *= -1;
                x += vx;
            }
            if (y >= (clientSize.Height - radius) || y < 0)
            {
                vy *= -1;
                y += vy;
            }
        }

        /// <summary>
        /// We maken een klasse Ball die via Update en Draw zichzelf over het consolescherm beweegt
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = drawColor;
            Console.Write(drawChar);
            Console.ResetColor();
        }

        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(color);
            pen.Width = 5;
            graphics.DrawEllipse(pen, this.x, this.y, this.radius, this.radius);
        }

        /// <summary>
        /// Een static methode CheckHit laat ons toe te ontdekken of twee Ballobjecten mekaar raken
        /// </summary>
        /// <param name="ball1"></param>
        /// <param name="ball2"></param>
        /// <returns></returns>
        static public bool CheckHit(Ball ball1, Ball ball2)
        {
            if (ball1.X == ball2.X && ball1.Y == ball2.Y)
                return true;

            return false;
        }
    }
}
