using System.Formats.Asn1;
using AppBlockerRunApplication;

namespace AppBlockerAddFilesToList
{
    public static class Files
    {
        public static List<string> filePaths = new();

        public static string timeFrameToBlock;
        // display how to use the app blocker
        public static void HowToUse()
        {
            Console.WriteLine("To block apps you can either block a specific file or an entire folder. To do so the easiest way is to go to that file or folders location and copy the address location. When asked what file or folder to block paste in the path of the file you copied.");
            Console.WriteLine();
            Console.WriteLine("You can easily delete files and folders you have setup, however it comes with a price. Your valuable time. In order to delete a file or folder you must type down 200 words without messing up. Now I know that might sound a little ridicoulious but come on dont you wanna stop using these apps so much? Also you will have unlimited time to complete the type test, just make sure you dont enter with any mistakes or you will have to start all over.");
        }
        // main loop
        public static void Main()
        {
            HowToUse();
            Console.WriteLine();
            UserInterface();
            RunApplication.DetectIfFilesAreRunning();
        }
        // loop for the user to interact with and decide what they want to do
        public static string PromptUserInterfaceInput()
        {
            Console.WriteLine("What would you like to do? (1) Add files and folders/(2) Display files and folders/(3) Delete files and folders/(4) Change time frame/(5) Exit");
            Console.WriteLine();
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void UserInterface()
        {
            while (true)
            {
                string userInput = PromptUserInterfaceInput();

                if (userInput == "1")
                {
                    AddFileOrDirectory();
                }
                else if (userInput == "2")
                {
                    DisplayFiles();
                }
                else if (userInput == "3")
                {
                    DeleteUserPath();
                }
                else if (userInput == "4")
                {
                    PromptUserForTimeFrame();
                }
                else if (userInput == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }
            }
        }
        // check if file exists and add the path to a list
        public static void AddFile(string path)
        {
            if (File.Exists(path))
            {
                if (path.EndsWith(".exe"))
                {
                    path = path.Replace(".exe", "");
                }
                Console.WriteLine($"{path} - Added");
                filePaths.Add(path);
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
        }

        public static void WritePathsToBlock()
        {
            foreach (var word in filePaths)
            {
                File.WriteAllText("user_files_to_block.txt", word);
            }
        }

        public static string PromptForFileOrDirectory()
        {
            Console.WriteLine("Would you like to add a (1) file (2) directory (3) exit?");
            var userInput = Console.ReadLine();
            return userInput;
        }

        public static void AddFileOrDirectory()
        {
            while (true)
            {
                var userInput = PromptForFileOrDirectory();

                if (userInput == "1")
                {
                    AddFile(userInput);
                }
                else if (userInput == "2")
                {
                    AddDirectory(userInput);
                }
                else if (userInput == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }
            }
        }
        // diplay files
        public static void DisplayFiles()
        {

            foreach (var path in filePaths)
            {
                Console.WriteLine(path);
            }
        }
        // delete file from list
        public static string PromptUserForPathToDelete()
        {
            Console.WriteLine("Which file would you like to delete? Please input the path / (1) Exit");
            DisplayFiles();
            Console.WriteLine();
            var userInput = Console.ReadLine();
            return userInput;
        }

        public static void DeleteUserPath()
        {
            while (true)
            {
                var userInput = PromptUserForPathToDelete();
                if (userInput == "1")
                {
                    break;
                }
                else if (!filePaths.Contains(userInput))
                {
                    Console.WriteLine("Please enter a valid path");
                }
                else if (UserTyping(userInput))
                {
                    Console.WriteLine($"{userInput} deleted");
                }
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

        public static string PromptUserForTimeFrame()
        {
            Console.WriteLine("What time frame would you like to block these apps? EX: 0600-1400 / (1) Exit");
            var userInput = Console.ReadLine();
            return userInput;
        }

        public static void TimeFrameToBlock()
        {
            while (true)
            {
                var userInput = PromptUserForTimeFrame();
                if (userInput == "1")
                {
                    Console.WriteLine("GoodBye");
                    break;
                }
                if (TryGetValidTimeFrame(userInput))
                {
                    Console.WriteLine($"Apps will be blocked from {timeFrameToBlock}");
                    File.WriteAllText("time_frame_to_block.txt", timeFrameToBlock);
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a valid time frame");
                }
            }
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
            List<string> fileContents = File.ReadAllLines("C:\\Users\\samlo\\OneDrive\\Desktop\\tempcsharp\\AppBlocker\\random_words.txt").ToList();
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
                    File.WriteAllLines("user_files_to_block.txt", filePaths);
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