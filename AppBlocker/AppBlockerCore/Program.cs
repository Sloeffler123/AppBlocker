
using AppBlockerRunApplication;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace AppBlockerAddFilesToList
{
    public static class Files
    {
        public static List<string> filePaths = new();

        public static string timeFrameToBlock;
        // main loop

        // check if file exists and add the path to a list
        public static bool CheckIfFileOrDirectory(string[] paths)
        {
            int count = 0;
            foreach (var path in paths)
            {
                if (File.Exists(path))
                {
                    AddFile(path);
                    count += 1;
                }
                else if (Directory.Exists(path))
                {
                    DirectoryFilesToBlock(path);
                    count += 1;
                }
            }
            return count == paths.Length;
        }

        public static bool CheckCorrectDaysFormat(string days)
        {
            string[] allDays = new string[] { 
                "sunday",
                "monday", 
                "tuesday", 
                "wednesday", 
                "thursday", 
                "friday", 
                "saturday"  
            };
            string firstPart = "";
            string secondPart = "";
            bool triggered = false;
            foreach (var s in days)
            {
                if (s == '-')
                {
                    triggered = true;
                    continue;
                }
                if (triggered)
                {
                    secondPart += s;
                }
                else
                {
                    firstPart += s;
                }
            }
            if (!allDays.Contains(firstPart.ToLower()) || !allDays.Contains(secondPart.ToLower()))
            {
                return false;
            }
            if (Array.IndexOf(allDays, firstPart.ToLower()) >= Array.IndexOf(allDays, secondPart.ToLower()))
            {
                return false;
            }
            return true;
        }

        public static void AddFile(string path)
        {
            if (path.EndsWith(".exe"))
            {
                path = path.Replace(".exe", "");
                
                filePaths.Add(path);
            }
        }

        public static void AddDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryFilesToBlock(path);
            }
        }
        
        public static bool CheckIfTimeFrameIsNotLarger(string timeFrame)
        {
            var splitTimeFrame = timeFrame.Split("-");
            return (int.Parse(splitTimeFrame[0].Replace(":", "")) >= int.Parse(splitTimeFrame[1].Replace(":", "")));
            
        }
        public static bool CheckIfTimeFrameValid(string timeFrame)
        {
            if (CheckIfTimeFrameIsNotLarger(timeFrame))
            {
                return false;
            }
            List<string> times = new();
            var firstPart = "";
            var secondPart = "";
            bool triggered = false;
            foreach (var time in timeFrame)
            {
                if (time == '-')
                {
                    triggered = true;
                    continue;
                }
                else if (triggered)
                {
                    secondPart += time;
                }
                else
                {
                    firstPart += time;
                }
            }
            var first = DateTime.TryParseExact(
                firstPart,
                "HH:mm",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out _
            );
            var second = DateTime.TryParseExact(
                secondPart,
                "HH:mm",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out _
            );
            return second && first;
        }
        // display random words for the user to unlock
        public static List<string> DisplayRandomWords()
        {
            List<string> fileContents = File.ReadAllLines("C:\\Users\\samlo\\OneDrive\\Desktop\\AppBlockerClean\\AppBlocker\\AppBlockerCore\\random_words.txt").ToList();
            List<string> wordsFromFile = new();
            Random random = new();
            for (int i = 0; i < 5; i++)
            {
                int randomInt = random.Next(0, fileContents.Count);
                string randomWord = fileContents[randomInt];
                Console.Write($"{randomWord} ");
                wordsFromFile.Add(randomWord);
            }
            return wordsFromFile;
        }
        // where user will type the random words
        public static bool UserTyping(string userInput)
        {

            while (true)
            {
                List<string> words = DisplayRandomWords();
                Console.WriteLine();
                if (userInput != string.Join(" ", words))
                {
                    Console.WriteLine("Sorry thats incorrect you have to start all over");
                    Console.WriteLine();
                }
                else
                {
                    filePaths.Remove(userInput);
                    File.WriteAllLines("C:\\Users\\samlo\\OneDrive\\Desktop\\AppBlockerClean\\AppBlocker\\AppBlockerCore\\user_files_to_block.txt", filePaths);
                    break;
                }
            }
            return true;
        }

        public static void DirectoryFilesToBlock(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (Directory.Exists(file))
                {
                    continue;
                }
                if (file.EndsWith(".exe"))
                {
                    var newPath = file.Replace(".exe", "");
                    filePaths.Add(newPath);
                }
            }
        }
    }
}