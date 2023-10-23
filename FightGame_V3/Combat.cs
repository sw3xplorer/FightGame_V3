public class Combat
{
    public static void InCombat(Fighter player, Fighter enemy, Constructor constructor)
    {
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
                player.Control();
                totalDamage = player.abilities[player.choice].damage + player.weapon.extraDamage;
                if(generator.Next(100) < player.abilities[player.choice].critChance + player.weapon.bonusCritChance)
                {
                    enemy.hp -= totalDamage * (player.abilities[player.choice].critMultiplier + player.weapon.bonusCritDamage);
                    player.energy += 2;
                    player.mana -= player.abilities[player.choice].manaCost;
                }
                else
                {
                    enemy.hp -= totalDamage;
                    player.energy += 2;
                    player.mana -= player.abilities[player.choice].manaCost;

                }
                player.confirmAttack = false;

                totalDamage = enemy.abilities[0].damage;
                if(generator.Next(100) < enemy.abilities[0].critChance)
                {
                    player.hp -= totalDamage * enemy.abilities[0].critMultiplier;
                    player.energy++;
                }
                else
                {
                    player.hp -= enemy.abilities[0].damage;
                    player.energy++;
                }
            }

            // ENEMY ACTS FIRST

            else if(enemy.speed > player.speed)
            {
                totalDamage = enemy.abilities[0].damage;
                if(generator.Next(100) < enemy.abilities[0].critChance)
                {
                    player.hp -= totalDamage * enemy.abilities[0].critMultiplier;
                    player.energy++;

                }
                else
                {
                    player.hp -= enemy.abilities[0].damage;
                    player.energy++;
                }

                player.Control();
                totalDamage = player.abilities[player.choice].damage + player.weapon.extraDamage;
                if(generator.Next(100) < player.abilities[player.choice].critChance + player.weapon.bonusCritChance)
                {
                    enemy.hp -= totalDamage * (player.abilities[player.choice].critMultiplier + player.weapon.bonusCritDamage);
                    player.energy += 2;
                    player.mana -= player.abilities[player.choice].manaCost;

                }
                else
                {
                    enemy.hp -= totalDamage;
                    player.energy += 2;
                    player.mana -= player.abilities[player.choice].manaCost;
                }
                player.confirmAttack = false;
            }

            if(enemy.hp <= 0)
            {
                enemy.abilities.Clear();
                constructor.BuildEnemy(enemy);
                Console.SetCursorPosition(0,0);
                Console.WriteLine("Enemy defeated!");
                Task.Delay(1000).Wait();
                Console.SetCursorPosition(0,0);
                Console.WriteLine("                                                              ");

            }

        }

    }
}
