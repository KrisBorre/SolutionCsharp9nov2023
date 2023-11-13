namespace ConsoleZiekenhuis13nov2023
{
    internal class Patient
    {
        public string Naam { get; set; }

        public int AantalUren { get; set; }

        virtual public double BerekenKost()
        {
            return 50 + 20 * AantalUren;
        }

        public void ToonInfo()
        {
            Console.WriteLine("Naam: " + Naam);
            Console.WriteLine("Aantal Uren: " + AantalUren);
            Console.WriteLine("Kosten: " + BerekenKost());
        }
    }
}
