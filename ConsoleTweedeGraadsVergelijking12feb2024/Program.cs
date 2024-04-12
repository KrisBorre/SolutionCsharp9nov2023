namespace ConsoleTweedeGraadsVergelijking12feb2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TweedeGraadsVergelijking met a en c klein!");
            Console.WriteLine("Single precision Floating point getallen.");

            float x1 = 0; // initialisatie is noodzakelijk
            float x2 = 0;
            bool zijnGevonden = false;

            #region oefening 1
            {
                var vgl1 = new TweedeGraadsVergelijking12feb2024(0.001f, 2, 1);
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
x1 = -0,5001426
x2 = -1999,4998
vgl1.YWaarde(-0,5001426) = -3,504753E-05
vgl1.YWaarde(-1999,4998) = 0
            */

            #endregion

            #region oefening 2
            {
                var vgl2 = new TweedeGraadsVergelijking12feb2024(2, 3, 0.001f);
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
x1 = -0,00033342838
x2 = -1,4996666
vgl2.YWaarde(-0,00033342838) = -6,274786E-08
vgl2.YWaarde(-1,4996666) = 7,2526745E-08
            */

            #endregion

            #region oefening 3
            {
                var vgl3 = new TweedeGraadsVergelijking12feb2024(0.001f, 3, 0.001f);
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
x1 = -0,00035762784
x2 = -2999,9993
vgl3.YWaarde(-0,00035762784) = -7,2883326E-05
vgl3.YWaarde(-2999,9993) = -0,00095312495
            */

            #endregion

            Console.ReadKey();
        }
    }
}
