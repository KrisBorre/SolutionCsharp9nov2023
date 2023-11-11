namespace ConsoleBalspel11nov2023
{
    /// <summary>
    /// De overgeërfde klasse PlayerBall is een Ball maar zal z'n vx en vy updaten gebaseerd op input via de ChangeVelocity methode.
    /// </summary>
    internal class PlayerBall : Ball
    {
        public PlayerBall(int xin, int yin, int vxin, int vyin) : base(xin, yin, vxin, vyin)
        {
            drawChar = 'X';
            drawColor = ConsoleColor.Green;
        }

        public void ChangeVelocity(ConsoleKeyInfo richting)
        {
            switch (richting.Key)
            {
                case ConsoleKey.UpArrow:
                    vy--;
                    break;
                case ConsoleKey.DownArrow:
                    vy++;
                    break;
                case ConsoleKey.LeftArrow:
                    vx--;
                    break;
                case ConsoleKey.RightArrow:
                    vx++;
                    break;
                default:
                    break;
            }
        }
    }
}
