public class Info
{
    // public static Info i = new();
    public int choice = 0;
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
                Task.Delay(500).Wait();
            }

            if (confirmTutorial && choice == 0)
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
        Console.WriteLine("You use the right and left arrows to select an attack (and character in the character select), then press enter to attack (or to confirm character).");
        Console.WriteLine("\nYour objective is to clear as many waves as possible without dying.");
        Console.WriteLine("After a few waves, an elite enemy will appear. They are harder to beat but they have a chance of dropping healing and upgrades.");
        Console.WriteLine("\nPress enter when done reading.");
        Console.ReadLine();
        Task.Delay(500).Wait();
    }

    public static void CharacterStats(Fighter player)
    {
        int choice = 0;
        bool confirmCharacter = false;

        Console.WriteLine(@"  _________      .__                 __           .__                                __                
 /   _____/ ____ |  |   ____   _____/  |_    ____ |  |__ _____ ____________    _____/  |_  ___________ 
 \_____  \_/ __ \|  | _/ __ \_/ ___\   __\ _/ ___\|  |  \\__  \\_  __ \__  \ _/ ___\   __\/ __ \_  __ \
 /        \  ___/|  |_\  ___/\  \___|  |   \  \___|   Y  \/ __ \|  | \// __ \\  \___|  | \  ___/|  | \/
/_______  /\___  >____/\___  >\___  >__|    \___  >___|  (____  /__|  (____  /\___  >__|  \___  >__|   
        \/     \/          \/     \/            \/     \/     \/           \/     \/          \/       ");

        Console.WriteLine("\n");
        Console.WriteLine("");
        Console.WriteLine(@" _____                    
|  _  |                   
| | | |_      _____ _ __  
| | | \ \ /\ / / _ \ '_ \ 
\ \_/ /\ V  V /  __/ | | |
 \___/  \_/\_/ \___|_| |_|
                          
                          ");
        Console.WriteLine("\n");
        Console.WriteLine("");
        Console.WriteLine("HP: 500");
        Console.WriteLine("Mana: 300");
        Console.WriteLine("Speed: 25");
        Console.WriteLine("\n");
        Console.WriteLine("");
        Console.WriteLine(@"  ___  _     _ _ _ _   _           
 / _ \| |   (_) (_) | (_)          
/ /_\ \ |__  _| |_| |_ _  ___  ___ 
|  _  | '_ \| | | | __| |/ _ \/ __|
| | | | |_) | | | | |_| |  __/\__ \
\_| |_/_.__/|_|_|_|\__|_|\___||___/
                                   
                                   ");
        Console.WriteLine("\n");
        Console.WriteLine("");
        Console.WriteLine("Basic ATK: 25 DMG");
        Console.WriteLine("Thunder leap: 35 DMG, 15 mana");
        Console.WriteLine("Rising storm: 45 + 5/hit, 30 mana");
        Console.WriteLine("Attack with a chance to cause multiple hits");
        Console.WriteLine("\n(ULTIMATE) Hurricane sting: 10/hit + 100, 70 mana");
        Console.WriteLine("Hit multiple times and finish of with a powerful blow");

        while (!confirmCharacter)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.RightArrow && choice < 1)
            {
                choice++;
                Console.Clear();
                Console.WriteLine(@"  _________      .__                 __           .__                                __                
 /   _____/ ____ |  |   ____   _____/  |_    ____ |  |__ _____ ____________    _____/  |_  ___________ 
 \_____  \_/ __ \|  | _/ __ \_/ ___\   __\ _/ ___\|  |  \\__  \\_  __ \__  \ _/ ___\   __\/ __ \_  __ \
 /        \  ___/|  |_\  ___/\  \___|  |   \  \___|   Y  \/ __ \|  | \// __ \\  \___|  | \  ___/|  | \/
/_______  /\___  >____/\___  >\___  >__|    \___  >___|  (____  /__|  (____  /\___  >__|  \___  >__|   
        \/     \/          \/     \/            \/     \/     \/           \/     \/          \/       ");

                Console.WriteLine("\n");
                Console.WriteLine("");
                Console.WriteLine(@"___  ___     _ _               
|  \/  |    | (_)              
| .  . | ___| |_ ___ ___  __ _ 
| |\/| |/ _ \ | / __/ __|/ _` |
| |  | |  __/ | \__ \__ \ (_| |
\_|  |_/\___|_|_|___/___/\__,_|
                               
                               ");
                Console.WriteLine("\n");
                Console.WriteLine("");

                Console.WriteLine("HP: 750");
                Console.WriteLine("Mana: 250");
                Console.WriteLine("Speed: 20");
                Console.WriteLine("\n");
                Console.WriteLine("");
                Console.WriteLine(@"  ___  _     _ _ _ _   _           
 / _ \| |   (_) (_) | (_)          
/ /_\ \ |__  _| |_| |_ _  ___  ___ 
|  _  | '_ \| | | | __| |/ _ \/ __|
| | | | |_) | | | | |_| |  __/\__ \
\_| |_/_.__/|_|_|_|\__|_|\___||___/
                                   
                                   ");
                Console.WriteLine("\n");
                Console.WriteLine("");

                Console.WriteLine("Basic ATK: 20 DMG");
                Console.WriteLine("Stellar bolt: 35 DMG, 20 mana");
                Console.WriteLine("Fireball: 65 DMG, 35 mana");
                Console.WriteLine("\n(ULTIMATE) Spectrum Laser: 250 DMG, 120 mana");
                Console.WriteLine("Powerful laser. Nothing more to say");
            }
            else if (key.Key == ConsoleKey.LeftArrow && choice > 0)
            {
                choice--;
                Console.Clear();
                Console.WriteLine(@"  _________      .__                 __           .__                                __                
 /   _____/ ____ |  |   ____   _____/  |_    ____ |  |__ _____ ____________    _____/  |_  ___________ 
 \_____  \_/ __ \|  | _/ __ \_/ ___\   __\ _/ ___\|  |  \\__  \\_  __ \__  \ _/ ___\   __\/ __ \_  __ \
 /        \  ___/|  |_\  ___/\  \___|  |   \  \___|   Y  \/ __ \|  | \// __ \\  \___|  | \  ___/|  | \/
/_______  /\___  >____/\___  >\___  >__|    \___  >___|  (____  /__|  (____  /\___  >__|  \___  >__|   
        \/     \/          \/     \/            \/     \/     \/           \/     \/          \/       ");

                Console.WriteLine("\n");
                Console.WriteLine("");
                Console.WriteLine(@" _____                    
|  _  |                   
| | | |_      _____ _ __  
| | | \ \ /\ / / _ \ '_ \ 
\ \_/ /\ V  V /  __/ | | |
 \___/  \_/\_/ \___|_| |_|
                          
                          ");
                Console.WriteLine("\n");
                Console.WriteLine("");
                Console.WriteLine("HP: 500");
                Console.WriteLine("Mana: 300");
                Console.WriteLine("Speed: 25");
                Console.WriteLine("\n");
                Console.WriteLine("");
                Console.WriteLine(@"  ___  _     _ _ _ _   _           
 / _ \| |   (_) (_) | (_)          
/ /_\ \ |__  _| |_| |_ _  ___  ___ 
|  _  | '_ \| | | | __| |/ _ \/ __|
| | | | |_) | | | | |_| |  __/\__ \
\_| |_/_.__/|_|_|_|\__|_|\___||___/
                                   
                                   ");
                Console.WriteLine("\n");
                Console.WriteLine("");
                Console.WriteLine("Basic ATK: 20 DMG");
                Console.WriteLine("Thunder leap: 35 DMG, 15 mana");
                Console.WriteLine("Rising storm: 40 + 5/hit, 30 mana");
                Console.WriteLine("Attack with a chance to cause multiple hits");
                Console.WriteLine("\n(ULTIMATE) Hurricane sting: 10/hit + 100, 70 mana");
                Console.WriteLine("Hit multiple times and finish of with a powerful blow");
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                confirmCharacter = true;
                Console.Clear();
                Console.WriteLine(@"  ________                        .__                                                           .__                
 /  _____/_____    _____   ____   |__| ______   ____  ____   _____   _____   ____   ____   ____ |__| ____    ____  
/   \  ___\__  \  /     \_/ __ \  |  |/  ___/ _/ ___\/  _ \ /     \ /     \_/ __ \ /    \_/ ___\|  |/    \  / ___\ 
\    \_\  \/ __ \|  Y Y  \  ___/  |  |\___ \  \  \__(  <_> )  Y Y  \  Y Y  \  ___/|   |  \  \___|  |   |  \/ /_/  >
 \______  (____  /__|_|  /\___  > |__/____  >  \___  >____/|__|_|  /__|_|  /\___  >___|  /\___  >__|___|  /\___  / 
        \/     \/      \/     \/          \/       \/            \/      \/     \/     \/     \/        \//_____/  ");
                Task.Delay(2000).Wait();
                Console.Clear();
            }

            if (confirmCharacter && choice == 0)
            {
                player.name = "Owen";
            }
            else
            {
                player.name = "Melissa";
            }
        }
    }

}
