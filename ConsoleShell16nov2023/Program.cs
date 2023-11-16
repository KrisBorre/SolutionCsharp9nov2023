#region Microsoft Notepad
{
    Console.WriteLine("Notepad");
    System.Diagnostics.Process process1 = new System.Diagnostics.Process();
    process1.StartInfo.FileName = "notepad";
    process1.StartInfo.Arguments = "mijn_test.txt";
    process1.Start();
    Console.WriteLine();
}
#endregion

#region gswin
try
{
    Console.WriteLine("gswin");
    // Ghostscript is an interpreter for the PostScript language and PDF files
    System.Diagnostics.Process process2 = new System.Diagnostics.Process();
    process2.StartInfo.FileName = @"C:\Program Files\gs\gs9.50\bin\gswin64.exe";
    process2.StartInfo.Arguments = @"C:\Users\Kris\Pictures\monkey.ps";
    process2.Start();
    Console.WriteLine();
}
catch
{ }
#endregion

#region ipconfig
{
    Console.WriteLine("ipconfig");
    System.Diagnostics.Process process3 = new System.Diagnostics.Process();
    process3.StartInfo.FileName = "ipconfig";
    process3.StartInfo.Arguments = "/all";
    process3.StartInfo.UseShellExecute = false;
    process3.StartInfo.RedirectStandardOutput = true;
    process3.StartInfo.RedirectStandardError = true;
    process3.Start();

    // Read the output (or the error)
    string output = process3.StandardOutput.ReadToEnd(); // normal output
    Console.WriteLine(output);
    string err = process3.StandardError.ReadToEnd(); // error output (if any)
    Console.WriteLine(err);

    Console.WriteLine();
}
#endregion

#region Explorer
{
    Console.WriteLine("Explorer");
    System.Diagnostics.Process process4 = new System.Diagnostics.Process();
    process4.StartInfo.FileName = "explorer";
    process4.Start();
}
#endregion

#region Microsoft Paint
{
    Console.WriteLine("Microsoft Paint");
    System.Diagnostics.Process process5 = new System.Diagnostics.Process();
    process5.StartInfo.FileName = "mspaint";
    process5.Start();
}
#endregion

// Microsoft Edge (see ConsoleBookmark projects) 
// Internet Explorer (see ConsoleBookmark projects) "C:\Program Files\Internet Explorer\iexplore.exe"
// en dan wordt op Windows 10 Edge geopend.

Console.WriteLine("Klaar");
