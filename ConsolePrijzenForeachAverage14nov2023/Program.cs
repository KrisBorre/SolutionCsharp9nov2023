namespace ConsolePrijzenForeachAverage14nov2023
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Prijzen met Foreach en Average
            {
                Console.WriteLine("Welkom bij Prijzen met Foreach en Average!");

                const int LENGTH = 3; // 20;
                double[] array = new double[LENGTH];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Geef een prijs: ");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out double result))
                    {
                        array[i] = result;
                    }
                }

                Console.WriteLine("De prijzen hoger of gelijk aan 5 zijn: ");
                foreach (double prijs in array)
                {
                    if (prijs >= 5)
                    {
                        Console.Write(prijs + "\t");
                    }
                }
                Console.WriteLine();

                Console.WriteLine("Het gemiddelde van alle prijzen is " + array.Average());
                Console.ReadLine();
            }
            #endregion
        }
    }
}
