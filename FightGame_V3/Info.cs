public class Info
{
    // public static Info i = new();

    public static void StartScreen()
    {
        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        Console.WriteLine("USE FULLSCREEN FOR BEST EXPERIENCE! OTHERWISE STUFF WILL BREAK");
        Console.WriteLine("NOTE: All characters belong to their respective copyright owners.");
        Console.Write("Press enter to start: ");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine(@"__________                   __               __    ___________
\______   \_______  ____    |__| ____   _____/  |_  \_   _____/
 |     ___/\_  __ \/  _ \   |  |/ __ \_/ ___\   __\  |    __)  
 |    |     |  | \(  <_> )  |  \  ___/\  \___|  |    |     \   
 |____|     |__|   \____/\__|  |\___  >\___  >__|    \___  /   
                        \______|    \/     \/            \/    ");
        Task.Delay(500).Wait();
        Console.WriteLine(@"  _________ __                 __   
 /   _____//  |______ ________/  |_ 
 \_____  \\   __\__  \\_  __ \   __\
 /        \|  |  / __ \|  | \/|  |  
/_______  /|__| (____  /__|   |__|  
        \/           \/             ");
        Console.WriteLine(@"                            __   
                            \ \  
  ______   ______   ______   \ \ 
 /_____/  /_____/  /_____/   / / 
                            /_/  
                                 ");
        Console.ReadLine();
        Console.Clear();
    }

    public static void ViewTutorial()
    {
        bool confirmTutorial = false;
        int choice = 0;
        Console.SetCursorPosition(1, 0);
        Console.WriteLine("Yes");
        Console.SetCursorPosition(1, (int)(Console.WindowHeight * 0.05));
        Console.WriteLine("No");
        Console.WriteLine("\nView the tutorial?");
        while (!confirmTutorial)
        {
            if (choice >= 0 && choice <= 1)
            {
                Console.SetCursorPosition(0, choice * (int)(Console.WindowHeight * 0.05));
                Console.Write(">");
            }

            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.DownArrow && choice < 1)
            {
                choice++;
                Console.SetCursorPosition(0, (choice - 1) * (int)(Console.WindowHeight * 0.25));
                Console.WriteLine(" ");
            }
            else if (key.Key == ConsoleKey.UpArrow && choice > 0)
            {
                choice--;
                Console.SetCursorPosition(0, (choice + 1) * (int)(Console.LargestWindowHeight * 0.05));
                Console.Write(" ");
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                confirmTutorial = true;
                Console.Clear();
            }

            if(confirmTutorial && choice == 0)
            {
                Tutorial();
            }
        }
    
    }

    public static void Tutorial()
    {
        Console.WriteLine(@"___________      __               .__       .__   
\__    ___/_ ___/  |_  ___________|__|____  |  |  
  |    | |  |  \   __\/  _ \_  __ \  \__  \ |  |  
  |    | |  |  /|  | (  <_> )  | \/  |/ __ \|  |__
  |____| |____/ |__|  \____/|__|  |__(____  /____/
                                          \/      ");
        Task.Delay(500).Wait();
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("\nCharacters have 4 different attacks (abilities) which you can use.");
        Console.WriteLine("You use the right and left arrows to select an attack, then press enter to attack.");
        Console.WriteLine("\nYour objective is to clear as many waves as possible without dying.");
        Console.WriteLine("After a few waves, an elite enemy will appear. They are harder to beat but they have a chance of dropping healing and upgrades.");
        Console.WriteLine("\nPress enter when done reading.");
        Console.ReadLine();
    }
}
