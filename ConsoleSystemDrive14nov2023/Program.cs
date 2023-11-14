internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welke drive wil je bekijken: (Hint: 1)");
        int driveNummer = Convert.ToInt32(Console.ReadLine()) - 1;

        if (driveNummer >= 0 && driveNummer < DriveInfo.GetDrives().Length)
        {
            long cdriveinbytes = DriveInfo.GetDrives()[driveNummer].AvailableFreeSpace;
            long cdriveInMegaBytes = cdriveinbytes / 1_000_000;
            Console.WriteLine($"The amount of free space on a drive is {cdriveInMegaBytes} Megabytes.");
            long totalsize = DriveInfo.GetDrives()[driveNummer].TotalSize;
            long totalsizeInMegaBytes = totalsize / 1_000_000;
            Console.WriteLine($"The total size of storage space on a drive is {totalsizeInMegaBytes} Megabytes.");
        }

        Console.WriteLine("Kris Borremans");
        Console.Read();
    }
}