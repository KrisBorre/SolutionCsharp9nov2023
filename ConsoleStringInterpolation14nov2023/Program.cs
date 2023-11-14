internal class Program
{
    private static void Main(string[] args)
    {
        int[] i = new int[5];
        double[] d = new double[5];
        int j = 1; i[j] = -1 + 4 * 6;
        j++; i[j] = (35 + 5) % 7;
        j++; i[j] = 14 + -4 * 6 / 11;
        j++; i[j] = 2 + 15 / 6 * 1 - 7 % 2;

        j = 1; d[j] = -1 + 4 * 6;
        j++; d[j] = (35 + 5) % 7;
        j++; d[j] = 14 + -4 * 6 / 11;
        j++; d[j] = 2 + 15 / 6 * 1 - 7 % 2;

        j = 1; Console.WriteLine($"Met int is -1 + 4 * 6 gelijk aan {i[j]}. En met double is -1 + 4 * 6 gelijk aan {d[j]}.");
        j++; Console.WriteLine($"Met int is (35 + 5) % 7 gelijk aan {i[j]}. En met double is (35 + 5) % 7 gelijk aan {d[j]}.");
        j++; Console.WriteLine($"Met int is 14 + -4 * 6 / 11 gelijk aan {i[j]}. En met double is 14 + -4 * 6 / 11 gelijk aan {d[j]}.");
        j++; Console.WriteLine($"Met int is 2 + 15 / 6 * 1 - 7 % 2 gelijk aan {i[j]}. En met double is 2 + 15 / 6 * 1 - 7 % 2 gelijk aan {d[j]}.");

        /*
Met int is -1 + 4 * 6 gelijk aan 23. En met double is -1 + 4 * 6 gelijk aan 23.
Met int is (35 + 5) % 7 gelijk aan 5. En met double is (35 + 5) % 7 gelijk aan 5.
Met int is 14 + -4 * 6 / 11 gelijk aan 12. En met double is 14 + -4 * 6 / 11 gelijk aan 12.
Met int is 2 + 15 / 6 * 1 - 7 % 2 gelijk aan 3. En met double is 2 + 15 / 6 * 1 - 7 % 2 gelijk aan 3.
        */

        Console.WriteLine("Kris Borremans");
        Console.Read();
    }
}