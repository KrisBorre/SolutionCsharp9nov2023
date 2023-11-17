using ConsoleSport17nov2023;
using ConsoleSportSimulator17nov2023;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Sport simulator: SimuleerSport klasse
        {
            Console.WriteLine("Welkom bij de Sport Simulator!");

            Danser tom = new Danser();
            Danser eva = new Danser();
            Danser karol = new Danser();
            Danser brian = new Danser();
            Danser heidi = new Danser();

            tom.AantalWedstrijden = 10;
            eva.AantalWedstrijden = 4;
            brian.AantalWedstrijden = 3;
            brian.StelIn("Brian", 5, Schoenen.Tap, heidi, brian.AantalWedstrijden);
            heidi.AantalWedstrijden = 3;
            heidi.Naam = "Heidi";
            tom.StelIn("Tom", 12, Schoenen.Latin, eva, tom.AantalWedstrijden);
            eva.Naam = "Eva";
            eva.Dansschoenen = Schoenen.Latin;
            karol.StelIn("Karol", 8, Schoenen.Flamenco, new Danser(), 2);
            tom.Toon();
            eva.Toon();
            karol.Toon();
            brian.Toon();
            tom.Dans();
            tom.Win();

            Console.WriteLine("Test je methode door 2 objecten aan te maken en telkens mee te geven als parameter.");
            SportSimulator.SimuleerDanser(eva);
            SportSimulator.SimuleerDanser(heidi);

            Console.WriteLine("Welkom bij een Wedstrijd.");
            SportSimulator.SimuleerWedstrijd(tom, brian);

            Console.WriteLine("Wedstrijd 2");
            Danser winnaar2 = SportSimulator.BesteDanser(danser1: eva, danser2: karol);
            Console.WriteLine($"{winnaar2.Naam} wint.");
            winnaar2.Dans();
            winnaar2.Toon();
            winnaar2.Win();

            Console.WriteLine("Wedstrijd 3");
            Danser winnaar3 = SportSimulator.BesteDanser(heidi, tom);
            Console.WriteLine($"{winnaar3.Naam} wint.");
            winnaar3.Dans();
            winnaar3.Toon();
            winnaar3.Win();

            Console.ReadLine();
        }
        #endregion
    }
}