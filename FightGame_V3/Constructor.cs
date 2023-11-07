public class Constructor
{
    Random generator = new Random();
    int enemyType;
    public string bossPrompt;
    public int kills;
    // agile [0], normal [1], brute [2], elite [3]
    public List<int> playerHp = new() { 500, 750 }; //char 1 and char 2 hp
    public List<int> playerEnergy = new() { 100, 120 };
    public List<int> playerSpeed = new() { 25, 20 };

    public List<int> enemyHp = new() { 100, 250, 500, 1250 }; //agile unit, normal, brute, elite hp values
    public List<int> enemySpeed = new() { 30, 15, 18, 19 };
    public List<int> enemyDamage = new() { 20, 35, 50, 65 };
    public List<int> manaCapacity = new() { 300, 250, 0 }; //0 for enemy


    // Bosses: Tagilla, Genesis, Minos Prime
    public List<string> bossPromps = new() { "5%", "Loveless", "Creature of steel", "sus", "Ashina" };
    public List<string> bossNames = new() { "Tagilla", "Genesis", "Minos Prime", "Amogus", "Isshin, the Sword Saint" };
    public List<string> bossIntro = new() { "*angry russian*", "That's no way to talk to a hero!", "Thy punishment... is death!", "Amogus, sus!", "Come at me..." };
    public List<int> bossHp = new() { 2500, 2000, 3000, 2750, 3000 };
    public List<int> bossSpeed = new() { 35, 50, 40, 30, 45 };
    public List<int> bossDamage = new() { 80, 90, 85, 1, 110 };
    public List<int> bossCritChance = new() { 15, 35, 20, 1, 5 };
    public List<int> bossCritMultiplier = new() { 5, 3, 4, 6666666, 100 };
    public Constructor(Fighter player, Fighter enemy)
    {
        if (player.name == "Owen")
        {
            player.maxHp = playerHp[0];
            player.hp = playerHp[0];
            player.maxMana = manaCapacity[0];
            player.mana = manaCapacity[0];
            player.speed = playerSpeed[0];
            player.maxEnergy = playerEnergy[0];

            player.abilities.Add(new() { name = "Basic ATK", damage = 45, critChance = 5, critMultiplier = 2, manaCost = 0 });
            player.abilities.Add(new() { name = "Thunder Leap", damage = 65, critChance = 5, critMultiplier = 2, manaCost = 15 });
            player.abilities.Add(new() { name = "Rising Storm", damage = 80, critChance = 10, critMultiplier = 2, manaCost = 30 });
            player.abilities.Add(new() { name = "Hurricane Sting", damage = 100, critChance = 10, critMultiplier = 2, manaCost = 70 });
            
        }
        else
        {
            player.maxHp = playerHp[1];
            player.hp = playerHp[1];
            player.maxMana = manaCapacity[1];
            player.mana = manaCapacity[1];
            player.speed = playerSpeed[1];
            player.maxEnergy = playerEnergy[1];

            player.abilities.Add(new() { name = "Basic ATK", damage = 35, critChance = 5, critMultiplier = 3, manaCost = 0 });
            player.abilities.Add(new() { name = "Stellar Bolt", damage = 45, critChance = 10, critMultiplier = 3, manaCost = 20 });
            player.abilities.Add(new() { name = "Fireball", damage = 90, critChance = 15, critMultiplier = 5, manaCost = 35 });
            player.abilities.Add(new() { name = "Spectrum Laser", damage = 250, critChance = 15, critMultiplier = 5, manaCost = 120 });
        }

        enemyType = generator.Next(3);
        enemy.maxHp = enemyHp[enemyType];
        enemy.hp = enemyHp[enemyType];
        enemy.speed = enemySpeed[enemyType];
        enemy.abilities.Add(new() { damage = enemyDamage[enemyType] });
    }

    public void BuildEnemy(Fighter enemy)
    {
        if(kills == 10)
        {
            enemy.maxHp = enemyHp[3];
            enemy.hp = enemyHp[3];
            enemy.speed = enemySpeed[3];
            enemy.abilities.Add(new() { damage = enemyDamage[3] });
            kills = 0;
        }

        else
        {
            enemyType = generator.Next(2);
            enemy.maxHp = enemyHp[enemyType];
            enemy.hp = enemyHp[enemyType];
            enemy.speed = enemySpeed[enemyType];
            enemy.abilities.Add(new() { damage = enemyDamage[enemyType] });
            
        }
    }

    public void BuildBoss(Fighter boss)
    {
        for (int i = 0; i < bossPromps.Count; i++)
        {
            string prompt = bossPromps[i];
            if(bossPrompt == prompt)
            {
                boss.name = bossNames[i];
                boss.maxHp = bossHp[i];
                boss.hp = bossHp[i];
                boss.speed = bossSpeed[i];
                boss.abilities.Add(new()  { damage = bossDamage[i], critChance = bossCritChance[i], critMultiplier = bossCritMultiplier[i] });
                Console.SetCursorPosition(0,0);
                Console.WriteLine(bossIntro[i]);
                Task.Delay(3000).Wait();
                UI.ClearArea(0,0, 100, 1);
                Enemy_ASCII.Draw(boss);
            }
        }
    }
}
