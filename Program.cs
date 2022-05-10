// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

string ExecutableFilePath = @"Scripts.bat";
string Arguments = @"";

if (File.Exists(ExecutableFilePath))
{
    ProcessStartInfo psi = new ProcessStartInfo(ExecutableFilePath, Arguments);
    psi.UseShellExecute = false;
    psi.CreateNoWindow = true;
    Process.Start(psi);
}

Console.WriteLine("Hello, World!");
