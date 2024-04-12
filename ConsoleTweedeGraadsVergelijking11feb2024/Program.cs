namespace ConsoleTweedeGraadsVergelijking11feb2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, TweedeGraadsVergelijking met a en c klein! Single precision Floating point getallen.");

            float x1 = 0; // initialisatie is noodzakelijk
            float x2 = 0;
            bool zijnGevonden = false;

            #region oefening 1
            {
                var vgl1 = new TweedeGraadsVergelijking11feb2024(0.1f, 2, 1);
                Console.WriteLine(vgl1);
                vgl1.ZoekNulpunten(ref x1, ref x2, ref zijnGevonden);
                if (zijnGevonden)
                {
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                    Console.WriteLine("vgl1.YWaarde(" + x1 + ") = " + vgl1.YWaarde(x1));
                    Console.WriteLine("vgl1.YWaarde(" + x2 + ") = " + vgl1.YWaarde(x2));
                }
            }

            /*
            0,1 * x * x + 2 * x + 1
            x1 = -0,5131674
            x2 = -19,486832
            vgl1.YWaarde(-0,5131674) = -7,1525574E-07
            vgl1.YWaarde(-19,486832) = -3,8146973E-06
            */

            #endregion

            #region oefening 2
            {
                var vgl2 = new TweedeGraadsVergelijking11feb2024(2, 3, 0.1f);
                Console.WriteLine(vgl2);
                vgl2.ZoekNulpunten(ref x1, ref x2, ref zijnGevonden);
                if (zijnGevonden)
                {
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                    Console.WriteLine("vgl2.YWaarde(" + x1 + ") = " + vgl2.YWaarde(x1));
                    Console.WriteLine("vgl2.YWaarde(" + x2 + ") = " + vgl2.YWaarde(x2));
                }
            }

            /*
            2 * x * x + 3 * x + 0,1
            x1 = -0,034108937
            x2 = -1,4658911
            vgl2.YWaarde(-0,034108937) = 2,9802322E-08
            vgl2.YWaarde(-1,4658911) = 9,685755E-08
            */

            #endregion

            #region oefening 3
            {
                var vgl3 = new TweedeGraadsVergelijking11feb2024(0.1f, 3, 0.1f);
                Console.WriteLine(vgl3);
                vgl3.ZoekNulpunten(ref x1, ref x2, ref zijnGevonden);
                if (zijnGevonden)
                {
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                    Console.WriteLine("vgl3.YWaarde(" + x1 + ") = " + vgl3.YWaarde(x1));
                    Console.WriteLine("vgl3.YWaarde(" + x2 + ") = " + vgl3.YWaarde(x2));
                }
            }

            /*
            0,1 * x * x + 3 * x + 0,1
            x1 = -0,033370256
            x2 = -29,96663
            vgl3.YWaarde(-0,033370256) = 5,8859587E-07
            vgl3.YWaarde(-29,96663) = 1,527369E-06
            */

            #endregion

            Console.ReadKey();
        }
    }
}
