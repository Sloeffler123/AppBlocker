
// goal
// app blocker that blocks applications that are inputed for a certain time period
// user c# ui to make this more interactive 
// use creative ways to disable the software like typing 100 words, ect
// make a safety net 
// make sure it runs with low effort in the background
// 

// make a class that checks if the users file they inputed exists



namespace AppBlockerAddFilesToList
{
    public class FileChecker
    {
        public static List<string> filePaths = new();
        // main loop
        public static void Main()
        {
            AddFileToList();
            DisplayFiles();
        }

        // check if file exists and add the path to a list 
        public static void AddFileToList()
        {
            Console.WriteLine("Would you like to add a (1) file or (2) directory?");
            string fileOrDirectory = Console.ReadLine();
            if (fileOrDirectory == "1")
            {
                while (true)
                {
                    Console.WriteLine("Please input the file you would like to block");
                    string path = Console.ReadLine();
                    if (File.Exists(path))
                    {
                        Console.WriteLine($"{path} exists");
                        filePaths.Add(path);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a path that exists");
                    }
                }
            }
            if (fileOrDirectory == "2")
            {
                while (true)
                {
                    Console.WriteLine("Please input the file you would like to block");
                    string path = Console.ReadLine();
                    if (Directory.Exists(path))
                    {
                        Console.WriteLine($"{path} exists.");
                        filePaths.Add(path);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a path that exists");
                    }
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
                    Console.WriteLine($"{pathToDelete} deleted");
                    filePaths.Remove(pathToDelete);
                    break;
                }
            }
        }


    }
}