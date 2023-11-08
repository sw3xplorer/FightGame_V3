using System.Xml.Serialization;

public class Combat
{
    public static void InCombat(Fighter player, Fighter enemy, Constructor constructor, Armory armory)
    {
        
        Player_ASCII.Draw(player);
        bool bossFight = false;
        int totalKills = 0;
        int multihitDamage = 0;
        UI.HpBar(5, 10, player.maxHp, player.hp);
        UI.ManaBar(5, 13, player.maxMana, player.mana);
        UI.EnergyBar(5, 15, player.maxEnergy, player.energy);
        UI.HpBar(65, 10, enemy.maxHp, enemy.hp);
        UI.MenuLine();
        UI.AttackLabel(player);
        Random generator = new Random();
        int totalSpeed;
        while(player.hp > 0)
        {
            
            Console.SetCursorPosition(0,0);
            UI.HpBar(5, 10, player.maxHp, player.hp);
            UI.ManaBar(5, 13, player.maxMana, player.mana);
            UI.EnergyBar(5, 15, player.maxEnergy, player.energy);
            UI.HpBar(65, 10, enemy.maxHp, enemy.hp);

            totalSpeed = player.speed + player.weapon.bonusSpeed;
            // PLAYER ACTS FIRST
            
            // PLAYER ACTS
            if(totalSpeed >= enemy.speed)
            {
                Attack(player, enemy);
                WeaponBonus(player, enemy, armory);

                // ENEMY ACTS
                if(enemy.hp > 0)
                {
                    EnemyAttack(enemy, player);
                }
            }

            // ENEMY ACTS FIRST

            else
            {
                EnemyAttack(enemy, player);

                // PLAYER ACTS

                if(player.hp > 0)
                {
                    Attack(player, enemy);
                    WeaponBonus(player, enemy, armory);
                }
            }

            UI.HpBar(5, 10, player.maxHp, player.hp);
            UI.ManaBar(5, 13, player.maxMana, player.mana);
            UI.EnergyBar(5, 15, player.maxEnergy, player.energy);
            UI.HpBar(65, 10, enemy.maxHp, enemy.hp);

            if(enemy.hp <= 0)
            {
                UI.ClearArea((int)(Console.WindowWidth * 0.7), (int)(Console.WindowHeight * 0.3), Console.WindowWidth - 1, (int)(Console.WindowHeight * 0.9) - 1);
                bossFight = false;
                totalKills++;
                constructor.kills++;
                Console.SetCursorPosition(0, Console.LargestWindowHeight-1);
                Console.WriteLine($"Kills: {totalKills}");

                if(player.energy < player.maxEnergy)
                    {
                        if((player.energy + 10) > player.maxEnergy)
                        {
                            player.energy += (player.maxEnergy - player.energy);
                        }
                        else
                        {
                            player.energy += 10;
                        }
                    }
                enemy.abilities.Clear();
                Console.SetCursorPosition(0,0);
                Console.WriteLine("Enemy defeated!");
                Task.Delay(1000).Wait();
                Console.SetCursorPosition(0,0);
                Console.WriteLine("                                                              ");
                armory.GiveReward(player);
                bossFight = BossPrompt(constructor, bossFight);
                if(!bossFight)
                {
                    constructor.BuildEnemy(enemy);
                }
                else
                {
                    constructor.BuildBoss(enemy);
                }

            }

        }
        UI.ClearArea((int)(Console.WindowWidth * 0.1), (int)(Console.WindowHeight * 0.3), (int)Console.WindowWidth / 2, (int)(Console.WindowHeight * 0.9) - 1);
        Restart(totalKills, player, enemy, constructor, armory);
    }
    public static int ExtraHits(Fighter fighter, int damage)
    {
        int hits;
        Random generator = new Random();
        if(fighter.name == "Owen" && (fighter.choice == 2 || fighter.choice == 3))
        {
            if(fighter.choice == 2)
            {
                hits = generator.Next(10);
                damage = hits*5;
            }
            else if(fighter.choice == 3)
            {
                hits = generator.Next(20);
                damage = hits*10;
            }
        }
        return damage;
    }

    public static bool BossPrompt(Constructor lists, bool boss)
    {
        Console.SetCursorPosition(0,0);
        Console.WriteLine("Press Enter to continue");
        string prompt = Console.ReadLine();
        Console.SetCursorPosition(0, 1);
        Console.WriteLine("                                     ");
        foreach(string bPrompt in lists.bossPromps)
        {
            if(prompt == bPrompt)
            {
                lists.bossPrompt = bPrompt;
                boss = true;
            }
        }
        Console.SetCursorPosition(0,0);
        Console.WriteLine("                                                ");
        return boss;
    }

    public static void WeaponBonus(Fighter player, Fighter enemy, Armory armory)
    {
        Random generator = new Random();
        for(int i = 0; i < armory.legendaryWeapons.Count; i++)
        {
            string weaponName = armory.legendaryWeapons[i].name;
            if(player.weapon.name == weaponName)
            {
                if(player.weapon.name == "Boltcaster")
                {
                    if(generator.Next(100) < 29)
                    {
                        enemy.hp -= player.weapon.passiveBonusDamage;
                    }
                }
                else if(player.weapon.name == "Superfors DB 2020 Dead Blow Hammer")
                {
                    if(generator.Next(100) < 29)
                    {
                        Attack(player, enemy);
                    }
                }
                else if(player.weapon.name == "Masamune")
                {
                    if(enemy.hp <= (int)(enemy.maxHp*0.07))
                    {
                        enemy.hp = -7;
                    }
                }
                else if(player.weapon.name == "Silver Knives")
                {
                    UI.ManaBar(5, 13, player.maxMana, player.mana);
                    UI.EnergyBar(5, 15, player.maxEnergy, player.energy);
                    player.weapon.bonusCritChance = 100;
                    player.weapon.bonusCritDamage = 5;
                    Attack(player, enemy);
                    player.weapon.bonusCritChance = 45;
                    player.weapon.bonusCritDamage = 3;
                    UI.HpBar(65, 10, enemy.maxHp, enemy.hp);
                }
                else if(player.weapon.name == "Spear of Gungnir")
                {
                    if(player.hp < player.maxHp)
                    {
                        if(player.hp + 50 > player.maxHp)
                        {
                            player.hp += (player.maxHp - player.hp);
                        }
                        else
                        {
                            player.hp += 50;
                        }
                    }
                }
                else if(player.weapon.name == "Sword of Hisou")
                {
                   while(generator.Next(100) < 19)
                   {
                        enemy.hp -= player.weapon.passiveBonusDamage;
                        Attack(player, enemy);
                   }
                }
                else if(player.weapon.name == "Nuclear Fusion Cannon")
                {
                    if(generator.Next(100) < 24)
                    {
                        enemy.hp -= player.weapon.passiveBonusDamage;
                    }
                }
                else if(player.weapon.name == "")
                {

                }
                else if(player.weapon.name == "")
                {

                }
                else if(player.weapon.name == "")
                {

                }
                else if(player.weapon.name == "")
                {

                }
                else if(player.weapon.name == "")
                {

                }
                else if(player.weapon.name == "")
                {

                }
            }
        }
        UI.HpBar(65, 10, enemy.maxHp, enemy.hp);
    }
    public static void Attack(Fighter player, Fighter enemy)
    {
        int multihitDamage = 0;
        int totalDamage;
        Random generator = new Random();
        player.Control(player);
                totalDamage = player.abilities[player.choice].damage + player.weapon.extraDamage + ExtraHits(player, multihitDamage);
                if(generator.Next(100) < player.abilities[player.choice].critChance + player.weapon.bonusCritChance)
                {
                    enemy.hp -= totalDamage * (player.abilities[player.choice].critMultiplier + player.weapon.bonusCritDamage);
                    if(player.energy < player.maxEnergy)
                    {
                        if((player.energy + 2) > player.maxEnergy)
                        {
                            player.energy++;
                        }
                        else
                        {
                            player.energy += 2;
                        }
                    }
                    player.mana -= player.abilities[player.choice].manaCost;

                    Console.SetCursorPosition(0,0);
                    Console.WriteLine("Critical hit!");
                    Task.Delay(1000).Wait();
                    Console.SetCursorPosition(0,0);
                    Console.WriteLine("                                                              ");
                }
                else
                {
                    enemy.hp -= totalDamage;
                    if(player.energy < player.maxEnergy)
                    {
                        if((player.energy + 2) > player.maxEnergy)
                        {
                            player.energy++;
                        }
                        else
                        {
                            player.energy += 2;
                        }
                    }
                    player.mana -= player.abilities[player.choice].manaCost;

                }
                player.confirmAttack = false;
    }
    public static void EnemyAttack(Fighter enemy, Fighter player)
    {
        int totalDamage = 0;
        Random generator = new Random();
        if(enemy.hp > 0)
                {
                    totalDamage = enemy.abilities[0].damage;
                    if(generator.Next(100) < enemy.abilities[0].critChance)
                    {
                        player.hp -= totalDamage * enemy.abilities[0].critMultiplier;
                        if(player.energy < player.maxEnergy)
                        {
                            player.energy++;
                        }
                    }
                    else
                    {
                        player.hp -= enemy.abilities[0].damage;
                        if(player.energy < player.maxEnergy)
                        {
                            player.energy++;
                        }
                    }
                }
    }
    public static void Restart(int totalKills, Fighter player, Fighter enemy, Constructor constructor, Armory armory)
    {
        bool restart = false;
        int choice = 0;
        Console.SetCursorPosition((int)(Console.LargestWindowWidth*0.48), (int)(Console.LargestWindowHeight*0.5));
        Console.WriteLine("No");
        Console.SetCursorPosition((int)(Console.LargestWindowWidth*0.5), (int)(Console.LargestWindowHeight*0.5));
        Console.WriteLine("Yes");
        Console.SetCursorPosition((int)(Console.LargestWindowWidth*0.48), (int)(Console.LargestWindowHeight*0.5+2));
        Console.WriteLine("Restart?");

        while(!restart)
        {
            if(choice >= 0 && choice <= 1)
            {
                if((choice * (int)(Console.LargestWindowWidth*0.5)) == 0)
                {
                    Console.SetCursorPosition((int)(Console.LargestWindowWidth * 0.48)-1, (int)(Console.LargestWindowHeight*0.5));
                }
                else
                {
                    Console.SetCursorPosition((choice * (int)(Console.LargestWindowWidth*0.5))-1, (int)(Console.LargestWindowHeight*0.5));
                }
                Console.Write(">");
            }

            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.RightArrow && choice < 1)
            {
                choice++;
                Console.SetCursorPosition(((int)(Console.LargestWindowWidth*0.48))-1, (int)(Console.LargestWindowHeight*0.5));
                Console.Write(" ");
            }
            else if (key.Key == ConsoleKey.LeftArrow && choice > 0)
            {
                choice--;
                Console.SetCursorPosition(((int)(Console.LargestWindowWidth*0.5))-1, (int)(Console.LargestWindowHeight*0.5));
                Console.Write(" ");
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                restart = true;
                Console.Clear();
                Task.Delay(500).Wait();
                
            }

            if(restart && choice == 1)
            {
                totalKills = 0;
                player.abilities.Clear();
                player.weapon = new();
                player.name = null;
                constructor.addedDamage = 0;
                constructor.addedHp = 0;
                constructor.built = 0;
                Info.CharacterStats(player);
                constructor.RestartConstructor(player, enemy);
                InCombat(player, enemy, constructor, armory);
            }
            else if(restart && choice == 0)
            {
                System.Environment.Exit(1);
            }
        }
    }
}
