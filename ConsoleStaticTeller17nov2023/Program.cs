namespace ConsoleStaticTeller17nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello InstantieTeller!");

            MijnKlasse17nov2023 mijnKlasse1;
            MijnKlasse17nov2023 mijnKlasse2;
            Console.WriteLine("InstantieTeller = " + MijnKlasse17nov2023.InstantieTeller);
            MijnKlasse17nov2023 mijnKlasse3 = new MijnKlasse17nov2023();
            MijnKlasse17nov2023 mijnKlasse4 = new MijnKlasse17nov2023();
            Console.WriteLine("InstantieTeller = " + MijnKlasse17nov2023.InstantieTeller);
            Console.WriteLine("MijnKlasse17nov2023.getal1 = " + MijnKlasse17nov2023.getal1);
            MijnKlasse17nov2023 mijnKlasse5 = new MijnKlasse17nov2023();
            Console.WriteLine("MijnKlasse17nov2023.getal2 = " + MijnKlasse17nov2023.getal2);
            Console.WriteLine("mijnKlasse3.ToString() = " + mijnKlasse3.ToString());
            Console.WriteLine("InstantieTeller = " + MijnKlasse17nov2023.InstantieTeller);

            // Hello InstantieTeller!
            // Dit wordt uitgevoerd voor er een instantie van MijnKlasse is gemaakt.
            // InstantieTeller = 0
            // Constructie van een ConsoleStaticTeller17nov2023.MijnKlasse17nov2023
            // Constructie van een ConsoleStaticTeller17nov2023.MijnKlasse17nov2023
            // InstantieTeller = 2
            // MijnKlasse17nov2023.getal1 = 1
            // Constructie van een ConsoleStaticTeller17nov2023.MijnKlasse17nov2023
            // MijnKlasse17nov2023.getal2 = 2
            // mijnKlasse3.ToString() = ConsoleStaticTeller17nov2023.MijnKlasse17nov2023
            // InstantieTeller = 3

            Console.ReadLine();
        }
    }
}