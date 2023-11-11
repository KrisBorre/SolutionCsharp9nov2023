namespace ConsoleBalspel11nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij Balspel!");

            Console.CursorVisible = false;
            Console.WindowHeight = 20;
            Console.WindowWidth = 30;
            Ball ball1 = new Ball(4, 4, 1, 0);
            Ball ball2 = new Ball(9, 2, 0, 1);
            Ball ball3 = new Ball(15, 17, -1, 0);
            Ball ball4 = new Ball(12, 3, -1, -1);
            PlayerBall playerBall = new PlayerBall(10, 10, 0, 0);

            while (true)
            {
                Console.Clear();

                // Balls
                ball1.Update();
                ball2.Update();
                ball3.Update();
                ball4.Update();
                ball1.Draw();
                ball2.Draw();
                ball3.Draw();
                ball4.Draw();

                // SpelerBal
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    playerBall.ChangeVelocity(key);
                }

                playerBall.Update();
                playerBall.Draw();

                // Check collisions
                if (Ball.CheckHit(ball1, playerBall) || Ball.CheckHit(ball2, playerBall) || Ball.CheckHit(ball3, playerBall) || Ball.CheckHit(ball4, playerBall))
                {
                    Console.Clear();
                    Console.WriteLine("Gewonnen!");
                    Console.ReadLine();
                }
                System.Threading.Thread.Sleep(100);
            }

        }
    }
}