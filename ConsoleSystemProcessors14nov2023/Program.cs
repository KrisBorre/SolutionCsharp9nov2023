internal class Program
{
    private static void Main(string[] args)
    {
        //  Invoke this sample with an arbitrary set of command line arguments.
        Console.WriteLine("CommandLine: {0}", Environment.CommandLine);

        string[] arguments = Environment.GetCommandLineArgs();
        Console.WriteLine("GetCommandLineArgs: {0}", String.Join(", ", arguments));

        //  <-- Keep this information secure! -->
        Console.WriteLine("CurrentDirectory: {0}", Environment.CurrentDirectory);

        bool is64bit = Environment.Is64BitOperatingSystem;
        Console.WriteLine($"Is it a 64 bit operating system: {is64bit}.");

        //  <-- Keep this information secure! -->
        string pcname = Environment.MachineName;
        Console.WriteLine($"PC name: {pcname}");

        int proccount = Environment.ProcessorCount;
        Console.WriteLine($"Number of processors: {proccount}");

        //  <-- Keep this information secure! -->
        string username = Environment.UserName;
        Console.WriteLine($"UserName: {username}");

        long memory = Environment.WorkingSet;
        long memoryInMb = memory / 1_000_000; // _ is de digit separator, geintroduceerd in C# 7.0 en Maart 2017.
        Console.WriteLine($"The physical memory mapped to the process context is {memoryInMb} Megabytes.");
        Console.WriteLine("OSVersion: {0}", Environment.OSVersion.ToString());

        Console.WriteLine("Kris Borremans");
        Console.Read();
    }
}