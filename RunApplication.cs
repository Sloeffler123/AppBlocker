using System.Diagnostics;
using System.IO;
using System.Linq;

namespace AppBlockerRunApplication
{
    class RunApplication
    {
        public static void DetectIfFilesAreRunning()
        {
            List<string> paths = File.ReadAllLines(@"C:\Users\samlo\OneDrive\Desktop\tempcsharp\AppBlocker\user_files_to_block.txt")
                                       .Select(p => p.Trim().ToLower()).ToList();
            var targetPaths = FindEndOfPath(paths);
            foreach (var path in targetPaths)
            {
                foreach (var process in Process.GetProcessesByName(path))
                {
                    process.Kill();
                    process.WaitForExit();
                    
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
    }
}
