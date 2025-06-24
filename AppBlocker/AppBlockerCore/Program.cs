
using AppBlockerRunApplication;

namespace AppBlockerAddFilesToList
{
    public static class Files
    {
        public static List<string> filePaths = new();

        public static string timeFrameToBlock;
        // main loop
        public static void Main()
        {
            
            Console.WriteLine();
            
            RunApplication.DetectIfFilesAreRunning();
        }

        // check if file exists and add the path to a list
        public static void CheckIfFileOrDirectory(string path)
        {
            if (File.Exists(path))
            {
                AddFile(path);
            }
        }
        public static void AddFile(string path)
        {
            
            if (path.EndsWith(".exe"))
            {
            path = path.Replace(".exe", "");
            Console.WriteLine($"{path} - Added");
            filePaths.Add(path);
            }
            else
            {
                Console.WriteLine($"{path} could not be found. Please double check spelling");
            }
        }

        public static void AddDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                Console.WriteLine($"{path} - Added");
                // open directory and add the files to the list to block
                DirectoryFilesToBlock(path);
            }
            else
            {
                Console.WriteLine($"{path} could not be found. Please double check spelling");
            }
        }
        
        // time frame to block
        public static bool TryGetValidTimeFrame(string input)
        {
            if (input == "1")
            {
                return false;
            }
            if (CheckIfTimeFrameValid(input))
            {
                timeFrameToBlock = input;
                return true;
            }
            return false;
        }

        // check if time frame given is valid (Helper method)
        public static bool CheckIfTimeFrameValid(string timeFrame)
        {
            if (timeFrame.Length < 9 || timeFrame.Length > 9)
            {
                return false;
            }
            foreach (var num in timeFrame)
            {
                int newNum = (int)char.GetNumericValue(num);
                if (num == '-')
                {
                    continue;
                }
                else if (newNum <= 9 && newNum >= 0)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
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