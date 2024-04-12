namespace ConsoleTweedeGraadsVergelijking13feb2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TweedeGraadsVergelijking met a en c klein!");
            Console.WriteLine("decimal getallen.");

            decimal x1 = 0; // initialisatie is noodzakelijk
            decimal x2 = 0;
            bool zijnGevonden = false;

            #region oefening 1
            {
                var vgl1 = new TweedeGraadsVergelijking13feb2024(0.001M, 2, 1);
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
            0,001 * x * x + 2 * x + 1
            x1 = -0,50012506254
            x2 = -1999,49987493746
            vgl1.YWaarde(-0,50012506254) = -0,000000000001819361
            vgl1.YWaarde(-1999,49987493746) = 0,00000000000
            */

            #endregion

            #region oefening 2
            {
                var vgl2 = new TweedeGraadsVergelijking13feb2024(2, 3, 0.001M);
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
            2 * x * x + 3 * x + 0,001
            x1 = -0,0003334074403475
            x2 = -1,4996665925596525
            vgl2.YWaarde(-0,0003334074403475) = 0,000000000000000058144
            vgl2.YWaarde(-1,4996665925596525) = 0,0000000000000025
            */

            #endregion

            #region oefening 3
            {
                var vgl3 = new TweedeGraadsVergelijking13feb2024(0.001M, 3, 0.001M);
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
            0,001 * x * x + 3 * x + 0,001
            x1 = -0,00033333337
            x2 = -2999,99966666663
            vgl3.YWaarde(-0,00033333337) = 0,000000000001111135555557
            vgl3.YWaarde(-2999,99966666663) = 0,00000000000
            */

            #endregion

            Console.ReadKey();
        }
    }
}
