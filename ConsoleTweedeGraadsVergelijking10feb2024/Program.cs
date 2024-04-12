namespace ConsoleTweedeGraadsVergelijking10feb2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, TweedeGraadsVergelijking met a en c klein!");

            double x1 = 0; // initialisatie is noodzakelijk
            double x2 = 0;
            bool zijnGevonden = false;

            #region oefening 1
            {
                var vgl1 = new TweedeGraadsVergelijking10feb2024(0.1, 2, 1);
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
            x1 = -0,5131670194948623
            x2 = -19,486832980505138
            vgl1.YWaarde(-0,5131670194948623) = -6,661338147750939E-16
            vgl1.YWaarde(-19,486832980505138) = 0
            */

            #endregion

            #region oefening 2
            {
                var vgl2 = new TweedeGraadsVergelijking10feb2024(2, 3, 0.1);
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
            x1 = -0,034108946836182374
            x2 = -1,4658910531638176
            vgl2.YWaarde(-0,034108946836182374) = -8,326672684688674E-17
            vgl2.YWaarde(-1,4658910531638176) = -5,273559366969494E-16
            */

            #endregion

            #region oefening 3
            {
                var vgl3 = new TweedeGraadsVergelijking10feb2024(0.1, 3, 0.1);
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
            x1 = -0,03337045290423335
            x2 = -29,966629547095767
            vgl3.YWaarde(-0,03337045290423335) = 3,316791286067655E-15
            vgl3.YWaarde(-29,966629547095767) = 5,689893001203927E-15
            */

            #endregion

            Console.ReadKey();
        }
    }
}
