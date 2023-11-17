namespace ConsoleSport17nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij danssport!");
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
            Console.ReadLine();
        }
    }
}