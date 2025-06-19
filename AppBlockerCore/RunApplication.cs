using System.ComponentModel;
using System.Diagnostics;

namespace AppBlockerRunApplication
{
    class RunApplication
    {
        public static void DetectIfFilesAreRunning()
        {
            DateTime currentTime = DateTime.Now;
            var convertTimeToMilitary = currentTime.ToString("HHmm");
            List<string> paths = File.ReadAllLines(@"C:\Users\samlo\OneDrive\Desktop\tempcsharp\AppBlocker\user_files_to_block.txt").Select(p => p.Trim().ToLower()).ToList();
            var targetPaths = FindEndOfPath(paths);
            var time = File.ReadAllLines("time_frame_to_block.txt");
            (string firstTime, string secondTime) = BreakUpTimes(time);
            var newFirstTime = int.Parse(firstTime);
            var newSecondTime = int.Parse(secondTime);
            var newMilitaryTime = int.Parse(convertTimeToMilitary);
            bool on = true;
            while (on)
            {
                foreach (var path in targetPaths)
                {
                    foreach (var process in Process.GetProcessesByName(path))
                    {

                        if (newMilitaryTime > newFirstTime)
                        {
                            process.Kill();
                            process.WaitForExit();
                        }
                        else if (newSecondTime > newMilitaryTime)
                        {
                            on = false;
                            break;
                        }
                    }
                }
            }   
        }

        public static List<string> FindEndOfPath(List<string> paths)
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

        public static (string, string) BreakUpTimes(string[] times)
        {
            string firstTime = "";
            string secondTime = "";
            bool holder = false;
            foreach (var time in times)
            {
                foreach (var num in time)
                {
                    if (num == '-')
                    {
                        holder = true;
                        continue;
                    }
                    if (holder)
                    {
                        secondTime += num;
                    }
                    else
                    {
                        firstTime += num;
                    }
                }
            }
            return (firstTime, secondTime);
        }
    }
}
