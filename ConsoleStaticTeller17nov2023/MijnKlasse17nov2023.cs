namespace ConsoleStaticTeller17nov2023
{
    internal class MijnKlasse17nov2023
    { 
        private static int instantieTeller = 0;
        public const int getal1 = 1;
        public static readonly int getal2;

        static MijnKlasse17nov2023()
        {
            Console.WriteLine("Dit wordt uitgevoerd voor er een instantie van MijnKlasse is gemaakt.");
            getal2 = 2;
        }

        // constructor
        public MijnKlasse17nov2023()
        {
            Console.WriteLine("Constructie van een " + this.GetType());
            instantieTeller++;
        }

        public static int InstantieTeller
        {
            get
            {
                return instantieTeller;
            }
        }



    }
}
