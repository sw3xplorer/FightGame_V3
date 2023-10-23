public class Fighter
{
    public bool confirmAttack = false;
    public int choice = 0;
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

    public void Control()
    {
        while(!confirmAttack)
        {
            if (choice >= 0 && choice <= 3)
            {
                Console.SetCursorPosition(choice * (int)(Console.WindowWidth * 0.25), (int)(Console.LargestWindowHeight*0.95));
                Console.Write(">");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.RightArrow && choice < 3)  //true gör så att man inte ritar det man skriver
                {
                    choice++;
                    Console.SetCursorPosition((choice-1) * (int)(Console.WindowWidth * 0.25), (int)(Console.LargestWindowHeight*0.95));
                    Console.Write(" ");
                }
                else if (key.Key == ConsoleKey.LeftArrow && choice > 0)
                {
                    choice--;
                    Console.SetCursorPosition((choice+1) * (int)(Console.WindowWidth * 0.25), (int)(Console.LargestWindowHeight*0.95));
                    Console.Write(" ");
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    confirmAttack = true;
                }   
            }
        }
    }
    public void Test()
    {

    }
}