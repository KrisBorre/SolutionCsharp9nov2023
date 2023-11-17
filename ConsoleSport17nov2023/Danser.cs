namespace ConsoleSport17nov2023
{
    public enum Schoenen { Latin, Ballet, Flamenco, Tap, HipHop };

    public class Danser
    {
        public string Naam { get; set; }

        private int leeftijd;

        public int Leeftijd
        {
            get { return leeftijd; }
            set { if (value > 0) { leeftijd = value; } }
        }

        private Schoenen dansschoenen;

        public Schoenen Dansschoenen
        {
            get { return dansschoenen; }
            set { dansschoenen = value; }
        }

        private Danser danspartner;

        public Danser Danspartner
        {
            get { return danspartner; }
            set { danspartner = value; }
        }

        private int aantalWedstrijden;

        public int AantalWedstrijden
        {
            get
            {
                return aantalWedstrijden;
            }
            set
            {
                if (value > 0)
                {
                    aantalWedstrijden = value;
                }
            }
        }

        public void Dans()
        {
            Console.WriteLine($"{Naam} danst.");
        }

        public void Win()
        {
            Console.WriteLine($"{Naam} heeft weer een danswedstrijd gewonnen ....");
        }

        public void StelIn(string naam, int leeftijd, Schoenen dansschoenen, Danser danspartner, int aantalWedstrijden)
        {
            this.Naam = naam;
            this.Leeftijd = leeftijd;
            this.Dansschoenen = dansschoenen;
            this.Danspartner = danspartner;
            this.AantalWedstrijden = aantalWedstrijden;
        }

        public void Toon()
        {
            if (this.Danspartner != null) Console.WriteLine($"Danser {this.Naam} danst met {this.Danspartner.Naam}.");
            Console.WriteLine($"Danser {this.Naam} heeft {this.AantalWedstrijden} keer gedanst.");
            Console.WriteLine($"Danser {this.Naam} heeft {this.Dansschoenen} dansschoenen.");
        }
    }


}
