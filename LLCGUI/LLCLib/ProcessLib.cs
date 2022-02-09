using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LLCLib
{
    public static class ProcessLib
    {
        public static string GetCommandLine(this Process process)
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id))
            using (ManagementObjectCollection objects = searcher.Get())
            {
                return objects.Cast<ManagementBaseObject>().SingleOrDefault()?["CommandLine"]?.ToString();
            }
        }

        public static List<String> ParseLanguagesFile(string dirPath)
        {
            List<string> search = new List<string>();

            Directory.GetFiles(dirPath).ToList().ForEach(file =>
            {
                search.Add(file.Split("\\").Last().Replace("Global.", "").Replace(".wad.client", ""));
            });


            return search;
        }

        public static ProcessData GetProcessData()
        {
            ProcessData processData = new ProcessData();

            foreach (var process in Process.GetProcesses())
            {
                if (process.ProcessName.Contains("RiotClientServices"))
                {
                    processData.riotClient = process;
                    processData.riotClientCmd = process.GetCommandLine();

                    Regex regex = new Regex(@"([\s\w\\\/\:]+)(?:Riot Client[\/\\]RiotClientServices.exe)");
                    var matches = regex.Matches(processData.riotClientCmd).ToList();
                    var dirPath = $"{matches[0].Groups[1]}Game\\DATA\\FINAL\\Localized";

                    List<string> search = ParseLanguagesFile(dirPath);

                    processData.languages = search;
                    processData.languageFolder = dirPath;
                    processData.currentLanguage = GetCurrentLanguage(processData.riotClientCmd);
                }

                if (process.ProcessName.Equals("LeagueClient"))
                {
                    processData.leagueClient = process;
                }
            }

            return processData;
        }

        public static string GetCurrentLanguage(string cmd)
        {
            Regex regex = new Regex(@"(--[\w\d\S]+)=([\w\d]+)");
            List<Match> matches = regex.Matches(cmd).ToList();

            foreach (Match match in matches)
            {
                var argName = match.Groups[1].Value;
                if (argName.Contains("locale"))
                {
                    return match.Groups[2].Value;
                }
            }

            return null;
        }

        public static void RunGame(this ProcessData processData, string language)
        {
            try
            {
                var process = Process.GetProcessById(processData.leagueClient.Id);
                process.Kill();
            }
            catch (Exception ex) { throw new Exception(); }

            string cmd = processData.riotClientCmd;

            var fullLocale = $"--locale={GetCurrentLanguage(cmd)}";
            cmd = cmd.Replace(fullLocale, $"--locale={language}");

            Process newProcess = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C {cmd}";
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            newProcess.StartInfo = startInfo;
            newProcess.Start();
        }
    }
}
