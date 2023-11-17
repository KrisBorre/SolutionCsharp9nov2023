using ConsoleSport17nov2023;

namespace ConsoleSportSimulator17nov2023
{
    internal class SportSimulator
    {
        static Random ran = new Random();

        /// <summary>
        /// De SimuleerSpeler-methode zal beide methoden van je klasse telkens 3x aanroepen m.b.v. een for-loop in de methode (dus in mijn geval 3xGooiBal en 3xWatertrappen)
        /// </summary>
        /// <param name="danser"></param>
        public static void SimuleerDanser(Danser danser)
        {
            for (int i = 0; i < 3; i++)
            {
                danser.Dans();
            }
            for (int i = 0; i < 3; i++)
            {
                danser.Win();
            }
        }

        /// <summary>
        /// Bij aanroep van de methode verschijnt er op het scherm wie van beide speler zou winnen als ze zouden spelen. 
        /// Gebruik een random uitkomst om te bepalen over speler 1 of 2 wint. Toon op het scherm "Speler 1 wint." 
        /// Gevolg door de aanroep van iedere methode van die speler.
        /// </summary>
        /// <param name="danser1"></param>
        /// <param name="danser2"></param>
        public static void SimuleerWedstrijd(Danser danser1, Danser danser2)
        {
            Danser winnaar;
            int iWinnaar = ran.Next(1, 3); // 1 of 2
            if (iWinnaar == 1) winnaar = danser1;
            else winnaar = danser2;
            Console.WriteLine($"{winnaar.Naam} wint.");
            winnaar.Dans();
            winnaar.Toon();
            winnaar.Win();
        }

        /// <summary>
        /// Deze methode gaat ook random bepalen welke speler de beste is. Vervolgens geef je deze speler terug als resultaat. In de main roep je vervolgens iedere methode van dit object aan.
        /// </summary>
        /// <param name="danser1"></param>
        /// <param name="danser2"></param>
        /// <returns></returns>
        public static Danser BesteDanser(Danser danser1, Danser danser2)
        {
            Danser winnaar;

            int iWinnaar = ran.Next(1, 3); // 1 of 2
            if (iWinnaar == 1) winnaar = danser1;
            else winnaar = danser2;

            return winnaar;
        }
    }
}
