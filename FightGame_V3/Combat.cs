using System.Xml.Serialization;

public class Combat
{

    public static void InCombat(Fighter player, Fighter enemy, Constructor constructor, Armory armory)
    {
        int totalKills = 0;
        int multihitDamage = 0;
        UI.HpBar(5, 10, player.maxHp, player.hp);
        UI.ManaBar(5, 13, player.maxMana, player.mana);
        UI.EnergyBar(5, 15, player.maxEnergy, player.energy);
        UI.HpBar(65, 10, enemy.maxHp, enemy.hp);
        UI.MenuLine();
        UI.AttackLabel(player);
        Random generator = new Random();
        int totalDamage;
        while(player.hp >= 0)
        {
            
            UI.HpBar(5, 10, player.maxHp, player.hp);
            UI.ManaBar(5, 13, player.maxMana, player.mana);
            UI.EnergyBar(5, 15, player.maxEnergy, player.energy);
            UI.HpBar(65, 10, enemy.maxHp, enemy.hp);

            // PLAYER ACTS FIRST

            if(player.speed > enemy.speed)
            {
                player.Control(player);
                totalDamage = player.abilities[player.choice].damage + player.weapon.extraDamage + ExtraHits(player, multihitDamage);
                if(generator.Next(100) < player.abilities[player.choice].critChance + player.weapon.bonusCritChance)
                {
                    enemy.hp -= totalDamage * (player.abilities[player.choice].critMultiplier + player.weapon.bonusCritDamage);
                    if(player.energy < player.maxEnergy)
                    {
                        if((player.energy += 2) > player.maxEnergy)
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
                        if((player.energy += 2) > player.maxEnergy)
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

            // ENEMY ACTS FIRST

            else if(enemy.speed > player.speed)
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

                player.Control(player);
                totalDamage = player.abilities[player.choice].damage + player.weapon.extraDamage + ExtraHits(player, multihitDamage);
                if(generator.Next(100) < player.abilities[player.choice].critChance + player.weapon.bonusCritChance)
                {
                    enemy.hp -= totalDamage * (player.abilities[player.choice].critMultiplier + player.weapon.bonusCritDamage);
                    if(player.energy < player.maxEnergy)
                    {
                        if((player.energy += 2) > player.maxEnergy)
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
                        if((player.energy += 2) > player.maxEnergy)
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

            UI.HpBar(5, 10, player.maxHp, player.hp);
            UI.ManaBar(5, 13, player.maxMana, player.mana);
            UI.EnergyBar(5, 15, player.maxEnergy, player.energy);
            UI.HpBar(65, 10, enemy.maxHp, enemy.hp);

            if(enemy.hp <= 0)
            {
                totalKills++;
                constructor.kills++;
                Console.SetCursorPosition(0, Console.LargestWindowHeight);
                Console.WriteLine($"Kills: {totalKills}");

                if(player.energy < player.maxEnergy)
                    {
                        if((player.energy += 10) > player.maxEnergy)
                        {
                            player.energy += (player.maxEnergy - player.energy);
                        }
                        else
                        {
                            player.energy += 10;
                        }
                    }
                enemy.abilities.Clear();
                constructor.BuildEnemy(enemy);
                Console.SetCursorPosition(0,0);
                Console.WriteLine("Enemy defeated!");
                Task.Delay(1000).Wait();
                Console.SetCursorPosition(0,0);
                Console.WriteLine("                                                              ");
                armory.GiveReward(player);

            }

        }

    }

    public static int ExtraHits(Fighter fighter, int damage)
    {
        int hits;
        Random generator = new Random();
        if(fighter.name == "Owen" && (fighter.choice == 2 || fighter.choice == 3))
        {
            if(fighter.choice == 2)
            {
                hits = generator.Next(6);
                damage = hits*5;
            }
            else if(fighter.choice == 3)
            {
                hits = generator.Next(10);
                damage = hits*10;
            }
        }
        return damage;
    }
}
