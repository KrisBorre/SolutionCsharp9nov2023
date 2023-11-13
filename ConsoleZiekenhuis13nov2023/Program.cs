namespace ConsoleZiekenhuis13nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welkom in het Ziekenhuis!");

            {
                Patient p1 = new Patient();
                p1.Naam = "Jan";
                p1.AantalUren = 10;
                p1.ToonInfo();
            }
            {
                Patient p2 = new VerzekerdePatient();
                p2.Naam = "Piet";
                p2.AantalUren = 10;
                p2.ToonInfo();
            }
            {
                VerzekerdePatient p3 = new VerzekerdePatient();
                p3.Naam = "Karel";
                p3.AantalUren = 10;
                p3.ToonInfo();
            }

            Console.ReadLine();
        }
    }
}