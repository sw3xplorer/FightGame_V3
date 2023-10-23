public class Fighter
{
    public bool confirmItem = false;
    public bool confirmAttack = false;
    public int choice;
    public string name;
    public int energy = 0;
    public int maxEnergy;
    public int hp;
    public int maxHp;
    public int mana;
    public int maxMana;
    public int speed;
    public Weapon weapon = new();
    public List<Ability> abilities = new();

    public void Control(Fighter fighter)
    {
        while (!confirmAttack)
        {
            if (choice >= 0 && choice <= 3)
            {
                Console.SetCursorPosition(choice * (int)(Console.WindowWidth * 0.25), (int)(Console.LargestWindowHeight * 0.95));
                Console.Write(">");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.RightArrow && choice < 3)  //true gör så att man inte ritar det man skriver
                {
                    choice++;
                    Console.SetCursorPosition((choice - 1) * (int)(Console.WindowWidth * 0.25), (int)(Console.LargestWindowHeight * 0.95));
                    Console.Write(" ");
                }
                else if (key.Key == ConsoleKey.LeftArrow && choice > 0)
                {
                    choice--;
                    Console.SetCursorPosition((choice + 1) * (int)(Console.WindowWidth * 0.25), (int)(Console.LargestWindowHeight * 0.95));
                    Console.Write(" ");
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if((fighter.mana - fighter.abilities[choice].manaCost < 0))
                    {
                        Console.SetCursorPosition(0,0);
                        Console.WriteLine("Not enough mana");
                        Task.Delay(1000).Wait();
                        Console.SetCursorPosition(0,0);
                        Console.WriteLine("                                             ");
                    }

                    else if(fighter.energy != fighter.maxEnergy && choice == 3)
                    {
                        Console.SetCursorPosition(0,0);
                        Console.WriteLine("Not enough energy");
                        Task.Delay(1000).Wait();
                        Console.SetCursorPosition(0,0);
                        Console.WriteLine("                                             ");
                    }

                    else
                    {
                        confirmAttack = true;
                        if(choice == 3)
                        {
                            energy = 0;
                        }
                    }
                }
            }
        }
    }
    public int ItemControl(int choice)
    {
        confirmItem = false;
        Console.SetCursorPosition(1, 0);
        Console.WriteLine("No");
        Console.SetCursorPosition((int)(Console.WindowWidth * 0.04) + 1, 0);
        Console.WriteLine("Yes");
        choice = 0;
        while (!confirmItem)
        {
            if (choice >= 0 && choice <= 1)
            {
                Console.SetCursorPosition(choice * (int)(Console.WindowWidth * 0.04), 0);
                Console.Write(">");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.RightArrow && choice < 1)  //true gör så att man inte ritar det man skriver
                {
                    choice++;
                    Console.SetCursorPosition((choice - 1) * (int)(Console.WindowWidth * 0.04), 0);
                    Console.Write(" ");
                }
                else if (key.Key == ConsoleKey.LeftArrow && choice > 0)
                {
                    choice--;
                    Console.SetCursorPosition((choice + 1) * (int)(Console.WindowWidth * 0.04), 0);
                    Console.Write(" ");
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    confirmItem = true;
                    Console.SetCursorPosition(0,0);
                    Console.WriteLine("                                       ");
                }
            }
        }
        return choice;
    }
}