using AppBlockerAddFilesToList;
using AppBlockerRunApplication;
namespace AppBlockerAddFilesToList
{
    public class Files
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
        public static void UserInterface()
        {
            while (true)
            {
                Console.WriteLine("What would you like to do? (1) Add files and folders/(2) Display files and folders/(3) Delete files and folders/(4) Change time frame/(5) Exit");
                Console.WriteLine();
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    AddFileToList();
                }
                else if (userInput == "2")
                {
                    DisplayFiles();
                }
                else if (userInput == "3")
                {
                    DeleteFileFromList();
                }
                else if (userInput == "4")
                {
                    TimeToBlockApps();
                }
                else
                {
                    break;
                }
            }
        }
        // check if file exists and add the path to a list 
        public static void AddFileToList()
        {
            while (true)
            {
                Console.WriteLine("Would you like to add a (1) file (2) directory (3) exit?");
                string fileOrDirectory = Console.ReadLine();
                if (fileOrDirectory == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("Please input the file you would like to block");
                        string path = Console.ReadLine();
                        if (File.Exists(path))
                        {
                            Console.WriteLine($"{path} - Added");
                            if (path.EndsWith(".exe"))
                            {
                                var newPath = path.Replace(".exe", "");
                                filePaths.Add(newPath);
                            }
                            else
                            {
                                filePaths.Add(path);
                            }
                            
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a path that exists");
                        }
                    }
                }
                else if (fileOrDirectory == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("Please input the folder you would like to block");
                        string path = Console.ReadLine();
                        if (Directory.Exists(path))
                        {
                            Console.WriteLine($"{path} - Added");
                            // open directory and add the files to the list to block
                            DirectoryFilesToBlock(path);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a path that exists");
                        }
                    }
                }
                else
                {
                    TimeToBlockApps();

                    if (filePaths.Count > 0)
                    {
                        foreach (var word in filePaths)
                        {
                            File.WriteAllText("user_files_to_block.txt", word);
                        }
                    }
                    Console.WriteLine("GoodBye");
                    break;
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
        public static void DeleteFileFromList()
        {
            while (true)
            {
                Console.WriteLine("Which file would you like to delete? Please input the path");
                DisplayFiles();
                Console.WriteLine();
                string pathToDelete = Console.ReadLine();
                if (!filePaths.Contains(pathToDelete))
                {
                    Console.WriteLine("Please input a path in the list");
                }
                else
                {
                    if (UserTyping())
                    {
                        Console.WriteLine($"{pathToDelete} deleted");
                        filePaths.Remove(pathToDelete);
                        File.WriteAllLines("user_files_to_block.txt", filePaths);
                        break;
                    }

                }
            }
        }
        // time frame to block
        public static void TimeToBlockApps()
        {
            string timeFrame = "";
            while (true)
            {
                Console.WriteLine("What time frame would you like to block these apps? EX: 0600-1400 / (1) Exit");
                Console.WriteLine();
                timeFrame = Console.ReadLine();
                if (timeFrame == "1")
                {
                    Environment.Exit(0);
                }
                else if (CheckIfTimeFrameValid(timeFrame))
                {
                    Console.WriteLine($"Apps will be blocked from {timeFrame}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a valid time frame");
                }
            }
            timeFrameToBlock = timeFrame;
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
        public static bool UserTyping()
        {

            while (true)
            {
                List<string> words = DisplayRandomWords();
                Console.WriteLine();
                string userInput = Console.ReadLine();
                if (userInput != string.Join(" ", words))
                {
                    Console.WriteLine("Sorry thats incorrect you have to start all over");
                    Console.WriteLine();
                }
                else
                {
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