using LLCLib;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;

ProcessData processData = ProcessLib.GetProcessData();

string cmd = processData.riotClientCmd;

Regex regex = new Regex(@"([\s\w\\\/\:]+)(?:Riot Client[\/\\]RiotClientServices.exe)");
var matches = regex.Matches(processData.riotClientCmd).ToList();
Console.WriteLine($"{matches[0].Groups[1]}Game\\DATA\\FINAL\\Localized");

//Process.GetProcessById(processData.leagueClient.Id).Kill();

//Process newProcess = new Process();
//ProcessStartInfo startInfo = new ProcessStartInfo();
//startInfo.WindowStyle = ProcessWindowStyle.Hidden;
//startInfo.FileName = "cmd.exe";
//startInfo.Arguments = $"/C {cmd}";

//newProcess.StartInfo = startInfo;
//newProcess.Start();
