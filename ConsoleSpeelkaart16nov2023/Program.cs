namespace ConsoleSpeelkaart16nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij Speelkaarten!");

            List<Speelkaart16nov2023> kaartenboek = new List<Speelkaart16nov2023>();

            for (int i = 1; i <= 13; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    kaartenboek.Add(new Speelkaart16nov2023() { Getal = i, Kleur = (SpeelkaartKleur)k });
                }
            }

            Console.WriteLine("Het aantal kaarten is " + kaartenboek.Count); // 52

            Random r = new Random();

            for (int i = 0; i < 52; i++)
            {
                int trek = r.Next(0, 52 - i);
                Speelkaart16nov2023 getrokken = kaartenboek[trek];
                Console.WriteLine($"{getrokken.Kleur} {getrokken.Getal}");
                kaartenboek.RemoveAt(trek);
            }

            Console.WriteLine("Het aantal kaarten is " + kaartenboek.Count); // 0
            Console.ReadLine();
        }
    }
}