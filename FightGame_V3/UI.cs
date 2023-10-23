public class UI
{
    public static void HpBar(float x, float y, int maxHp, int hp)
    {
        x = Console.WindowWidth * (x / 100);
        y = Console.WindowHeight * (y / 100);
        Console.SetCursorPosition((int)x, (int)y);
        Console.Write("<");
        for (var i = 0; i < Console.WindowWidth * 0.25; i++) 
        {
            if (hp / (float)maxHp > i / (Console.WindowWidth * 0.25))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.Write("█");
        }
        Console.ResetColor();
        Console.SetCursorPosition((int)x + (int)(Console.WindowWidth*0.25)+1, (int)y);
        Console.WriteLine($">{hp}/{maxHp}  ");
    }
    public static void ManaBar(float x, float y, int maxMana, int mana)
    {
        x = Console.WindowWidth * (x / 100);
        y = Console.WindowHeight * (y / 100);
        Console.SetCursorPosition((int)x, (int)y);
        Console.Write("<");
        for (var i = 0; i < Console.WindowWidth * 0.25; i++) 
        {
            if (mana / (float)maxMana > i / (Console.WindowWidth * 0.25))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.Write("█");
        }
        Console.ResetColor();
        Console.SetCursorPosition((int)x + (int)(Console.WindowWidth*0.25)+1, (int)y);
        Console.WriteLine($">{mana}/{maxMana}  ");
    }

    public static void EnergyBar(float x, float y, int maxEnergy, int energy)
    {
        x = Console.WindowWidth * (x / 100);
        y = Console.WindowHeight * (y / 100);
        Console.SetCursorPosition((int)x, (int)y);
        Console.Write("<");
        for (var i = 0; i < Console.WindowWidth * 0.25; i++) 
        {
            if (energy / (float)maxEnergy > i / (Console.WindowWidth * 0.25))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.Write("█");
        }
        Console.ResetColor();
        Console.SetCursorPosition((int)x + (int)(Console.WindowWidth*0.25)+1, (int)y);
        Console.WriteLine($">{energy}/{maxEnergy}  ");
    }

    public static void MenuLine()
    {
        Console.SetCursorPosition(0, (int)(Console.LargestWindowHeight * 0.9));
        for (var i = 0; i < Console.WindowWidth; i++)
        {
            Console.Write("-");
        }
    }

    public static void AttackLabel(Fighter player)
    {
        Console.SetCursorPosition(1, (int)(Console.LargestWindowHeight*0.95));
        Console.WriteLine($"{player.abilities[0].name}");
        Console.SetCursorPosition((int)(Console.WindowWidth * 0.25) + 1, (int)(Console.LargestWindowHeight*0.95));
        Console.WriteLine($"{player.abilities[1].name}");
        Console.SetCursorPosition((int)(Console.WindowWidth * 0.5) + 1, (int)(Console.LargestWindowHeight*0.95));
        Console.WriteLine($"{player.abilities[2].name}");
        Console.SetCursorPosition((int)(Console.WindowWidth * 0.75) + 1, (int)(Console.LargestWindowHeight*0.95));
        Console.WriteLine($"{player.abilities[3].name}");
    }
}
