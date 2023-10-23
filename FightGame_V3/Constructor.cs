public class Constructor
{
    Random generator = new Random();
    int enemyType;
    // agile [0], normal [1], brute [2], elite [3]
    public List<int> playerHp = new() { 500, 750 }; //char 1 and char 2 hp
    public List<int> playerEnergy = new() { 100, 120 };
    public List<int> playerSpeed = new() { 25, 20 };
    public List<int> enemyHp = new() { 100, 250, 500, 1250 }; //agile unit, normal, brute, elite hp values
    public List<int> enemySpeed = new() { 30, 15, 18, 19 };
    public List<int> enemyDamage = new() { 20, 35, 50, 65 };
    public List<int> manaCapacity = new() { 300, 250, 0 }; //0 for enemy
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

            player.abilities.Add(new() { name = "Basic ATK", damage = 25, critChance = 5, critMultiplier = 2, manaCost = 0 });
            player.abilities.Add(new() { name = "Thunder Leap", damage = 35, critChance = 5, critMultiplier = 2, manaCost = 15 });
            player.abilities.Add(new() { name = "Rising Storm", damage = 45, critChance = 10, critMultiplier = 2, manaCost = 30 });
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

            player.abilities.Add(new() { name = "Basic ATK", damage = 20, critChance = 5, critMultiplier = 3, manaCost = 0 });
            player.abilities.Add(new() { name = "Stellar Bolt", damage = 35, critChance = 10, critMultiplier = 3, manaCost = 20 });
            player.abilities.Add(new() { name = "Fireball", damage = 65, critChance = 15, critMultiplier = 5, manaCost = 35 });
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
        enemyType = generator.Next(3);
        enemy.maxHp = enemyHp[enemyType];
        enemy.hp = enemyHp[enemyType];
        enemy.speed = enemySpeed[enemyType];
        enemy.abilities.Add(new() { damage = enemyDamage[enemyType] });
    }
}
