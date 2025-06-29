

using System.Diagnostics;
using System.Text.Json;
namespace AppBlockerRunApplication
{
    public static class RunApplication
    {
        public static string ConvertCurrentTimeToMilitaryTime()
        {
            // get current time and convert to military time
            DateTime currentTime = DateTime.Now;
            var convertTimeToMilitary = currentTime.ToString("HH:mm");
            return convertTimeToMilitary;
        }
        // json method to read from
        public static JsonDocument LoadJson(string fileName)
        {
            // get the json data
            string json = File.ReadAllText(fileName);
            return JsonDocument.Parse(json);
        }
        // json elements
        public static string GetJsonTimeProperty(JsonElement root) =>
            root.GetProperty("Time").GetString();
        public static string[] GetJsonPathsProperty(JsonElement root) =>
            JsonSerializer.Deserialize<string[]>(root.GetProperty("Paths"));
        public static string GetJsonDaysProperty(JsonElement root) =>
            root.GetProperty("Days").GetString();
        public static string GetJsonBlockNameProperty(JsonElement root) =>
            root.GetProperty("Blockset").GetString();
        
        public static void MainKillLoop(string fileName)
        {
            using var doc = LoadJson(fileName);
            var root = doc.RootElement;
            var paths = GetJsonPathsProperty(root);
            var time = GetJsonTimeProperty(root);
            string convertTimeToMilitary = ConvertCurrentTimeToMilitaryTime();
            var targetPaths = FindEndOfPath(paths);
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
              
        // checks if the current time is within the time limit set
        public static bool CompareCurrentTimeToBlockTime(string userTime, string currentMilitaryTime)
        {
            var splitUserTime = userTime.Split("-");
            return (int.Parse(currentMilitaryTime.Replace(":", "")) > int.Parse(splitUserTime[0].Replace(":", "")) && int.Parse(splitUserTime[1].Replace(":", "")) > int.Parse(currentMilitaryTime.Replace(":", "")));
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
