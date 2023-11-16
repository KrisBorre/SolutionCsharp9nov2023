namespace ConsoleSpeelkaart16nov2023
{
    internal enum SpeelkaartKleur { Schoppen, Harten, Klaveren, Ruiten }
    
    internal class Speelkaart16nov2023
    {
        private int getal;
        public int Getal
        {
            get
            {
                return getal;
            }
            set
            {
                if (value > 0 && value < 14) getal = value;
                else Console.WriteLine("Fout: Getal kan niet kleiner of gelijk zijn aan nul. Getal kan ook niet groter of gelijk zijn aan 14.");
            }
        }

        public SpeelkaartKleur Kleur { get; set; }

    }
}
