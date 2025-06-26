
using System.Diagnostics;
using System;
using System.Text.Json;
namespace AppBlockerRunApplication
{
    public static class RunApplication
    {
        public static void DetectIfFilesAreRunning(string fileName)
        {
            // get current time and convert to military time
            DateTime currentTime = DateTime.Now;
            var convertTimeToMilitary = currentTime.ToString("HH:mm");
            // get the json data
            string json = File.ReadAllText(fileName);
            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;

            // get paths from the json
            string[] paths = JsonSerializer.Deserialize<string[]>(root.GetProperty("Paths"));
            // get time from json
            string time = root.GetProperty("Time").GetString();
            // get days from json
            string days = root.GetProperty("Days").GetString();
            // get block set name
            string blockName = root.GetProperty("Blockset").GetString();

            var targetPaths = FindEndOfPath(paths);
            
            (string firstTime, string secondTime) = BreakUpTimes(time);
            
            bool on = true;
            while (on)
            {
                foreach (var path in targetPaths)
                {
                    foreach (var process in Process.GetProcessesByName(path))
                    {

                        if (CompareCurrentTimeToBlockTime(time, convertTimeToMilitary))
                        {
                            process.Kill();
                            process.WaitForExit();
                        }
                        else
                        {
                            on = false;
                            break;
                        }
                    }
                }
            }   
        }

        public static bool CompareCurrentTimeToBlockTime(string userTime, string currentMilitaryTime)
        {
            var splitUserTime = userTime.Split("-");
            return (int.Parse(currentMilitaryTime.Replace(":", "")) > int.Parse(splitUserTime[0].Replace(":", "")));
        }
        public static List<string> FindEndOfPath(string[] paths)
        {
            List<string> finalPaths = new();
            foreach (var path in paths)
            {
                string holder = "";
                for (int i = path.Length - 1; i >= 0; i--)
                {
                    if (path[i] == '\\')
                    {
                        string reversedPath = new string(holder.Reverse().ToArray());
                        finalPaths.Add(reversedPath);
                        break;
                    }
                    else
                    {
                        holder += path[i];
                    }
                }
            }
            return finalPaths;
        }
    }
}
