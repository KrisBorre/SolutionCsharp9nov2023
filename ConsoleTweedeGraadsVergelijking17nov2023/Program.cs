namespace ConsoleTweedeGraadsVergelijking17nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hallo TweedeGraadsVergelijking!");

            double x1 = 0; // initialisatie is noodzakelijk
            double x2 = 0;
            bool zijnGevonden = false;

            #region oefening 1
            {
                TweedeGraadsVergelijking vgl1 = new TweedeGraadsVergelijking(1, 2, 1);
                Console.WriteLine(vgl1);
                vgl1.ZoekNulpunten(ref x1, ref x2, ref zijnGevonden);
                if (zijnGevonden)
                {
                    Console.WriteLine("x1 = " + x1); // -1
                    Console.WriteLine("x2 = " + x2); // -1
                    Console.WriteLine("vgl1.YWaarde(" + x1 + ") = " + vgl1.YWaarde(x1));
                    Console.WriteLine("vgl1.YWaarde(" + x2 + ") = " + vgl1.YWaarde(x2));
                }
            }
            #endregion

            #region oefening 2
            {
                TweedeGraadsVergelijking vgl2 = new TweedeGraadsVergelijking(2, 3, 1);
                Console.WriteLine(vgl2);
                vgl2.ZoekNulpunten(ref x1, ref x2, ref zijnGevonden);
                if (zijnGevonden)
                {
                    Console.WriteLine("x1 = " + x1); // -0,5
                    Console.WriteLine("x2 = " + x2); // -1
                    Console.WriteLine("vgl2.YWaarde(" + x1 + ") = " + vgl2.YWaarde(x1));
                    Console.WriteLine("vgl2.YWaarde(" + x2 + ") = " + vgl2.YWaarde(x2));
                }
            }
            #endregion

            Console.WriteLine("Kris Borremans");
            Console.ReadLine();
        }
    }
}